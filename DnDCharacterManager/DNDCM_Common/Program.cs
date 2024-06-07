
namespace CharacterManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Session.Initialise();
                if (Session.IsInitialised)
                {
                    // To customize application configuration such as set high DPI settings or default font,
                    // see https://aka.ms/applicationconfiguration.
                    ApplicationConfiguration.Initialize();
                    Application.Run(new MainForm());
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UnauthorizedAccessException encountered during initialisation.\n" +
                        "You may need to tell your antivirus or firewall to allow this app to modify files.",
                        "D&D Character Manager"
                    );
            }
        }
    }
}