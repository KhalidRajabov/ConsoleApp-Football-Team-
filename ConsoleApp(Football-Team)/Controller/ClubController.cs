using BusinessLayer.Services;
using Entities.Models;
using System;
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
            try
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
                        Players = size
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
            catch (Exception)
            {

                Extension.Error();
            }
        }
        public void GetAllClubs()
        {
            foreach (var item in clubService.GetAllClubs())
            {
                Extension.Print(ConsoleColor.Magenta, $"Club name: {item.Name} \n" +
                    $"Players: {item.Players} \n" +
                    $"Club Id: {item.Id} \n" +
                    $"");
            }

        }
        public void RemoveAClub()
        {
            try
            {
                Console.WriteLine("Enter id of club to remove: ");
                int id = int.Parse(Console.ReadLine());

                Extension.Print(ConsoleColor.Magenta, $"CLUB {clubService.Delete(id).Name} DELETED \n" +
                    $"Search to be sure it is deleted\n" +
                    $"");
            }
            catch (Exception)
            {

                Extension.Error();


            }
        }
        public void SearchClub()
        {
            try
            {
                Extension.Print(ConsoleColor.Blue, "Enter id for a club : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Clubs list = clubService.Get(id);
                Extension.Print(ConsoleColor.Magenta, $"Found! {list.Name} exists \n" +
                    $"");
            }
            catch (Exception)
            {
                Extension.Error();
            }


        }
        public void Update()
        {

            try
            {
                Extension.Print(ConsoleColor.Cyan, "To update a club, id: ");

                int oldName = Convert.ToInt32(Console.ReadLine());

                Extension.Print(ConsoleColor.Cyan, "Write new name to the club: ");
                string newName = Console.ReadLine();
                Clubs updateclub = clubService.Get(oldName);
                clubService.Update(newName, updateclub);
                Extension.Print(ConsoleColor.Yellow, $"New name for the taem has been updated:    {newName}  \n" +
                    $"");
            }
            catch (Exception)
            {
                Extension.Error();
            }




        }
    }
}
