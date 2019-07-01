using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Piwik.Tracker.Client
{
    internal class MyHttp
    {

        private readonly HttpClient _api;

        public MyHttp()
        {
            _api = new HttpClient() {};

            //            System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            // _api.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer");
        }





        public async Task<HttpResponseMessage> DoRequestAsync(HttpRequestMessage request)
        {
            var response = await _api.SendAsync(request);
            return response;

        }
    }
}
