using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace L01P022020SS601.Models
{
    public class db_notas_context : DbContext
    {
        public db_notas_context(DbContextOptions options) : base(options)
        {

    }
        public DbSet<facultades> facultades { get; set; }


    }
}