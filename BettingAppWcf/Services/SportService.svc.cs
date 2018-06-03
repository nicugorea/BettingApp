using System;
using System.Collections.Generic;
using System.Linq;
using BettingAppWcf.Models;

namespace BettingAppWcf.Services
{
    public class SportService : ISportService
    {
        public bool AddSport(Sport sport)
        {

            using (var database = new BettingAppDBEntities())
            {
                if (ExistSportByName(sport.Name))
                    return false;

                database.Sports.Add(sport);
                database.SaveChanges();

                return true;

            }

        }

        public bool ExistSportByName(string name)
        {
            using (var database = new BettingAppDBEntities())
            {
                var sport = GetSportByName(name);
                if (sport == null) return false;
                return true;
            }
        }

        public Sport GetSportById(int id)
        {
            using (var database = new BettingAppDBEntities())
            {
                return database.Sports.Find(id);
            }
        }

        public Sport GetSportByName(string name)
        {
            using (var database = new BettingAppDBEntities())
            {
                return database.Sports.FirstOrDefault(s => s.Name == name);
            }
        }

        public List<Sport> GetSportsList()
        {
            using (var database = new BettingAppDBEntities())
            {
                return database.Sports.ToList();
            }
        }

        public bool RemoveSport(int id)
        {
            using (var database = new BettingAppDBEntities())
            {
                var sport = database.Sports.Find(id);
                if (sport == null) return false;
                database.Sports.Remove(sport);
                database.SaveChanges();
                return true;
            }
        }

        public bool UpdateSport(Sport sport)
        {
            using (var database = new BettingAppDBEntities())
            {
                var existingSport = database.Sports.Find((GetSportByName(sport.Name).SportID));
                if (existingSport == null) return false;

                existingSport.Description = sport.Description;
                existingSport.Value = sport.Value;
                existingSport.EndTime = sport.EndTime;

                database.SaveChanges();
                return true;
            }
        }
    }
}
