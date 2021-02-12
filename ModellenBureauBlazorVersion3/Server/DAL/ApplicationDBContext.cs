using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        { 
        
        }

        public DbSet<AdminModel> adminModels { get; set; }
        public DbSet<ClientModel> clientModels { get; set; }
        public DbSet<EventModel> eventModels { get; set; }
        public DbSet<FemaleModelModel> femaleModelModels { get; set; }
        public DbSet<MaleModeModel> maleModeModels { get; set; }

    }
}
