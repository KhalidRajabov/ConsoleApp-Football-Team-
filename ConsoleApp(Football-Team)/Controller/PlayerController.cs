using BusinessLayer.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace ConsoleApp_Football_Team_.Controller
{
    public class PlayerController 
    {
        private PlayerServices playerService;
        public PlayerController()
        {
            playerService = new PlayerServices();
        }


        public void Create()
        {
            try
            {
                Extension.Print(ConsoleColor.DarkGreen, $"Enter player name: ");

                string name = Console.ReadLine();

                Extension.Print(ConsoleColor.DarkGreen, "Enter player shirt number");
                int playernumber = Convert.ToInt32(Console.ReadLine());
                Players player = new Players
                {
                    Name = name,
                    ShirtNumber = playernumber,
                };
                playerService.CreatePlayers(player);
                Extension.Print(ConsoleColor.Yellow, $"Player {player.Name} with the number {playernumber} created! \n" +
                    $"");
            }
            catch (Exception)
            {

                Extension.Error();
            }
        }


        public void GetAllPlayers()
        {

           
                    foreach (var item in playerService.GetAllPlayers())
                    {
                        Extension.Print(ConsoleColor.Magenta, $"Player name: {item.Name} \n" +
                            $"Player number: {item.ShirtNumber} \n" +
                            $"Player Id: {item.Id} \n" +
                            $"");
                    }
                
        }
        public void RemoveAPlayer()
        {
            try
            {
                Console.WriteLine("Enter id of club to remove: ");
                int id = int.Parse(Console.ReadLine());

                Extension.Print(ConsoleColor.Magenta, $"CLUB {playerService.DeletePlayers(id).Name} DELETED \n" +
                    $"Search to be sure it is deleted\n" +
                    $"");
            }
            catch (Exception)
            {

                Extension.Error();


            }
        }
        public void UpdatePlayers()
        {


         

            try
            {
                Extension.Print(ConsoleColor.Cyan, "To update a player, id: ");

                int oldName = Convert.ToInt32(Console.ReadLine());

                Extension.Print(ConsoleColor.Cyan, "Write new name to the player: ");
                string newName = Console.ReadLine();
                Players updateclub = playerService.Get(oldName);
                playerService.UpdatePlayers(newName, updateclub);
                Extension.Print(ConsoleColor.Yellow, $"New name for the player has been updated:    {newName}  \n" +
                    $"");
            }
            catch (Exception)
            {

                Extension.Error();
            }

        }
        public void SearchPlayers()
        {
            try
            {
                Extension.Print(ConsoleColor.Blue, "Enter id for a players: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Players list = playerService.Get(id);
                Extension.Print(ConsoleColor.Magenta, $"Found! {list.Name} exists \n" +
                    $"");
            }
            catch (Exception)
            {


                Extension.Error();
            }
        }
    }

}

