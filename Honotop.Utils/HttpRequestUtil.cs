using System;
using System.IO;
using System.Net;
using System.Text;

namespace Honotop.Utils
{
    /// <summary>
    /// http请求处理
    /// </summary>
    public static class HttpRequestUtil
    {
        public static string Get(string StrUrl, int Timeout=300000)
        {
            string strResult = string.Empty;
            try
            {
                HttpWebRequest myReq = (HttpWebRequest)HttpWebRequest.Create(StrUrl);
                myReq.Timeout = Timeout;
                HttpWebResponse HttpWResp = (HttpWebResponse)myReq.GetResponse();
                Stream myStream = HttpWResp.GetResponseStream();
                StreamReader sr = new StreamReader(myStream, Encoding.Default);
                StringBuilder strBuilder = new StringBuilder();
                while (-1 != sr.Peek())
                {
                    strBuilder.Append(sr.ReadLine());
                }

                strResult = strBuilder.ToString();
            }
            catch (Exception exc)
            {
                strResult = "Error: " + exc.Message;
            }
            return strResult;
        }

        private static string Post(string StrUrl, string paramString)
        {
            try
            {
                Encoding encoding = Encoding.Default;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(StrUrl);
                request.Method = "post";
                request.KeepAlive = true;

                if (!string.IsNullOrWhiteSpace(paramString))
                {
                    byte[] buffer = encoding.GetBytes(paramString);
                    request.ContentLength = buffer.Length;
                    request.GetRequestStream().Write(buffer, 0, buffer.Length);
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string result = reader.ReadToEnd();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
