using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.Models;

namespace BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.CollectionViewModels
{
    public class AppointmentCollection
    {
        public Appointment Appointment { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}