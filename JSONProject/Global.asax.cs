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

        public static void SendEmail(string clientEmail, string clientName)
        {
            SmtpClient smtpClient = new SmtpClient();

            MailMessage message = new MailMessage();
            try
            {
                // These values should be set by the client.
                MailAddress fromAddress = new MailAddress("comp229@example.com", "From Me");
                message.Subject = "Testing!";
                message.Body = "This is the body of a sample message";

                // These could be static, or dynamic, depending on situation.
                MailAddress toAddress1 = new MailAddress("to@example.com", "You");
                MailAddress toAddress2 = new MailAddress(clientEmail, clientName);
                message.From = fromAddress;
                message.To.Add(toAddress1);
                message.To.Add(toAddress2);
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");
                smtpClient.Send(message);
                System.Net.Mime.ContentType contentType = new System.Net.Mime.ContentType();
                contentType.MediaType = System.Net.Mime.MediaTypeNames.Application.Octet;
                contentType.Name = "newJsonFile";
                message.Attachments.Add(new Attachment(System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data/Assign04new.json"), contentType));

            }
            catch (Exception ex)
            {
            }
        }

    }
}