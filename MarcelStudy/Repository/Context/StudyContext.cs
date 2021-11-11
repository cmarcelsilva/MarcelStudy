using MarcelStudy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Repository.Context
{
    public class StudyContext : DbContext
    {
        

        public StudyContext()
        {
        }

        public StudyContext(DbContextOptions<StudyContext> options)
           : base(options)
        {
        }
       

        public DbSet<Contato> Contato { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        
    }
}
