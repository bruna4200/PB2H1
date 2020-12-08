using Prova2H1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova2H1.Context
{
    public class ParticipanteContext : DbContext
    {
        public ParticipanteContext()
        {

        }

        public ParticipanteContext(DbContextOptions<ParticipanteContext> options) : base(options)
        {
        }

        public virtual DbSet<Participante> participante { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                        .AddJsonFile("appsettings.json")
                                        .Build();
                object p = optionsBuilder.UseSqlServer(configuration.GetConnectionString("DataBase"));
            }
        }
    }
}
