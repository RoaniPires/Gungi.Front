using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Gungi.Front.Models;

namespace Gungi.Front.Services
{
    public class GungiApiService
    {
        private readonly HttpClient _httpClient;

        public GungiApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Método para buscar os gastos detalhados
        public async Task<List<GastoDetalhadoDto>> GetGastosDetalhadosAsync()
        {
            return await _httpClient
                       .GetFromJsonAsync<List<GastoDetalhadoDto>>("Gastos/detalhados")
                   ?? new List<GastoDetalhadoDto>();
        }
    }
}