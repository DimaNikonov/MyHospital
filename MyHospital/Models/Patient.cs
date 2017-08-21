using System;
using System.Collections;
using System.Collections.Generic;

namespace MyHospital.Models
{
    public enum Status
    {
        Arrived,
        Sick,
        Healthy
    }
    public class Patient
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public DateTime DayOfBirth { get; set; }

        public Status Status { get; set; }

        public string TaxCode { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }

        public Patient()
        {
            Doctors = new List<Doctor>();
        }
    }
}