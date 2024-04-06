using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using L01P022020SS601.Models;
namespace L01P022020SS601.Models
{
    public class db_notas_context : DbContext
    {
        public db_notas_context(DbContextOptions options) : base(options)
        {

    }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<L01P022020SS601.Models.alumnos> alumnos { get; set; } = default!;
        public DbSet<L01P022020SS601.Models.departamentos> departamentos { get; set; } = default!;


    }
}