using BusinessLayer.Services;
using ConsoleApp_Football_Team_.Controller;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace ConsoleApp_Football_Team_
{
    internal class Program
    {
        //update ishlemir

        static void Main(string[] args)
        {
            ClubController clubController = new ClubController();


        Entername: Extension.Print(ConsoleColor.Red, "Choose players menu or clubs menu: \n" +
            "1. Clubs \n" +
            "2. Players \n" +
            "0. Quit the app\n" +
            "");
            Extension.Print(ConsoleColor.Blue, "Make a choice: ");
            string num = Console.ReadLine();
            int input;
            bool isNum = int.TryParse(num, out input);
            do
            {

                if (isNum && input > 0 && input < 7)
                {


                    switch (input)
                    {
                        case 1:
                            Extension.Print(ConsoleColor.DarkYellow, "1. Create a club\n" +
                                                                     "2. Update a club\n" +
                                                                     "3. Remove a club\n" +
                                                                     "4. Get all the clubs info \n" +
                                                                     "5. Search for a club\n" +
                                                                     "");
                            Extension.Print(ConsoleColor.Magenta, "====================================(End of Menu)==================================== \n" +
                                "");
                            int newthing = Convert.ToInt32(Console.ReadLine());
                            switch (newthing)
                            {
                                case (int)Extension.Menu.CreateAClub:
                                    clubController.CreateClub();
                                    break;
                                case (int)Extension.Menu.UpdateAClub:
                                    clubController.Update();
                                    break;
                                case (int)Extension.Menu.RemoveAClub:
                                    clubController.RemoveAClub();
                                    break;
                                case (int)Extension.Menu.GetAllTheClubInfo:
                                    clubController.GetAllClubs();

                                    break;
                                case (int)Extension.Menu.SearchForAClub:
                                    clubController.SearchClub();

                                    break;
                                case 0:
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 2:
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }

                }
            }
            while (input != 0);
        }
    }
}