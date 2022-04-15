using BusinessLayer.Interface;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ClubService : IClubs
    {
        public static int Count { get; set; }
        private ClubRepository _clubsRepository;
        public ClubService()
        {
            _clubsRepository = new ClubRepository();
        }
        public Clubs Create(Clubs club)
        {
            club.Id = Count;
            _clubsRepository.Create(club);
            Count++;
            return club;
        }

        public Clubs Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Clubs Get(string name)
        {
            return _clubsRepository.GetOneByName();
        }

        public Clubs Update(int id, Clubs clubs)
        {
            throw new NotImplementedException();
        }

        public List<Clubs> GetAll()
        {
            return _clubsRepository.GetAll();
        }
    }
}
