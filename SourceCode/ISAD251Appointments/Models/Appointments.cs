using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISAD251Appointments.Models
{
    public class Appointments
    {
        [Key] public int AppointmentID { get; set; }

        [Display(Name = "Appointment")]
        public string AppointmentName { get; set; }

        [Display(Name = "Description")]
        public string AppointmentDescription { get; set; }

        [Display(Name = "Family Member")]
        public string AppointmentTarget { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentTime { get; set; }

        [Display(Name = "Note")]
        public string AppointmentNote { get; set; }

        [Display(Name = "Completed")]
        public bool AppointmentIsComplete { get; set; }
        
   
    }
}
