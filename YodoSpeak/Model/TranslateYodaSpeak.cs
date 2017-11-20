using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;



namespace YodoSpeak.Model
{
    public static class TranslateYodaSpeak
    {
        public static string YodaSpeak(string inputString)
        {
            string result = string.Empty;
            try 
            {
                if (!string.IsNullOrEmpty(inputString)) 
                { 
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("https://yoda.p.mashape.com/");
                    client.DefaultRequestHeaders.Add("X-Mashape-Key", System.Configuration.ConfigurationSettings.AppSettings["MarketMashpeKey"].ToString());
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                    HttpResponseMessage response = client.GetAsync("yoda?sentence=" + inputString.ToString()).Result;
                    
                    if (response.IsSuccessStatusCode)
                    {
                        var clientresult = response.Content.ReadAsStringAsync().Result;
                        return result = clientresult;
                    }
                    else
                    {
                        return result;
                    }
                    
                }
                else
                {
                    return result;
                }

            }
            catch (Exception ex) 
            {
                return result;
            }
        }
    }
}
