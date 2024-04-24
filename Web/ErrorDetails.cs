using System.Text.Json;
using System.Text.Json.Serialization;

namespace Web
{
    public class ErrorDetails
    {
        [JsonPropertyName("error")]
        public ErrorInfo Error { get; set; }

        public class ErrorInfo
        {
            [JsonPropertyName("message")]
            public string Message { get; set; }

            [JsonPropertyName("code")]
            public int Code { get; set; }

            [JsonPropertyName("details")]
            public string Details { get; set; }
        }
    }
}