using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Honotop.Utils
{
  public  class JsonUtil
    {
       
            #region 序列化、反序列化
            /// <summary>
            /// 对象序列化
            /// </summary>
            /// <typeparam name="T">对象类型</typeparam>
            /// <param name="obj">对象</param>
            /// <returns></returns>
            public static String Serialize<T>(T obj)
            {
                if (obj == null)
                {
                    return string.Empty;
                }
                var jss = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };
                return jss.Serialize(obj);
            }
            /// <summary>
            /// 反序列化
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="json"></param>
            /// <returns></returns>
            public static T Deserialize<T>(String json) where T : class, new()
            {
                return String.IsNullOrEmpty(json) ? new T() : JsonToObject<T>(json);
            }

            #endregion

            #region 将时间字符串转为Json时间
            /// <summary>    
            /// 将时间字符串转为Json时间    
            /// </summary>    
            private static string ConvertDateStringToJsonDate(Match m)
            {
                string p = @"\d";
                var cArray = m.Value.ToCharArray();
                StringBuilder sb = new StringBuilder();

                Regex reg = new Regex(p);
                foreach (var t in cArray.Where(t => reg.IsMatch(t.ToString())))
                {
                    sb.Append(t);
                }
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(sb.ToString()));
                dt = dt.ToLocalTime();
                var result = dt.ToString("yyyy-MM-dd HH:mm:ss");
                return result;
            }
            #endregion

            #region JSON文本转对象,泛型方法
            /// <summary>
            /// JSON文本转对象,泛型方法
            /// </summary>
            /// <typeparam name="T">类型</typeparam>
            /// <param name="jsonText">JSON文本</param>
            /// <returns>指定类型的对象</returns>
            public static T JsonToObject<T>(string jsonText)
            {
                if (string.IsNullOrEmpty(jsonText))
                {
                    return default(T);
                }
                const string p = @"\\/Date\(\d+\)\\/";
                MatchEvaluator matchEvaluator = new MatchEvaluator(ConvertDateStringToJsonDate);
                var reg = new Regex(p);
                jsonText = reg.Replace(jsonText, matchEvaluator);
                var jss = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };
                try
                {

                    return jss.Deserialize<T>(jsonText);
                }
                catch (Exception ex)
                {
                    throw new Exception("JSONHelper.JsonToObject(): " + ex.Message);
                }
            }
            /// <summary>
            /// json字符串转成对象
            /// </summary>
            /// <param name="jsonText">json字符串</param>
            /// <param name="obj">对象</param>
            /// <returns></returns>
            /// <exception cref="Exception"></exception>
            public static object JsonToObject(string jsonText, object obj)
            {
                var jss = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue };
                try
                {
                    return jss.Deserialize(jsonText, obj.GetType());

                }
                catch (Exception ex)
                {
                    throw new Exception("JSONHelper.JsonToObject(): " + ex.Message);
                }
            }
            #endregion
        }
    }

