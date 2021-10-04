using Marvel.ApiClient.Requests;
using Marvel.ApiClient.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.ApiClient.Api
{
    public interface IMarvelApi
    {
        [Get("/v1/public/characters/{id}")]
        Task<ApiResponse<ResponseRoot>> GetCharacterById([AliasAs("id")] int? id, [AliasAs("apikey")] string apiKey, [AliasAs("hash")] string hash, [AliasAs("ts")] string timeSpan);
    }
}
