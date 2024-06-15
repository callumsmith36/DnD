/*********************************************************
 *  
 *  Name:       Session.cs
 *  
 *  Purpose:    Class for writing to a log file
 *  
 *  Author:     CS
 *  
 *  Created:    20/01/2024
 * 
 *********************************************************/

namespace CharacterManager
{
    internal static class Logger
    {
        public static void Info(string msg)
        {
            File.AppendAllText(Session.LogFile, "\n<INFO>\t" + msg);
        }

        public static void Warning(string msg)
        {
            File.AppendAllText(Session.LogFile, "\n<WARNING>\t" + msg);
        }

        public static void Error(string msg)
        {
            File.AppendAllText(Session.LogFile, "\n<ERROR>\t" + msg);
        }
    }
}
