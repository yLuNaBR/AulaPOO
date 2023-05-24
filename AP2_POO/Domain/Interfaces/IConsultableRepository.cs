using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP2_POO.Domain.Entities;

namespace AP2_POO.Domain.Interfaces
{
    public interface IConsultableRepository
    {
        void MakeAnAppointment(Appointment appointment);
    }
}