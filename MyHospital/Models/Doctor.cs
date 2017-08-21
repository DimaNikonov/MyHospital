using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHospital.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SpecializationId  { get; set; }

        public virtual Specialization Specialization  { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public Doctor()
        {
            Patients = new List<Patient>();
        }

    }
}