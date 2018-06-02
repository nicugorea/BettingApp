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
                var existingSport = database.Sports.FirstOrDefault(s => s.Name == sport.Name);
                if (existingSport != null) return false;

                database.Sports.Add(sport);
                database.SaveChanges();

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
                var existingSport = database.Sports.Find(sport.SportID);
                if (existingSport == null) return false;
                existingSport = sport;
                database.SaveChanges();
                return true;
            }
        }
    }
}
