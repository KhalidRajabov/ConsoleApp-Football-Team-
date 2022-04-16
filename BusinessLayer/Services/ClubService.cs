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
            Clubs isExist = _clubsRepository.GetId(g => g.Id == id);
            if (isExist == null)
            {
                return null;
            }
            _clubsRepository.Delete(isExist);
            return isExist;
        }
        public Clubs Get(string name)
        {
            return _clubsRepository.GetOneByName(g=>g.Name==name);
        }

        public Clubs Update(int id, string name)
        {
             _clubsRepository.GetId(p => p.Id==id);
            if (id== null)
            {
                return null;
            }
            name = _clubsRepository.GetOneByName()
            return clubs;
        }


        public List<Clubs> GetAll(string name=null)
        {
            return _clubsRepository.GetAll(g=>g.Name==name);
        }
        public List<Clubs> GetAllClubs()
        {
            return _clubsRepository.GetAll();
        }



        public Clubs GetId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
