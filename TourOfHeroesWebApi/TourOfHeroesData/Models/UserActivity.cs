﻿namespace TourOfHeroesData.Models
{
    public class UserActivity
    {
        public int Id { get; set; }

        public string Action { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}