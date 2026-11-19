using DrogueriaWinForms.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace DrogueriaWinForms.Services
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(string baseUrl = "http://127.0.0.1:8000")
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }
        private async Task LanzarExcepcionSiError(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                string contenido = await response.Content.ReadAsStringAsync();
                try
                {
                    using var doc = JsonDocument.Parse(contenido);
                    if (doc.RootElement.TryGetProperty("detail", out var detail))
                    {
                        throw new Exception(detail.GetString());
                    }
                }
                catch (JsonException) { }

                throw new Exception($"Error HTTP {(int)response.StatusCode}: {contenido}");
            }
        }

        public async Task<List<Producto>> GetProductosAsync()
        {
            var response = await _httpClient.GetAsync("/productos");
            await LanzarExcepcionSiError(response);
            return await response.Content.ReadFromJsonAsync<List<Producto>>() ?? new List<Producto>();
        }
        public async Task<Producto?> CrearProductoAsync(Producto producto)
        {
            var response = await _httpClient.PostAsJsonAsync("/productos", producto);
            await LanzarExcepcionSiError(response);
            return await response.Content.ReadFromJsonAsync<Producto>();
        }

        public async Task<Producto?> ActualizarProductoAsync(int id, Producto producto)
        {
            var response = await _httpClient.PutAsJsonAsync($"/productos/{id}", producto);
            await LanzarExcepcionSiError(response);
            return await response.Content.ReadFromJsonAsync<Producto>();
        }

        public async Task EliminarProductoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"/productos/{id}");
            await LanzarExcepcionSiError(response);
        }
        public async Task<List<Venta>> GetVentasAsync()
        {
            var response = await _httpClient.GetAsync("/ventas");
            await LanzarExcepcionSiError(response);
            return await response.Content.ReadFromJsonAsync<List<Venta>>() ?? new List<Venta>();
        }

        public async Task<Venta?> RegistrarVentaAsync(List<LineaVentaInput> lineas)
        {
            var response = await _httpClient.PostAsJsonAsync("/ventas", lineas);
            await LanzarExcepcionSiError(response);
            return await response.Content.ReadFromJsonAsync<Venta>();
        }

        public async Task<InformeVentasHoy?> GetInformeVentasHoyAsync()
        {
            var response = await _httpClient.GetAsync("/informes/ventas-hoy");
            await LanzarExcepcionSiError(response);
            return await response.Content.ReadFromJsonAsync<InformeVentasHoy>();
        }
    }
}
