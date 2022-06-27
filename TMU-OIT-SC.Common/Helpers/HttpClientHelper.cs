using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using TMU_OIT_SC.Common.Enum;

namespace TMU_OIT_SC.Common.Helpers
{
    public class HttpClientHelper
    {
        public static HttpResponseMessage HttpClientAsync(HttpVerbs httpVerbs, string url, object data = null)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("message", nameof(url));
            }

            using (var client = new HttpClient())
            {
                //設定Header - Accept的資料型別
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/JSON"));

                HttpResponseMessage? response = null;
                try
                {
                    switch (httpVerbs)
                    {
                        case HttpVerbs.Post:
                            // 將 data 轉為 json
                            string json = JsonConvert.SerializeObject(data);
                            // 將轉為 string 的 json 依編碼並指定 content type 存為 httpcontent
                            HttpContent contentPost = new StringContent(json, Encoding.UTF8, "Application/JSON");

                            response = client.PostAsync(url, contentPost).Result;
                            break;
                        case HttpVerbs.Get:
                        //case HttpVerbs.Put:
                        //case HttpVerbs.Delete:
                        //case HttpVerbs.Patch:
                        default:
                            response = client.GetAsync(url).Result;
                            break;

                    }

                    //處理呼叫結果-Response
                    if (response.IsSuccessStatusCode)
                    {
                        return response;
                    }
                    else
                    {
                        throw new Exception(
                         string.Format("HttpClientAsync Error=>{0}-{1}", response.StatusCode, response.Content));
                    }
                }
                catch 
                {
                    //Log.WriteLog(LogLevel.Error, JsonHelper.ObjectToJson(response) + ex.ToString(), MethodBase.GetCurrentMethod());
                    throw;
                }
            }
        }
    }
}
