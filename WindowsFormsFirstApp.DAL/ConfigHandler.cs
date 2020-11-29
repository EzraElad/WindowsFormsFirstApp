using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using WindowsFormsFirstApp.Model;

namespace WindowsFormsFirstApp.DAL
{
    public class ConfigHandler : IConfigHandler
    {
        public string GetJson()
        {
            string file = File.ReadAllText("./test.json");
            dynamic json = JsonConvert.DeserializeObject(file);
            return json;
        }
        public void AddQaUserToJson(QaUser qaUser)
        {
            string file = File.ReadAllText("./test.json");
            dynamic json = JsonConvert.DeserializeObject(file);
            json["QaUsername"] = qaUser.Username;
            json["QaPassword"] = qaUser.Password;
            string output = JsonConvert.SerializeObject(json, Formatting.Indented);
            //string assemblyFile = (
            //    new System.Uri(Assembly.GetExecutingAssembly().CodeBase)
            //).AbsolutePath;
            var path =  AppDomain.CurrentDomain.BaseDirectory + @"test.json";
            string just = @"C:\Users\Elad Ezra\Desktop\newWay\2020\C#\WindowsFormsFirstApp\WindowsFormsFirstApp.DAL\test.json";
            string test2 = Environment.CurrentDirectory + @"\test.txt";
            string fileName = String.Format(@"{0}\test.txt", Path.GetDirectoryName(
                        Assembly.GetExecutingAssembly().GetName().CodeBase));
            //"C:/Users/Elad%20Ezra/Desktop/newWay/2020/C"
            File.WriteAllText(path, output);
        }

        public QaUser GetQaUser()
        {
            string jsonValue = GetJson();
            return new QaUser {Username= "s" , Password = "sdsad" };
        }
    }
}
