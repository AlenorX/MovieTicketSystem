using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProgramOrder
{
    internal class DataTransfer
    {
        private class Data()
        {
            public string login { get; set; }
            public string password { get; set; }
        }

        private class SessionBuy()
        {
            public string login { get; set; }
            public int money { get; set; }
            
        }
        private string URL = "http://127.0.0.1:5000/";
        Data data = new Data();
        SessionBuy sessionBuy = new SessionBuy();
        public string SignIn(string username, string password)
        {
            
            var info = new Data()
            {
                login = username,
                password = password
            };
            string jsonData = JsonSerializer.Serialize(info);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "login");
            request.Method = "POST";
            request.ContentType = "application/json";
            using(StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(jsonData);
                writer.Flush();
                writer.Close();
                
            }
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream())) 
            { 
                string result = reader.ReadToEnd();
                return result;
            }
        }

        public string Registration(string username, string password)
        {
            
            var info = new Data()
            {
                login = username,
                password = password
            };
            string jsonData = JsonSerializer.Serialize(info);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "registration");
            request.Method = "POST";
            request.ContentType = "application/json";
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(jsonData);
                writer.Flush();
                writer.Close();

            }
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd();
                return result;
            }
        }

        public string BuyTicket(string username,int money)
        {
            
            var info = new SessionBuy()
            {
                login = username,
                money = money
            };
            string jsonData = JsonSerializer.Serialize(info);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL + "buy_ticket");
            request.Method = "POST";
            request.ContentType = "application/json";
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(jsonData);
                writer.Flush();
                writer.Close();

            }
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd();
                return result;
            }
        }

    }
}
