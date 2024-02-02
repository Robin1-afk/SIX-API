using Microsoft.EntityFrameworkCore;
using SIX.DataENT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIX.DataLogic
{
    
    public class ContextDB: DbContext
    {
        /*
        public ContextDB(DbContextOptions<ContextDB>options):base(options) 
        {

        }*/
        public DbSet<UserMOD> UserMOD { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=DESKTOP-JN0KR68; Database=PruebaSD;Integrated Security=true");
        }
        


    }
}
