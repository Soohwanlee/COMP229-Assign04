using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace JSONProject
{
    public class Global : HttpApplication
    {
        public static List<Models.Model.ModelsData> models;
        private const string updateJsonFilePath = @"C:\Users\sam44\Documents\Visual Studio 2015\Projects\JSONProject\JSONProject\App_Data\Assign04.json";


        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ReadData();
        }

        private void ReadData()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("/App_Data/Assign04.json")))
            {
                models = JsonConvert.DeserializeObject<List<Models.Model.ModelsData>>(sr.ReadToEnd());
            }
        }

        public static void UpdateJsonFile()
        {
            using (StreamWriter sw = File.CreateText(System.Web.Hosting.HostingEnvironment.MapPath("/App_Data/Assign04.json")))
            {
                sw.WriteLine(JsonConvert.SerializeObject(models));
            }
        }
    }
}