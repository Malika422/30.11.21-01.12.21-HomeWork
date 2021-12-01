using FlowerExpertsNew.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerExpertsNew.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<FlowerExpertsImage> FlowerExpertsImages { get; set; }
        public DbSet<FlowerExpertsTitle> FlowerExpertsTitles { get; set; }
        public DbSet<InformationList> InformationList { get; set; }
        public DbSet<Valentine> Valentine { get; set; }
        public DbSet<TransitionVideo> TransitionVideo { get; set; }
    }
}
