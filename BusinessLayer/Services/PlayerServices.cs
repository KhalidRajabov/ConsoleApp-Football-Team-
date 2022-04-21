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
    public class PlayerServices:IPlayers
    {
        public static int Count { get; set; }
        private PlayerRepository _playersRepository;
        public PlayerServices()
        {
            _playersRepository = new PlayerRepository();
        }
        public Players CreatePlayers(Players player)
        {
            player.Id = Count;
            _playersRepository.Create(player);
            Count++;
            return player;
        }

        public Players DeletePlayers(int id)
        {
            Players isExist = _playersRepository.GetId(g => g.Id == id);
            if (isExist == null)
            {
                return null;
            }
            _playersRepository.Delete(isExist);
            return isExist;
        }
        public Players Get(string name)
        {
            return _playersRepository.GetOneByName(g => g.Name == name);
        }

        public Players UpdatePlayers(string name, Players players)
        {
            players = _playersRepository.GetOneByName(p => p.Id == players.Id);
            if (players == null)
            {
                return null;
            }
            players.Name = name;
            _playersRepository.Update(players);
            return players;
        }

        public List<Players> GetAll(string name = null)
        {
            return _playersRepository.GetAll(g => g.Name == name);
        }
        public List<Players> GetAllPlayers()
        {
            return _playersRepository.GetAll();
        }
        



        public Players GetId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
