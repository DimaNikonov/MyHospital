using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyHospital.Models
{
    public class MyHospitalContext:DbContext
    {
        public MyHospitalContext()
            :base("HospitalDb")
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Specialization> Specializaitons { get; set; }
    }
}