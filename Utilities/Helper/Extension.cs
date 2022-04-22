using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Helper
{
    public static class Extension
    {
        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
        public static void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Oops! Something went wrong...");
            Console.ResetColor();
        }


        public enum Menu
        {
            CreateAClub=1,
            UpdateAClub,
            RemoveAClub,
            GetAllTheClubInfo,
            SearchForAClub
        }
        public enum PlayerMenu
        {
            CreateAPlayer = 1,
            UpdateAPlayer,
            RemoveAPlayer,
            GetAllThePlayersInfo,
            SearchForAPlayer
        }

    }
}
