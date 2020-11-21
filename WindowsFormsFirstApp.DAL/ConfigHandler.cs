using Newtonsoft.Json;
using System;
using System.IO;
using WindowsFormsFirstApp.Model;

namespace WindowsFormsFirstApp.DAL
{
    public class ConfigHandler : IConfigHandler
    {
        public void AddQaUserToJson(QaUser qaUser)
        {
            // TODO : Add the user to the JSON File
            var json = JsonConvert.DeserializeObject(File.ReadAllText("~/AppConfig.json"));
            Console.WriteLine("test");
            throw new NotImplementedException();
        }
    }
}
