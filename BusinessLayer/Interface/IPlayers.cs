using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IPlayers
    {
        Players CreatePlayers(Players players);
        Players UpdatePlayers(string name, Players players);
        Players DeletePlayers(int id);
        Players Get(int id);
        Players GetId(int id);
        List<Players> GetAll(string name = null);
    }
}
