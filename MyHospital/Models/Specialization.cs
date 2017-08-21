using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

namespace MyHospital.Models
{
    public class Specialization
    {
        public int Id { get; set; }

        public string  Name { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public Specialization()
        {
            Doctors = new List<Doctor>();
        }

    }
}