using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataAccessLibrary.Context
{
    public class AquariumDataContext : DbContext
    {
        public AquariumDataContext(DbContextOptions<AquariumDataContext> options) : base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Aquariums> Aquariums { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Guests> Guests { get; set; }
        public DbSet<GuestsTickets> GuestsTickets { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Tanks> Tanks { get; set; }
        public DbSet<TankMovements> TanksMovements { get; set; }
        public DbSet<Vets> Vets { get; set; }
        public DbSet<Workers> Workers { get; set; }
        public DbSet<WorkersTanks> WorkersTanks { get; set; }
    }
}
