﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public MovieCategory MovieCategory { get; set; }

        // Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }

        public int CinemaId { get; set; }
        
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        public int ProducerId { get; set; }
        public Producer Producer { get; set; }





    }
}
