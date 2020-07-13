using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MASGlobal.DataAccess
{
    internal class ApiClient
    {
        private readonly HttpClient _httpClient;
        private Uri BaseEndpoint { get; set; }
        public ApiClient(Uri baseEndpoint)
        {
            BaseEndpoint = baseEndpoint ?? throw new ArgumentNullException("baseEndpoint");
            _httpClient = new HttpClient();
        }      

        internal async Task<List<TEntity>> GetAsyncAll<TEntity>()
        {
            try
            {
                var response = await _httpClient.GetAsync(BaseEndpoint, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                var result = new JavaScriptSerializer().Deserialize<List<TEntity>>(data);
                return result;                
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}