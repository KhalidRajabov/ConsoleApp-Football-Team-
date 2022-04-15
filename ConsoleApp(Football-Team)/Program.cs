using BusinessLayer.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using Utilities.Helper;

namespace ConsoleApp_Football_Team_
{
    internal class Program
    {
        /*private static ClubService _clubService;
        public Program()
        {
            _clubService = new ClubService();

        }*/
        static void Main(string[] args)
        {

            while (true)
            {
                ClubService clubService = new ClubService();
                Console.WriteLine("\n");
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
                        case 1:
                            Entername2:
                            Extension.Print(ConsoleColor.DarkBlue, $"Enter your new club name: ");

                            string name = Console.ReadLine();
                            Extension.Print(ConsoleColor.DarkBlue, $"Enter the number of players in your club: ");
                            string clubSize = Console.ReadLine();
                            int size;
                            bool isSize = int.TryParse(num, out size);
                            if (isSize)
                            {
                                Clubs club = new Clubs
                                {
                                    Name = name,
                                    MaxMemberSize = size
                                };
                                clubService.Create(club);
                                Extension.Print(ConsoleColor.Yellow, $"Club {club.Name} created! \n" +
                                    $"");
                            }
                            else
                            {
                                Extension.Print(ConsoleColor.Red, "You misspelled something... Try again!");
                                goto Entername2;
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Extension.Print(ConsoleColor.Blue, "Enter a club name: ");
                            string name2 = Console.ReadLine();
                                Clubs list =  clubService.Get(name2);
                                Extension.Print(ConsoleColor.Magenta, $"{list.Name}");
                            
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
