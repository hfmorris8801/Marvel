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
        //HIDDEN HOME
        [Headers("Authorization: Bearer")]
        [Get("/api/v1/home/hidden-home/")]
        Task<ApiResponse<CharacterResponse>> GetHiddenHome(CharacterRequest characterRequest, [Header("Accept-Language")] string language);
    }
}
