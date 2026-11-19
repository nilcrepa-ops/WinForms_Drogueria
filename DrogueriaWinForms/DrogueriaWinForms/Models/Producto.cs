using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DrogueriaWinForms.Models
{
    public class Producto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [JsonPropertyName("categoria")]
        public string Categoria { get; set; } = string.Empty;

        [JsonPropertyName("preciokg")]
        public double PrecioKg { get; set; }

        [JsonPropertyName("stockkg")]
        public double StockKg { get; set; }

        public override string ToString()
        {
            return $"{Nombre} ({PrecioKg:C2}/kg - Stock: {StockKg} kg)";
        }
    }
}
