using eMovieTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMovieTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();


                //Actors_Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {

                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 9
                        },

                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 9
                        },

                        //new Actor_Movie()
                        //{
                        //    ActorId = 5,
                        //    MovieId = 3
                        //},

                        //new Actor_Movie()
                        //{
                        //    ActorId = 2,
                        //    MovieId = 4
                        //},

                        //new Actor_Movie()
                        //{
                        //    ActorId = 3,
                        //    MovieId = 6
                        //},

                        //new Actor_Movie()
                        //{
                        //    ActorId = 4,
                        //    MovieId = 6
                        //},

                        //new Actor_Movie()
                        //{
                        //    ActorId = 5,
                        //    MovieId = 6
                        //},

                    });
                    context.SaveChanges();
                }
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description  = "This is the description of the first cinema"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description  = "This is the description of the second cinema"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description  = "This is the description of the third cinema"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description  = "This is the description of the fourth cinema"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description  = "This is the description of the fifth cinema"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first Actor",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second Actor",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third Actor",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the fourth Actor",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth Actor",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-1.jpeg"
                        },

                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-2.jpeg"
                        },

                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-3.jpeg"
                        },

                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-4.jpeg"
                        },

                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-5.jpeg"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Ghost",
                            Description="This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL  = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 9,
                            MovieCategory = MovieCategory.Horror
                        },

                        new Movie()
                        {
                            Name = "Race",
                            Description="This is the Race movie description",
                            Price = 39.50,
                            ImageURL  = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 7,
                            MovieCategory = MovieCategory.Documentary
                        },

                        new Movie()
                        {
                            Name = "Scoob",
                            Description="This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL  = "http://dotnethow.net/images/movie/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 8,
                            MovieCategory = MovieCategory.Action
                        },

                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description="",                            
                            Price = 39.50,
                            ImageURL  = "http://dotnethow.net/images/movie/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate =   DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 10,
                            MovieCategory = MovieCategory.Drama
                            //Bio = "This is the Bio of the producer",
                        },

                        
                    });
                    context.SaveChanges();
                }

                //


               
            }

        }
    }
}
