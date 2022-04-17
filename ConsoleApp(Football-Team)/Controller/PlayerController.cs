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
        public void GetAllPlayers()
        {
            Extension.Print(ConsoleColor.Blue, "1. Get all players\n" +
                "2. Search by names: ");
            int ccll = Convert.ToInt32(Console.ReadLine());


            switch (ccll)
            {
                case 1:
                    Extension.Print(ConsoleColor.Cyan, "Current existing players: \n" +
                        "");
                    foreach (var item in playerService.GetAllPlayers())
                    {
                        Extension.Print(ConsoleColor.Magenta, $"Player name: {item.Name} \n" +
                            $"Player number: {item.ShirtNumber} \n" +
                            $"Player Id: {item.Id} \n" +
                            $"");
                    }
                    break;
                case 2:
                    Extension.Print(ConsoleColor.Yellow, "Write a name");
                    string info = Console.ReadLine();
                    foreach (var thing in playerService.GetAllPlayers())
                    {
                        Extension.Print(ConsoleColor.Magenta, $"Player    {thing.Name}    available.");
                    }
                    break;
                default:
                    break;
            }
        }
        public void RemoveAPlayer()
        {
            Console.WriteLine("Enter id of player to remove: ");
            int id = int.Parse(Console.ReadLine());

            Extension.Print(ConsoleColor.Magenta, $"PLAYER {playerService.DeletePlayers(id).Name} DELETED \n" +
                $"Search to be sure it is deleted\n" +
                $"");
        }
        public void SearchPlayer()
        {
            Extension.Print(ConsoleColor.Blue, "Enter a player name: ");
            string name2 = Console.ReadLine();
            Players list = playerService.Get(name2);
            Extension.Print(ConsoleColor.Magenta, $"Found! {list.Name} exists");
        }
        public void UpdatePlayers()
        {

            Extension.Print(ConsoleColor.Cyan, "Players available to be updated: ");
            foreach (var item in playerService.GetAllPlayers())
            {
                Extension.Print(ConsoleColor.Magenta, $"\n" +
                    $"Player name: {item.Name} \n" +
                    $"Player Id: {item.Id} \n" +
                    $"\n");
            }
            Extension.Print(ConsoleColor.Cyan, "To update a player, write his name: ");

            string oldName = Console.ReadLine();

            Extension.Print(ConsoleColor.Cyan, "Write a new name to the player: ");
            string newName = Console.ReadLine();
            Players updateplayer = playerService.Get(oldName);
            playerService.UpdatePlayers(newName, updateplayer);
            Extension.Print(ConsoleColor.Yellow, $"New name for the taem has been updated:    {updateplayer.Name}  ");



        }
    }

}

