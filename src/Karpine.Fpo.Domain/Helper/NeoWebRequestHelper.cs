using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using Microsoft.IdentityModel;
using IdentityModel.Client;
using Karpine.Fpo.Domain.Helper;

/// <summary>
/// Summary description for WebRequestHelper
/// </summary>
public class NeoWebRequestHelper
{
    public NeoWebRequestHelper()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static string PostWebRequest(string postUrl, string paramData)
    {
        try
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(paramData);
            WebRequest webReq = WebRequest.Create(postUrl);
            webReq.Method = "GET";
            webReq.Headers.Add("Authorization", "Bearer " + WebRequestHelper.GetBearerToken().Result.ToString());
           /* using (Stream newStream = webReq.GetRequestStream())
            {
                newStream.Write(byteArray, 0, byteArray.Length);
            }*/
            using (WebResponse response = webReq.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return "";
    }

    public static string ToGB2312(string str)
    {
        MatchCollection mc = Regex.Matches(str, @"\\u([\w]{2})([\w]{2})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        byte[] bts = new byte[2];
        foreach (Match m in mc)
        {
            bts[0] = (byte)int.Parse(m.Groups[2].Value, NumberStyles.HexNumber);
            bts[1] = (byte)int.Parse(m.Groups[1].Value, NumberStyles.HexNumber);
            str = str.Replace(m.ToString(), Encoding.Unicode.GetString(bts));
        }
        return str;
    }
}