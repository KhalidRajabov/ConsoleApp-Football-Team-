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

            while (true)
            {
                ClubController clubController = new ClubController();
                Extension.Print(ConsoleColor.DarkYellow, "1. Create a club\n" +
                    "2. Update a club\n" +
                    "3. Remove a club\n" +
                    "4. Get all the clubs info \n" +
                    "5. Search for a club\n" +
                    "");
                Extension.Print(ConsoleColor.Magenta, "====================================(End of Menu)==================================== \n" +
                    "");

                //Entername: Extension.Print(ConsoleColor.Red, "You misspelled something... Try again!");
                Extension.Print(ConsoleColor.Blue, "Make a choice: ");
                string num = Console.ReadLine();
                int input;
                bool isNum = int.TryParse(num, out input);
                if (isNum && input>0&&input<7)
                {
                    switch (input)
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
                }
                else
                {
                    //goto Entername;
                }
            }
        }
    }
}