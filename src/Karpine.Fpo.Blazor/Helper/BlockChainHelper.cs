using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;
using Karpine.Fpo.Crops;

namespace Karpine.Fpo.Blazor.Helper
{
    public class BlockChainHelper
    {
        public static string NodeUrl = "https://api.karpine.io";
        public async static void AddMessageObject(CropDto inventoryTrail)
        {
            //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
            string json = JsonConvert.SerializeObject(inventoryTrail);

            Random random = new Random();
            string url = NodeUrl + $"/api/Message/Create";
            string Params = "{'userHash':'KwuNF9Vb7T3fZYCPAZ7yob629Y9fbPyR4dS7gSn94phydvsWJDi9','schema':'Messaging','schemaVersion':'1.0.0','prefix':'San','messageVersion':'1.0.0','messageType': 'CreateMessage','messageid':'" + inventoryTrail.Id.ToString() + "','message':[" + json + "]}";
            HttpContent httpContent = new StringContent(Params.Replace("'", "\""), Encoding.UTF8, "application/json");

            MessageObject message = new MessageObject();
            message.Id = inventoryTrail.Id.ToString();
            message.UserHash = "KwuNF9Vb7T3fZYCPAZ7yob629Y9fbPyR4dS7gSn94phydvsWJDi9";
            message.Schema = "Messaging";
            message.SchemaVersion = "1.0.0";
            message.Prefix = "San";
            message.MessageType = "CreateMessage";
            message.Message = json.Replace("'", "\"");

            var t = await WebRequestHelper.CreateMessageAsync(url, message);
        }
    }
}
