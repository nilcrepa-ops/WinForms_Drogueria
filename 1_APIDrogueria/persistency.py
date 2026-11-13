import encodings
import json
import os

FILE_PRODUCTS = 'products.json'
FILE_SALES = 'sales.json'

initial_products = [
    {"id": 1, "nombre": "Ácido Lisérgico (Precursor)", "categoria": "Alcaloides", "preciokg": 1500.00, "stockkg": 2.5},
    {"id": 2, "nombre": "Clorhidrato de Ketamina (Cristal)", "categoria": "Disociativos", "preciokg": 350.00, "stockkg": 12.0},
    {"id": 3, "nombre": "Salvia Divinorum (Extracto 80x)", "categoria": "Entégenos", "preciokg": 850.00, "stockkg": 5.0},
    {"id": 4, "nombre": "Mescalina Pura (Polvo cristalino)", "categoria": "Fenetilaminas", "preciokg": 2200.00, "stockkg": 1.2},
    {"id": 5, "nombre": "Ibogaína HCl (Extracto raíz)", "categoria": "Triptaminas", "preciokg": 1800.00, "stockkg": 3.0}
]

def load_data(file_path: str, default_data: list) -> list:
    if not os.path.exists(file_path):
        save_data(file_path, default_data)
        return default_data
    with open(file_path, 'r', encoding='utf-8') as f:
        return json.load(f)

def save_data(file_path: str, data: list):
    with open(file_path, 'w', encoding='utf-8') as f:
        json.dump(data, f, indent=4, ensure_ascii= False)