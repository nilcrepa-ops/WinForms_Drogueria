from typing import List
from pydantic import BaseModel, Field

class Producto(BaseModel):
    id: int
    nombre: str
    categoria: str
    preciokg: float = Field(..., gt=0, description="El precio debe ser mayor que 0")
    stockkg: float = Field(..., ge=0, description="El stock no puede ser negativo")

class LineaVentaInput(BaseModel):
    producto_id: int
    kilos: float = Field(..., gt=0)

class LineaVentaDetalle(BaseModel):
    producto_id: int
    nombre: str
    kilos: float
    preciokg: float
    subtotal: float

class Venta(BaseModel):
    id: int
    fecha: str
    lineas: List[LineaVentaDetalle]
    total: float