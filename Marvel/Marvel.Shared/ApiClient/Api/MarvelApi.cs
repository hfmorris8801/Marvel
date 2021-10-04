using Marvel.ApiClient.Models;
using Marvel.ApiClient.Responses;
using Marvel.Utils;
using Refit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.ApiClient.Api
{
    public class MarvelApi
    {
        string timeSpan = String.Empty;
        public IMarvelApi Api { get; set; }
        public string Language { get { return CultureInfo.CurrentCulture.ToString(); } }

        public MarvelApi()
        {
            Api = RestService.For<IMarvelApi>(Contants.URL_API);
        }

        public async Task<ResponseRoot> GetCharacterById(int? id)
        {
            string hash = GeneratorMD5.CreateHASH(out timeSpan);
            ApiResponse<ResponseRoot> response = await Api.GetCharacterById(id, Contants.PUBLIC_KEY, hash, timeSpan);
            if (response.IsSuccessStatusCode && response.Content is ResponseRoot responseRoot)
            {
                return responseRoot;
            }
            //else if (response.StatusCode.Equals(System.Net.HttpStatusCode.Unauthorized))
            //{
            //    App.ManageTokenExpired();
            //    throw new Exception(Strings.ExpiredSession);
            //}
            //else
            //{
            //    if (response.StatusCode.Equals(System.Net.HttpStatusCode.NotFound))
            //    {
            //        if (action != null)
            //        {
            //            action.Invoke();
            //        }
            //        throw new Exception(Strings.RemovedSearch);
            //    }
            //    else
            //    {
            //        throw new Exception(!string.IsNullOrEmpty(response.Error.Content) ? ErrorHandler(response.Error.Content) : Strings.ErrorDefault);
            //    }
            //}
            return null;
        }
    }
}
