using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP2_POO.Domain.Entities;
using AP2_POO.Domain.Interfaces;

namespace AP2_POO.Data.Repositories
{
    public class RegisterRepository
    {
        private List<IPersonRepository> people;
        private List<IConsultableRepository> consultables;

        public RegisterRepository()
        {
            people = new List<IPersonRepository>();
            consultables = new List<IConsultableRepository>();
        }

        public void RegisterDoctor(DataContext context)
        {
            Console.WriteLine("Informe o nome do médico:");
            string name = Console.ReadLine();

            Doctor doctor = new Doctor { Name = name };
            context.Doctors.Add(doctor);
            context.SaveChanges();

            people.Add(doctor);
            consultables.Add(doctor);

            Console.WriteLine("Médico cadastrado com sucesso!");
            Console.WriteLine();
        }

        public void RegisterPacient(DataContext context)
        {
            Console.WriteLine("Informe o nome do paciente:");
            string name = Console.ReadLine();

            Pacient pacient = new Pacient { Name = name };
            context.Pacients.Add(pacient);
            context.SaveChanges();

            people.Add(pacient);

            Console.WriteLine("Paciente cadastrado com sucesso!");
            Console.WriteLine();
        }

        public void MakeAnAppointment(DataContext context)
        {
            Console.WriteLine("Selecione o médico:");

            int index = 1;
            foreach (var consultable in consultables)
            {
                if (consultable is Doctor doctor)
                {
                    Console.WriteLine($"{index}. {doctor.Name}");
                    index++;
                }
            }

            int indexDoctor = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Selecione o paciente:");

            index = 1;
            foreach (var person in people)
            {
                if (person is Pacient pacient)
                {
                    Console.WriteLine($"{index}. {pacient.Name}");
                    index++;
                }
            }

            int indexPacient = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Informe a data e hora da consulta:");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Appointment appointment = new Appointment
            {
                Doctor = consultables[indexDoctor] as Doctor,
                Pacient = people[indexPacient] as Pacient,
                DateTime = dateTime
            };

            consultables[indexDoctor].MakeAnAppointment(appointment);

            context.Appointments.Add(appointment);
            context.SaveChanges();;

            Console.WriteLine("Consulta marcada com sucesso!");
            Console.WriteLine();
        }
    }
}