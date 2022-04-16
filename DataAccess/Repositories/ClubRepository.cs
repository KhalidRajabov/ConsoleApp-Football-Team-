using DataAccess.Interfaces;
using DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ClubRepository : IRepository<Clubs>
    {
        public bool Create(Clubs entity)
        {
            try
            {
                DataContext.Clubs.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Clubs entity)
        {
            try
            {
                DataContext.Clubs.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Clubs> GetAll(Predicate<Clubs> filter = null)
        {
            try
            {
                
                return filter==null? DataContext.Clubs: 
                    DataContext.Clubs.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Clubs GetOneByName(Predicate<Clubs> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Clubs[0] : 
                    DataContext.Clubs.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Clubs GetId(Predicate<Clubs> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Clubs[0] :
                    DataContext.Clubs.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool Update(Clubs entity)
        {
            try
            {
                Clubs isExist = GetOneByName(s => s.Name == entity.Name);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}