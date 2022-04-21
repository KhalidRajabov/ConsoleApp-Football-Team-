using BusinessLayer.Interface;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;

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
        public Clubs Get(int id)
        {
            return _clubsRepository.GetOneByName(g => g.Id== id);
        }

        public Clubs Update(string name, Clubs clubs)
        {
            clubs = _clubsRepository.GetOneByName(p => p.Id == clubs.Id);
            if (clubs == null)
            {
                return null;
            }
           clubs.Name = name;
           _clubsRepository.Update(clubs);
            return clubs;
        }

        public List<Clubs> GetAll(string name = null)
        {
            return _clubsRepository.GetAll(g => g.Name == name);
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
