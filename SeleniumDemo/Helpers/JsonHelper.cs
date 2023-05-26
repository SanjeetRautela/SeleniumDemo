using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Helpers
{
    public class JsonHelper
    {
        public static T GetModel<T>(string response) where T : class
        {
            var serializeItem = JsonConvert.DeserializeObject<T>(response);
            //Logger.Info($"Response: {response}");
            return serializeItem;
        }
        public static List<T> GetModels<T>(string response) where T : class
        {
            var serializeItems = JsonConvert.DeserializeObject<List<T>>(response);
            //Logger.Info($"Response: {response}");
            return serializeItems;
        }
    }
}
