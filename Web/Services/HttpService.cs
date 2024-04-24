using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Text;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Web.Services
{
    public class HttpService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public HttpService(HttpClient httpClient, IOptions<BaseUrlConfiguration> baseUrlConfiguration)
        {
            _httpClient = httpClient;
            _apiUrl = baseUrlConfiguration.Value.ApiBase;
        }

        public async Task<T> HttpGet<T>(string uri)
            where T : class
        {
            var result = await _httpClient.GetAsync($"{_apiUrl}{uri}");
            if (!result.IsSuccessStatusCode)
            {
                return null;
            }

            return await FromHttpResponseMessage<T>(result);
        }

        public async Task HttpPut<T>(string uri, int id, T content)
            where T : class
        {
            string jsonAluno = JsonSerializer.Serialize(content);

            var conteudo = new StringContent(jsonAluno, Encoding.UTF8, "application/json");


            //var conteudo = ToJson(content);

            await _httpClient.PutAsync($"{_apiUrl}{uri}/{id}", conteudo);
        }

        public async Task HttpPut<T>(string uri, T content)
            where T : class
        {
            string jsonAluno = JsonSerializer.Serialize(content);

            var conteudo = new StringContent(jsonAluno, Encoding.UTF8, "application/json");

            var t = await _httpClient.PutAsync($"{_apiUrl}{uri}", conteudo);
        }

        public async Task HttpDelete<T>(string uri, int id)
            where T : class
        {
            await _httpClient.DeleteAsync($"{_apiUrl}/{uri}/{id}");
        }

        public async Task<T> HttpPost<T>(string uri, object dataToSend)
            where T : class
        {
            var content = ToJson(dataToSend);

            var result = await _httpClient.PostAsync($"{_apiUrl}{uri}", content);
            if (!result.IsSuccessStatusCode)
            {
                var errorContent = await result.Content.ReadAsStringAsync();
                var exception = JsonSerializer.Deserialize<ErrorDetails>(errorContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                throw new ApplicationException($"{exception.Error.Details}");
            }

            return await FromHttpResponseMessage<T>(result);
        }

        private StringContent ToJson(object obj)
        {
            return new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
        }

        private async Task<T> FromHttpResponseMessage<T>(HttpResponseMessage result)
        {
            return JsonSerializer.Deserialize<T>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }
    }
}
