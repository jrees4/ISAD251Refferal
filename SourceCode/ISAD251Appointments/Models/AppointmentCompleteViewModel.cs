using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ISAD251Appointments.Models
{
    public class AppointmentCompleteViewModel
    {
        public List<Appointments> Appointments{ get; set; }
        public SelectList AppointmentIsComplete { get; set; }
        public bool Selected { get; set; }
    }
}
