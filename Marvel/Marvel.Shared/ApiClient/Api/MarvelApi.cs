using Marvel.ApiClient.Models;
using Marvel.ApiClient.Responses;
using Marvel.Utils;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public async Task<ResponseRoot> GetCharacterById(int? id, ObservableCollection<string> error)
        {
            string hash = GeneratorMD5.CreateHASH(out timeSpan);
            ApiResponse<ResponseRoot> response = await Api.GetCharacterById(id, Contants.PUBLIC_KEY, hash, timeSpan);
            if (response.IsSuccessStatusCode && response.Content is ResponseRoot responseRoot)
            {
                return responseRoot;
            }
            else if(response.Error != null)
            {
                ErrorResponse erp = JsonConvert.DeserializeObject<ErrorResponse>(response.Error.Content);
                error.Add(erp.Message);
            }
            return null;
        }
    }
}
