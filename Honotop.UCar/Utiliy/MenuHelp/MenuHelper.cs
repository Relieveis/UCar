using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Honotop.WMS.Utiliy
{
    public class MenuHelper
    {
        public MenuHelper()
        {
        }

        public List<MenuMap> MenuMap { get; set; }

        public void SerializeFile(string path)
        {
            var webPath = HttpContext.Current.Server.MapPath(path);
            //if (!Directory.Exists(webPath))
            //    throw new ArgumentException($"{webPath}路径不存在");
            var str = File.ReadAllText(webPath, Encoding.Default);
            var jsonObject = JObject.Parse(str);

            var root = jsonObject.GetValue("MenuRoot");
            if (root == null)
                throw new ArgumentNullException("menu格式错误，不存在MenuRoot根");

            var rootJson = root.ToString();
            MenuMap = ParseFormJson<List<MenuMap>>(rootJson);
            GenerateMenu(MenuMap);
        }


        public void GenerateMenu(List<MenuMap> Menus)
        {
            foreach (var item in Menus)
            {
                var permission = item.Permission;

                if (!string.IsNullOrWhiteSpace(permission) && false)
                {
                    //var _permissionService = DependencyResolver.Current.GetService<IPermissionService>();
                    //var pers = permission.Split(new char[] { ',', '，', ';', '；' });
                    //foreach (var per in pers)
                    //{
                    //    if (_permissionService.Authorize(per))
                    //    {
                    //        item.IsVisible = true;
                    //        break;
                    //    }
                    //}
                }
                else
                {
                    item.IsVisible = true;
                }

                if (item.MenuChild != null && item.MenuChild.Count() > 0)
                    GenerateMenu(item.MenuChild.ToList());
            }
        }

        public T ParseFormJson<T>(string szJson)
        {
            T obj = Activator.CreateInstance<T>();
            try
            {
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(szJson)))
                {
                    DataContractJsonSerializer dcj = new DataContractJsonSerializer(typeof(T));
                    obj = (T)dcj.ReadObject(ms);
                }
            }
            catch (Exception ex)
            {
                obj = default(T);
            }
            return obj;
        }

     
    }

    public class MenuMap
    {
        public MenuMap()
        {
            MenuChild = new List<MenuMap>();
        }
        public string MenuName { get; set; }
        public string MenuIdentifier { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Url { get; set; }
        public string Permission { get; set; }
        public string Icon { get; set; }
        public bool IsVisible { get; set; }
        public IList<MenuMap> MenuChild { get; set; }

    }
}
