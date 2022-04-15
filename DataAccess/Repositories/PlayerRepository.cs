using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class PlayerRepository : IRepository<Players>
    {
        public bool Create(Players entity)
        {
            try
            {
                DataContext.Players.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Players entity)
        {
            try
            {
                DataContext.Players.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Players> GetAll(Predicate<Players> filter = null)
        {
            try
            {
                return DataContext.Players.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Players GetOneByName(Predicate<Players> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Players[0] : DataContext.Players.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Players entity)
        {
            try
            {
                Players isExist = GetOneByName(s => s.Name == entity.Name);
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
