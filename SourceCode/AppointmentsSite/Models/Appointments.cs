using System;
using System.Collections.Generic;

namespace AppointmentsSite.Models
{
    public partial class Appointments
    {
        public int AppointmentId { get; set; }
        public string AppointmentName { get; set; }
        public string AppointmentDescription { get; set; }
        public string AppointmentTarget { get; set; }
        public DateTime? AppointmentTime { get; set; }
    }
}
