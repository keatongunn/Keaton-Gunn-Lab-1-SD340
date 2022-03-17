#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Keaton_Gunn_Lab_1_SD340.Models;

namespace Keaton_Gunn_Lab_1_SD340.Data
{
    public class Keaton_Gunn_Lab_1_SD340Context : DbContext
    {
        public Keaton_Gunn_Lab_1_SD340Context (DbContextOptions<Keaton_Gunn_Lab_1_SD340Context> options)
            : base(options)
        {
        }

        public DbSet<Keaton_Gunn_Lab_1_SD340.Models.Client> Client { get; set; }
    }
}
