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
        public IMarvelApi Api { get; set; }
        public string Language { get { return CultureInfo.CurrentCulture.ToString(); } }

        public MarvelApi()
        {
            //Api = RestService.For<IMarvelApi>(Contants.URL_API, new RefitSettings()
            //{
            //    AuthorizationHeaderValueGetter = () =>
            //    {
            //        return Task.FromResult((App.Token != null) ? App.Token.Access : "");
            //    }
            //});
        }
    }
}
