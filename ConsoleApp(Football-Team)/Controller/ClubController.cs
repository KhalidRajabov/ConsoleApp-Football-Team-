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
    public class ClubController
    {
        private ClubService clubService;
        public ClubController()
        {
            clubService = new ClubService();
        }
        public void CreateClub()
        {
        Entername2:
            Extension.Print(ConsoleColor.DarkBlue, $"Enter your new club name: ");

            string name = Console.ReadLine();
            Extension.Print(ConsoleColor.DarkBlue, $"Enter the number of players in your club: ");
            string clubSize = Console.ReadLine();
            int size;
            bool isSize = int.TryParse(clubSize, out size);
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
        }
        public void GetAllClubs()
        {
            Extension.Print(ConsoleColor.Blue, "1. Get all clubs\n" +
                "2. Search by names: ");
            int ccll = Convert.ToInt32(Console.ReadLine());
            

            switch (ccll)
            {
                case 1:
                    Extension.Print(ConsoleColor.Cyan, "Current existing teams: \n" +
                        "");
                    foreach (var item in clubService.GetAllClubs())
                    {
                        Extension.Print(ConsoleColor.Magenta, $"Club name: {item.Name} \n" +
                            $"Players: {item.MaxMemberSize} \n" +
                            $"Club Id: {item.Id} \n" +
                            $"");
                    }
                    break;
                    case 2:
                    Extension.Print(ConsoleColor.Yellow, "Write a name");
                    string info = Console.ReadLine();
                    foreach (var item in clubService.GetAll(info))
                    {
                        Extension.Print(ConsoleColor.Magenta, $"club    {item.Name}    exists.");
                    }
                    break;
                default:
                    break;
            }
        }
        public void RemoveAClub()
        {
            Console.WriteLine("Enter id of club to remove: ");
            int id = int.Parse(Console.ReadLine());
            
                Extension.Print(ConsoleColor.Magenta, $"CLUB {clubService.Delete(id).Name} DELETED \n" +
                    $"Search to be sure it is deleted\n" +
                    $"");
            
        }
        public void SearchClub()
        {
            Extension.Print(ConsoleColor.Blue, "Enter a club name: ");
            string name2 = Console.ReadLine();
            Clubs list = clubService.Get(name2);
            Extension.Print(ConsoleColor.Magenta, $"Found! {list.Name} exists");
        }
        public void Update()
        {

            Extension.Print(ConsoleColor.Cyan, "Teams available to be updated: ");
            foreach (var item in clubService.GetAllClubs())
            {
                Extension.Print(ConsoleColor.Magenta, $"Club name: {item.Name} \n" +
                    $"Club Id: {item.Id} \n" +
                    $"");
            }
            Extension.Print(ConsoleColor.Cyan, "To update a club, write its Id number: ");

            int id = Convert.ToInt32(Console.ReadLine());
            
            

        }
    }
}
