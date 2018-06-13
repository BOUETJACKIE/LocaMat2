using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocaMat.Metier;

namespace LocaMat.DAL
{
    public class BaseDonnees : Dbcontext

    {
        public BaseDonnees( string connectionString="Connexion")
            :base(connectionString)
        {

        }
        public DbSet<Agence> Agences { get; set; } 

        public DbSet<CategorieProduit> CategorieProduits { get; set; }

        public DbSet<Produit> Produits { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<OffreProduit> OffreProduits { get; set; }

        public DbSet<Client> Clients { get; set; }

    }
}
