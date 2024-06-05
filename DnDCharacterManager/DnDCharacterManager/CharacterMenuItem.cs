using DND.API;

namespace CharacterManager
{
    internal class CharacterMenuItem : ToolStripMenuItem
    {
        public string FileName { get; private set; }
        public string FilePath { get; private set; }


        internal CharacterMenuItem(string fileName) : base()
        {
            FileName = fileName;
            FilePath = string.Format("{0}\\characters\\{1}.json", APIReadWrite.RootPath, fileName);

            Text = fileName;
        }
    }
}
