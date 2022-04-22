using ConsoleApp_Football_Team_.Controller;
using System;
using Utilities.Helper;
namespace ConsoleApp_Football_Team_
{
    internal class Program
    {
        //must do
        static void Main(string[] args)
        {

            ClubController clubController = new ClubController();
            PlayerController playerController = new PlayerController();


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

                    try
                    {
                        switch (input)
                        {

                            case 1:
                                Extension.Print(ConsoleColor.Yellow, "1. Create a club\n" +
                                                                         "2. Update a club\n" +
                                                                         "3. Remove a club\n" +
                                                                         "4. Get all the clubs info \n" +
                                                                         "5. Search for a club\n" +
                                                                         "0. Main menu \n" +
                                                                         "");
                                Extension.Print(ConsoleColor.Magenta, "=====================================(End of the Club Menu)===================================== \n" +
                                    "");
                                int ofclub = Convert.ToInt32(Console.ReadLine());


                                switch (ofclub)
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
                                        goto Entername;
                                }
                                break;
                            case 2:
                                Extension.Print(ConsoleColor.Green, "1. Create a player\n" +
                                                                        "2. Update a player\n" +
                                                                        "3. Remove a player\n" +
                                                                        "4. Get all the players info \n" +
                                                                        "5. Search for a player\n" +
                                                                        "0.Main menu \n" +
                                                                        "");
                                Extension.Print(ConsoleColor.Magenta, "====================================(End of the Player Menu)==================================== \n" +
                                    "");
                                try
                                {
                                    int ofplayers = Convert.ToInt32(Console.ReadLine());
                                    switch (ofplayers)
                                    {
                                        case (int)Extension.PlayerMenu.CreateAPlayer:
                                            playerController.Create();
                                            break;
                                        case (int)Extension.PlayerMenu.UpdateAPlayer:
                                            playerController.UpdatePlayers();
                                            break;
                                        case (int)Extension.PlayerMenu.RemoveAPlayer:
                                            playerController.RemoveAPlayer();
                                            break;
                                        case (int)Extension.PlayerMenu.GetAllThePlayersInfo:
                                            playerController.GetAllPlayers();

                                            break;
                                        case (int)Extension.PlayerMenu.SearchForAPlayer:
                                            playerController.SearchPlayers();

                                            break;
                                        case 0:
                                            goto Entername;
                                    }
                                }
                                catch (Exception)
                                {

                                    Extension.Error();
                                }

                                break;
                            case 0:
                                goto Entername;
                        }
                    }
                    catch (Exception)
                    {

                        Extension.Error();
                    }

                }
            }
            while (input != 0);
        }
    }
}