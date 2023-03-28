﻿namespace Cinema.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }
        public Movie()
        {

        }

    }
}
