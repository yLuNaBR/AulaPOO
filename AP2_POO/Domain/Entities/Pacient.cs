using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP2_POO.Domain.Interfaces;

namespace AP2_POO.Domain.Entities
{
    public class Pacient : IPersonRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}