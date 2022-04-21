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
                Extension.Print(ConsoleColor.Red, "You misspelled something... Try again! \n" +
                    "");
                goto Entername2;
            }
        }
        public void GetAllClubs()
        {

          
                    Extension.Print(ConsoleColor.Cyan, "Current existing teams: \n" +
                        "");
                    foreach (var item in clubService.GetAllClubs())
                    {
                        Extension.Print(ConsoleColor.Magenta, $"Club name: {item.Name} \n" +
                            $"Players: {item.MaxMemberSize} \n" +
                            $"Club Id: {item.Id} \n" +
                            $"");
                    }
                
        }
        public void RemoveAClub()
        {

            Extension.Print(ConsoleColor.Cyan, "Current existing teams: \n" +
                "");
            foreach (var item in clubService.GetAllClubs())
            {
                Extension.Print(ConsoleColor.Magenta, $"Club name: {item.Name} \n" +
                    $"Players: {item.MaxMemberSize} \n" +
                    $"Club Id: {item.Id} \n" +
                    $"");
            }

            Console.WriteLine("Enter id of club to remove: ");
            int id = int.Parse(Console.ReadLine());
            
                Extension.Print(ConsoleColor.Magenta, $"CLUB {clubService.Delete(id).Name} DELETED \n" +
                    $"Search to be sure it is deleted\n" +
                    $"");
            
        }
        public void SearchClub()
        {
            Extension.Print(ConsoleColor.Blue, "Enter id for a club : ");
            int id=Convert.ToInt32(Console.ReadLine());
            Clubs list = clubService.Get(id);
            Extension.Print(ConsoleColor.Magenta, $"Found! {list.Name} exists \n" +
                $"");
        }
        public void Update()
        {

            Extension.Print(ConsoleColor.Cyan, "Teams available to be updated: \n" +
                "");
            foreach (var item in clubService.GetAllClubs())
            {
                Extension.Print(ConsoleColor.Magenta, $"Club name: \n" +
                    $"{item.Name} \n" +
                    $"Club Id: {item.Id} \n" +
                    $"\n");
            }
            Extension.Print(ConsoleColor.Cyan, "To update a club, id: ");

            int oldName =Convert.ToInt32(Console.ReadLine());

            Extension.Print(ConsoleColor.Cyan, "Write new name to the club: ");
            string newName = Console.ReadLine();
            Clubs updateclub = clubService.Get(oldName);
            clubService.Update(newName, updateclub);
            Extension.Print(ConsoleColor.Yellow, $"New name for the taem has been updated:    {newName}  \n" +
                $"");



        }
    }
}
