using System;

namespace BettingAppWeb.Models
{
    public class SportViewModel
    {
        public int SportId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public DateTime EndTime { get; set; }
    }
}