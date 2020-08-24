using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ISAD251Appointments.Models;


namespace ISAD251Appointments.Data
{
    public class MvcAppointmentContext : DbContext
    {
        public MvcAppointmentContext(DbContextOptions<MvcAppointmentContext> options)
            : base(options)
        {
        }

        public DbSet<Appointments> Appointments { get; set; }
    
    }
}
