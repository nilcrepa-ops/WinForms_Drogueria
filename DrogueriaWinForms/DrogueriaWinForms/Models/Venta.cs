using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DrogueriaWinForms.Models
{
    public class LineaVentaInput
    {
        [JsonPropertyName("producto_id")]
        public int ProductoId { get; set; }

        [JsonPropertyName("kilos")]
        public double Kilos { get; set; }
    }

    public class LineaVentaDetalle
    {
        [JsonPropertyName("producto_id")]
        public int ProductoId { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [JsonPropertyName("kilos")]
        public double Kilos { get; set; }

        [JsonPropertyName("preciokg")]
        public double PrecioKg { get; set; }

        [JsonPropertyName("subtotal")]
        public double Subtotal { get; set; }
    }
    public class Venta
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("fecha")]
        public string Fecha { get; set; } = string.Empty;

        [JsonPropertyName("lineas")]
        public List<LineaVentaDetalle> Lineas { get; set; } = new();

        [JsonPropertyName("total")]
        public double Total { get; set; }
    }

    public class InformeVentasHoy
    {
        [JsonPropertyName("fecha")]
        public string Fecha { get; set; } = string.Empty;

        [JsonPropertyName("total_vendido_hoy")]
        public double TotalVendidoHoy { get; set; }

        [JsonPropertyName("numero_ventas")]
        public int NumeroVentas { get; set; }

        [JsonPropertyName("producto_mas_vendido")]
        public string ProductoMasVendido { get; set; } = string.Empty;

        [JsonPropertyName("kilos_producto_mas_vendido")]
        public double KilosProductoMasVendido { get; set; }
    }
}
