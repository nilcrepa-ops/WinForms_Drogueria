from datetime import datetime, date
from typing import List
from fastapi import APIRouter, HTTPException
from data_model import Producto, Venta, LineaVentaInput, LineaVentaDetalle
from persistency import load_data, save_data, FILE_PRODUCTS, FILE_SALES, initial_products

router = APIRouter()

@router.get("/productos", response_model=List[Producto])
def listar_productos():
    return load_data(FILE_PRODUCTS, initial_products)

@router.post("/productos", response_model=Producto, status_code=201)
def crear_producto(producto: Producto):
    productos = load_data(FILE_PRODUCTS, initial_products)
    ids_existentes = [p["id"] for p in productos]
    if producto.id in ids_existentes or producto.id <= 0:
        producto.id = max(ids_existentes, default=0) + 1
    productos.append(producto.model_dump())
    save_data(FILE_PRODUCTS, productos)
    return producto

@router.put("/productos/{id}", response_model=Producto)
def actualizar_producto(id: int, producto_actualizado: Producto):
    productos = load_data(FILE_PRODUCTS, initial_products)
    for i, prod in enumerate(productos):
        if prod["id"] == id:
            producto_actualizado.id = id
            productos[i] = producto_actualizado.model_dump()
            save_data(FILE_PRODUCTS, productos)
            return producto_actualizado
    raise HTTPException(status_code=404, detail=f"Producto con ID {id} no encontrado")

@router.delete("/productos/{id}")
def borrar_producto(id: int):
    productos = load_data(FILE_PRODUCTS, initial_products)
    nuevos_productos = [p for p in productos if p["id"] != id]
    if len(nuevos_productos) == len(productos):
        raise HTTPException(status_code=404, detail=f"Producto con ID {id} no encontrado")
    save_data(FILE_PRODUCTS, nuevos_productos)
    return {"ok": True, "mensaje": f"Producto {id} eliminado correctamente"}

@router.get("/ventas", response_model=List[Venta])
def listar_ventas():
    return load_data(FILE_SALES, [])

@router.post("/ventas", response_model=Venta, status_code=201)
def registrar_venta(lineas_input: List[LineaVentaInput]):
    if not lineas_input:
        raise HTTPException(status_code=400, detail="La venta debe contener al menos un producto")

    productos = load_data(FILE_PRODUCTS, initial_products)
    ventas = load_data(FILE_SALES, [])
    mapa_productos = {p["id"]: p for p in productos}
    
    lineas_detalle = []
    total_venta = 0.0

    for item in lineas_input:
        if item.producto_id not in mapa_productos:
            raise HTTPException(status_code=404, detail=f"Producto ID {item.producto_id} no existe")
        prod = mapa_productos[item.producto_id]
        if prod["stockkg"] < item.kilos:
            raise HTTPException(
                status_code=400, 
                detail=f"Stock insuficiente para '{prod['nombre']}'. Disponible: {prod['stockkg']} kg"
            )

    for item in lineas_input:
        prod = mapa_productos[item.producto_id]
        prod["stockkg"] = round(prod["stockkg"] - item.kilos, 2)
        subtotal = round(prod["preciokg"] * item.kilos, 2)
        total_venta += subtotal
        lineas_detalle.append(LineaVentaDetalle(
            producto_id=prod["id"],
            nombre=prod["nombre"],
            kilos=item.kilos,
            preciokg=prod["preciokg"],
            subtotal=subtotal
        ))

    nuevo_id_venta = max([v["id"] for v in ventas], default=0) + 1
    nueva_venta = Venta(
        id=nuevo_id_venta,
        fecha=datetime.now().strftime("%Y-%m-%d %H:%M:%S"),
        lineas=lineas_detalle,
        total=round(total_venta, 2)
    )

    save_data(FILE_PRODUCTS, list(mapa_productos.values()))
    ventas.append(nueva_venta.model_dump())
    save_data(FILE_SALES, ventas)

    return nueva_venta

@router.get("/informes/ventas-hoy")
def informe_ventas_hoy():
    ventas = load_data(FILE_SALES, [])
    hoy_str = date.today().strftime("%Y-%m-%d")
    ventas_hoy = [v for v in ventas if v["fecha"].startswith(hoy_str)]
    
    total_recaudado = round(sum(v["total"] for v in ventas_hoy), 2)
    numero_ventas = len(ventas_hoy)
    
    kilos_por_producto = {}
    for v in ventas_hoy:
        for linea in v["lineas"]:
            nombre = linea["nombre"]
            kilos_por_producto[nombre] = kilos_por_producto.get(nombre, 0.0) + linea["kilos"]
            
    producto_top = "Ninguno"
    max_kilos = 0.0
    if kilos_por_producto:
        producto_top = max(kilos_por_producto, key=kilos_por_producto.get)
        max_kilos = round(kilos_por_producto[producto_top], 2)

    return {
        "fecha": hoy_str,
        "total_vendido_hoy": total_recaudado,
        "numero_ventas": numero_ventas,
        "producto_mas_vendido": producto_top,
        "kilos_producto_mas_vendido": max_kilos
    }