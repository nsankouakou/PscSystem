using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PscClientCore
{
    public class Utility
    {
        public static int InactivityTimeBeforeReloading = Startup.InactivityTimeBeforeReloading;

        public static HttpClient ClientSolverApi()
        {
            try
            {
               // string currentModule = moduleName;
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(Startup.ApiSerlverService);
                return client;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

        public static HttpClient ClientBaseApi()
        {
            try
            {
                // string currentModule = moduleName;
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(Startup.ApiBaseService);
                return client;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

    }
}