using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP2_POO.Domain.Interfaces;

namespace AP2_POO.Domain.Entities
{
    public class Doctor : IPersonRepository, IConsultableRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void MakeAnAppointment(Appointment appointment)
        {
            Console.WriteLine($"Consulta marcada com o médico {Name}");
            Console.WriteLine($"Paciente: {appointment.Pacient.Name}");
            Console.WriteLine($"Data e Hora: {appointment.DateTime}");
            Console.WriteLine();
        }
        
    }
}