using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace PrzykladKolokwium2.Models
{
    public class EventDbContext : DbContext
    {
      
     
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artist_Event> Artist_Events { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Event_Organiser> Event_Organisers { get; set; }
        public DbSet<Organiser> Organisers { get; set; }

        public EventDbContext()
        {

        }

        public EventDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Organiser>(opt =>
            {
                opt.HasKey(p => p.IdOrganiser);
                opt.Property(p => p.IdOrganiser)
                   .ValueGeneratedOnAdd();

                opt.Property(p => p.Name)
                   .HasMaxLength(30)
                   .IsRequired();

                opt.HasMany(p => p.EventOrganiser)
                   .WithOne(p => p.Organiser)
                   .HasForeignKey(p => p.IdOrganiser);
            });

            modelBuilder.Entity<Artist_Event>(opt =>
            {
                opt.HasKey(p => new { p.IdEvent, p.IdArtist });

                opt.HasOne(p => p.Artist)
                   .WithMany(p => p.ArtistEvent)
                   .HasForeignKey(p => p.IdArtist);

                opt.HasOne(p => p.Event)
                   .WithMany(p => p.ArtistEvent)
                   .HasForeignKey(p => p.IdEvent);
            });

            modelBuilder.Entity<Event>(opt =>
            {
                opt.HasKey(p => p.IdEvent);
                opt.Property(p => p.IdEvent)
                   .ValueGeneratedOnAdd();

                opt.Property(p => p.Name)
                   .HasMaxLength(100)
                   .IsRequired();

                opt.Property(p => p.StartDate)
                  .IsRequired();

                opt.Property(p => p.EndDate)
                  .HasMaxLength(100)
                  .IsRequired();


            });

            modelBuilder.Entity<Event_Organiser>(opt =>
            {
                opt.HasKey(p => new { p.IdEvent, p.IdOrganiser });


                opt.HasOne(p => p.Event)
                  .WithMany(p => p.EventOrganiser)
                  .HasForeignKey(p => p.IdEvent);

                opt.HasOne(p => p.Organiser)
                   .WithMany(p => p.EventOrganiser)
                   .HasForeignKey(p => p.IdOrganiser);

            });

            modelBuilder.Entity<Artist>(opt =>
            {
                opt.HasKey(p => p.IdArtist);
                opt.Property(p => p.IdArtist)
                   .ValueGeneratedOnAdd();

                opt.Property(p => p.Nickname)
                   .HasMaxLength(30)
                   .IsRequired();
            });


            modelBuilder.Entity<Artist>()
                    .HasData(GetArtistData());

         
            modelBuilder.Entity<Artist_Event>()
                    .HasData(GetArtist_EventData());


            modelBuilder.Entity<Event>()
                    .HasData(GetEventData());


            modelBuilder.Entity<Event_Organiser>()
                    .HasData(GetEvent_OrganiserData());


            modelBuilder.Entity<Organiser>()
                    .HasData(GetOrganiserData());

        }
        private List<Artist> GetArtistData()
        {
            var artists = new List<Artist>
            {
                new Artist { IdArtist = 1, Nickname = "AAA" },
                new Artist { IdArtist = 2, Nickname = "BBB" },
                new Artist { IdArtist = 3, Nickname = "CCC" },
               
            };

            return artists;
        }


        private List<Artist_Event> GetArtist_EventData()
        {
            var Artist_Events = new List<Artist_Event>
            {
                new Artist_Event { IdEvent = 1, IdArtist = 1, PerfomanceDate = Convert.ToDateTime("2004-01-10") },
                new Artist_Event { IdEvent = 2, IdArtist = 2, PerfomanceDate = Convert.ToDateTime("2005-01-10") },
                new Artist_Event { IdEvent = 3, IdArtist = 3, PerfomanceDate = Convert.ToDateTime("2006-01-10") },
              

            };

            return Artist_Events;
        }


        private List<Event> GetEventData()
        {
            var Evenets = new List<Event>
            {
                new Event { IdEvent = 1, Name = "koncert 1", StartDate = Convert.ToDateTime("2004-01-10"), EndDate=Convert.ToDateTime("2004-03-10") },
                new Event { IdEvent = 2,  Name = "koncert 2" , StartDate = Convert.ToDateTime("2005-01-10"),EndDate=Convert.ToDateTime("2005-03-10") },
                new Event { IdEvent = 3,  Name = "koncert 3", StartDate = Convert.ToDateTime("2006-01-10"),EndDate=Convert.ToDateTime("2006-03-10") },


            };

            return Evenets;
        }


        private List<Event_Organiser> GetEvent_OrganiserData()
        {
            var Event_Organisers = new List<Event_Organiser>
            {
                new Event_Organiser { IdEvent = 1, IdOrganiser =1},
                new Event_Organiser { IdEvent = 2, IdOrganiser =2},
                new Event_Organiser { IdEvent = 2, IdOrganiser =3},
              

            };

            return Event_Organisers;
        }



        private List<Organiser> GetOrganiserData()
        {
            var Organisers = new List<Organiser>
            {
                new Organiser { IdOrganiser =1, Name="WAW"},
                new Organiser { IdOrganiser =2, Name="LON"},
                new Organiser { IdOrganiser =3, Name="BRU"},


            };

            return Organisers;
        }


    }



  
}

