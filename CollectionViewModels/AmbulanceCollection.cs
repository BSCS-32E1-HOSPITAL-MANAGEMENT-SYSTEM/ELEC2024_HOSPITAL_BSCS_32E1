using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.Models;

namespace BSCS_32E1_HOSPITAL_MANAGEMENT_SYSTEM.CollectionViewModels
{
    public class AmbulanceCollection
    {
        public Ambulance Ambulance { get; set; }
        public List<AmbulanceDriver> AmbulanceDrivers { get; set; }

        public string Title
        {
            get
            {
                if (Ambulance != null && Ambulance.Id != 0)
                {
                    return "Edit Ambulance";
                }

                return "Add Ambulance";
            }
        }
    }
}