﻿namespace MovieDatabase.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public User User { get; set; }  

        public int IdMovie { get; set; }    

        public Movie Movie { get; set; }
    }
}
