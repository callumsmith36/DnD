using DND.API;
using DND;
using System.Text.Json;

namespace CharacterManager
{
    internal static class Session
    {
        private static PlayerCharacter  _originalCharacter;
        private static DateTime         _startDateTime;

        public static PlayerCharacter   Player          { get; private set; }
        public static Settings          AppSettings     { get; private set; }
        public static string            ActiveFile      { get; private set; }
        public static string            LogFile         { get; private set; }

        public static bool IsInitialised    { get; private set; } = false;

        public static Action? OnCharacterChanged;


        //
        //  Initialise
        //
        public static int Initialise()
        {
            if (!IsInitialised)
            {
                int errors = 0;

                _startDateTime = DateTime.Now;

                try
                {
                    if (!Directory.Exists(APIReadWrite.RootPath))
                        Directory.CreateDirectory(APIReadWrite.RootPath);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to create data folder. Program cannot continue.", "D&D Character Manager");
                    return 1;
                }

                string logDir = APIReadWrite.RootPath + "\\logs";
                if (!Directory.Exists(logDir))
                    Directory.CreateDirectory(logDir);

                try
                {
                    // Only keep the last 10 log files

                    var logFiles = Directory.GetFiles(logDir);
                    while (logFiles.Length >= 10)
                    {
                        string oldestLog = logFiles[0];
                        for (int i = 1; i < logFiles.Length; i++)
                        {
                            if (File.GetCreationTime(oldestLog) > File.GetCreationTime(logFiles[i]))
                                oldestLog = logFiles[i];
                        }

                        File.Delete(oldestLog);
                        logFiles = Directory.GetFiles(logDir);
                    }
                }
                catch (Exception)
                {
                    errors++;
                }

                LogFile = string.Format("{0}\\dndcm_{1}{2}{3}{4}{5}{6}.log",
                    logDir,
                    _startDateTime.Year,
                    _startDateTime.Month,
                    _startDateTime.Day,
                    _startDateTime.Hour,
                    _startDateTime.Minute,
                    _startDateTime.Second
                );

                string text = "\nD&D Character Manager\n\n" + DateTime.Now.ToString() + "\n\n";
                File.WriteAllText(LogFile, text);

                //errors += APIReadWrite.RetrieveSRDData();
                errors += APIReadWrite.CustomFileStructureSetup();

                string charDir = APIReadWrite.RootPath + "\\characters";
                if (!Directory.Exists(charDir))
                    Directory.CreateDirectory(charDir);

                AppSettings = new Settings(APIReadWrite.RootPath + "\\dndcm_settings.json");
                IsInitialised = true;

                bool charInitialised = false;
                if (!string.IsNullOrWhiteSpace(AppSettings.LastCharacter))
                    charInitialised = OpenCharacter(AppSettings.LastCharacter);
                
                if (!charInitialised)
                    NewCharacter();

                return errors;
            }

            return 0;
        }

        //
        //  IsCharacterModified
        //
        public static bool IsCharacterModified()
        {
            if (!IsInitialised)
                return false;

            return !(Player.Equals(_originalCharacter));
        }

        //
        //  SetCharacter
        //
        public static void SetCharacter(PlayerCharacter character)
        {
            if (IsInitialised)
            {
                Player = character;
                _originalCharacter = new PlayerCharacter(Player);

                OnCharacterChanged?.Invoke();
            }
        }

        //
        //  NewCharacter
        //
        public static void NewCharacter()
        {
            if (IsInitialised)
            {
                _originalCharacter = new PlayerCharacter();
                Player = new PlayerCharacter();

                int n = 1;
                SetActiveFileName("new-character");
                while (File.Exists(ActiveFile))
                {
                    n++;
                    SetActiveFileName(string.Format("new-character-{0}", n));
                }

                OnCharacterChanged?.Invoke();
            }
        }

        //
        //  OpenCharacter
        //
        public static bool OpenCharacter(string fileName)
        {
            if (!IsInitialised)
                return false;

            var file = string.Format("{0}\\characters\\{1}", APIReadWrite.RootPath, fileName);
            if (!file.EndsWith(".json"))
                file += ".json";

            if (!File.Exists(file))
                return false;

            var pcStr = APIReadWrite.GetJsonStringFromFile(file);
            var pcObj = pcStr != null ? JsonSerializer.Deserialize<APIPlayerCharacter>(pcStr) : null;
            if (pcObj == null)
                return false;

            SetCharacter(new PlayerCharacter(pcObj));
            SetActiveFileName(fileName);
            return true;
        }

        //
        //  SaveCharacter
        //
        public static bool SaveCharacter()
        {
            if (!IsInitialised)
                return false;

            try
            {
                Logger.Info("Beginning Save");

                if (!File.Exists(ActiveFile))
                    return false;

                var pc = Player.ToAPIObject();
                var pcStr = JsonSerializer.Serialize(pc);
                if (pcStr == null)
                    return false;

                File.WriteAllText(ActiveFile, pcStr);
                _originalCharacter = new PlayerCharacter(Player);

                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Save failure - exception thrown:\n\t" + ex.ToString());
                return false;
            }
        }

        //
        //  SaveCharacter (Save As)
        //
        public static bool SaveCharacter(string fileName)
        {
            if (!IsInitialised)
                return false;

            try
            {
                Logger.Info("Beginning Save As");

                if (fileName.Length == 0)
                    return false;

                var pc = Player.ToAPIObject();
                var pcStr = JsonSerializer.Serialize(pc);
                if (pcStr == null)
                    return false;

                var file = fileName;
                if (!file.EndsWith(".json"))
                    file += ".json";

                file = string.Format("{0}\\characters\\{1}", APIReadWrite.RootPath, file);
                File.WriteAllText(file, pcStr);
                SetActiveFileName(fileName);
                _originalCharacter = new PlayerCharacter(Player);

                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Save As failure - exception thrown:\n\t" + ex.ToString());
                return false;
            }
        }

        //
        //  SetActiveFileName
        //
        public static void SetActiveFileName(string name)
        {
            if (IsInitialised)
            {
                if (name.Length == 0)
                    return;

                if (!name.EndsWith(".json"))
                    name += ".json";

                ActiveFile = APIReadWrite.RootPath + "\\characters\\" + name;
            }
        }
    }
}
