using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IClubs
    {
        Clubs Create (Clubs club);
        Clubs Update (int id, Clubs clubs);
        Clubs Delete (int id);
        Clubs Get (string name);
        Clubs GetId (int id);
        List<Clubs> GetAll(string name = null);
    }
}
