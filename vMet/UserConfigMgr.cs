using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace vMet
{
    public class UserConfigMgr
    {
        private readonly string filepath;
        public UserConfig config { get; private set; }
              

        public UserConfigMgr() {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string vMetAppDataFolder = Path.Combine(appDataFolder, "PaulWalkerUK", "vMet");
            filepath = Path.Combine(vMetAppDataFolder, "config.json");
            //config = new UserConfig();
            //config.openWeatherApiKey = "somat";
            //saveConfig();
            loadConfig();
        }

        public void loadConfig()
        {
            try
            {
                string fileData = File.ReadAllText(filepath);
                config = JsonSerializer.Deserialize<UserConfig>(fileData);
            }
            catch (Exception)
            {
                config = new UserConfig();
            }
        }

        public void saveConfig()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filepath));
            string jsonString = JsonSerializer.Serialize(config);
            File.WriteAllText(filepath, jsonString);
        }
    }
}
