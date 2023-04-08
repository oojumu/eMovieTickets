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
                            Bio = "Actor 1",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "Actor 2",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "Actor 3",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "Actor 4",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },

                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "Actor 5",
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
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-1.jpeg"
                        },

                        new Movie()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-2.jpeg"
                        },

                        new Movie()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-3.jpeg"
                        },

                        new Movie()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-4.jpeg"
                        },

                        new Movie()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the producer",
                            ProfilePictureURL  = "http://dotnethow.net/images/actors/producer-5.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                
                //
                //Actors_Movies

            }

        }
    }
}
