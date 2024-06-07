using DND.API;
using System.Text.Json;

namespace CharacterManager
{
    public class Settings
    {
        // Default settings file
        private string _filePath = APIReadWrite.RootPath + "\\dndcm_settings.json";

        public string   LastCharacter   { get; set; }
        public bool     SwapAbility     { get; set; }
        public int      Width           { get; set; }
        public int      Height          { get; set; }


        public Settings()
        {
            LastCharacter = string.Empty;
            SwapAbility = false;
            Width = 0;
            Height = 0;
        }

        public Settings(string filePath)
        {
            Settings? settings = null;
            if (File.Exists(filePath))
            {
                var jsonStr = APIReadWrite.GetJsonStringFromFile(filePath);
                if (jsonStr != null)
                    settings = JsonSerializer.Deserialize<Settings>(jsonStr);
            }

            if (settings != null)
            {
                LastCharacter = settings.LastCharacter;
                SwapAbility = settings.SwapAbility;
                Width = settings.Width;
                Height = settings.Height;
            }
            else
            {
                LastCharacter = string.Empty;
                SwapAbility = false;
                Width = 0;
                Height = 0;
            }

            _filePath = filePath;
        }


        public void Save()
        {
            try
            {
                string settingsStr = JsonSerializer.Serialize(this);
                File.WriteAllText(_filePath, settingsStr);
            }
            catch (Exception) { }
        }
    }
}
