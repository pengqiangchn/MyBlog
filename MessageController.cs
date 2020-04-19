using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;

namespace SMSApp.Controllers
{
    [Route("api/message")]
    public class MessageController : ControllerBase
    {

        IHttpClientFactory _httpClientFactory;

        public MessageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// ces 
        /// </summary>
        /// <returns></returns>
        public IActionResult Get()
        {
            return Ok(new { ret = "ok" });
        }


        [HttpPost("send")]
        public async Task<IActionResult> Send()
        {
            var submit = new Submit
            {
                EcName = "政企分公司测试",
                //EcName = "\u653f\u4f01\u5206\u516c\u53f8\u6d4b\u8bd5",
                ApId = "demo0",
                SecrectKey = "123qwe",
                Mobiles = "13800138000",
                Content = "移动改变生活。",
                //Content = "\u79fb\u52a8\u6539\u53d8\u751f\u6d3b\u3002",
                Sign = "DWItALe3A",
                AddSerial = ""
            };

            StringBuilder sb = new StringBuilder();
            sb.Append(submit.EcName);
            //sb.Append("\u653f\u4f01\u5206\u516c\u53f8\u6d4b\u8bd5");
            sb.Append(submit.ApId);
            sb.Append(submit.SecrectKey);
            sb.Append(submit.Mobiles);
            sb.Append(submit.Content);
            //sb.Append("\u79fb\u52a8\u6539\u53d8\u751f\u6d3b\u3002");
            sb.Append(submit.Sign);
            sb.Append(submit.AddSerial);

            string mac = Util.GenerateMd5(sb.ToString());

            submit.Mac = mac.ToLower();


            //var setting = new JsonSerializerSettings
            //{
            //    ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
            //};

            //string result = JsonConvert.SerializeObject(submit, setting);

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var json = JsonSerializer.Serialize(submit, options);

            string base64 = Util.Base64Encode(json);



            var client = _httpClientFactory.CreateClient();
            var content = new StringContent(base64);

            var result = await client.PostAsync("http://112.35.1.155:1992/sms/norsubmit", content);



            return Ok(new
            {
                submit = submit,
                base64 = base64
            });
        }

    }
}
