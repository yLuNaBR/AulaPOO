using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP2_POO.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public Pacient Pacient { get; set; }
        public DateTime DateTime { get; set; }

    }
}