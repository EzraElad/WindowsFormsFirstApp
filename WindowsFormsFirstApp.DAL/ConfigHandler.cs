using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using WindowsFormsFirstApp.Model;

namespace WindowsFormsFirstApp.DAL
{
    public class ConfigHandler : IConfigHandler
    {
        public void AddQaUserToJson(QaUser qaUser)
        {
            // TODO : Add the user to the JSON File
            string file = File.ReadAllText("./test.json");
            dynamic json = JsonConvert.DeserializeObject(file);
            json["QaUsername"] = qaUser.Username;
            json["QaPassword"] = qaUser.Password;
            string output = JsonConvert.SerializeObject(json, Formatting.Indented);
            string assemblyFile = (
                new System.Uri(Assembly.GetExecutingAssembly().CodeBase)
            ).AbsolutePath;
            //"C:/Users/Elad%20Ezra/Desktop/newWay/2020/C"
            File.WriteAllText("/test.json", output);
        }
    }
}
