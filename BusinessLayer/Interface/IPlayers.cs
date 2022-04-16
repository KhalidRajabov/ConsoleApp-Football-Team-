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
        Players Create(Players players);
        Players Update(int id, Players players);
        Players Delete(int id);
        Players Get(string name);
        Players GetId(int id);
        List<Players> GetAll(string name = null);
    }
}
