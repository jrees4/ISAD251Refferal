using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ISAD251Appointments.Models
{
    public class Appointments
    {
        [Key] public int AppointmentID { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Display(Name = "Appointment")]
        [StringLength(100, MinimumLength = 1)]
        [Required]
        public string AppointmentName { get; set; }

        [Display(Name = "Description")]
        [StringLength(255, MinimumLength = 1)]
        public string AppointmentDescription { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Display(Name = "Family Member")]
        [StringLength(255, MinimumLength = 1)]
        [Required]
        public string AppointmentTarget { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentTime { get; set; }


        [Display(Name = "Note")]
        [StringLength(400, MinimumLength = 0)]
        public string AppointmentNote { get; set; }


        [Display(Name = "Completed")]
        public bool AppointmentIsComplete { get; set; }

    }
    }

