using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }  // Cambiado de Date a DateTime

        public DateTime HiringDate { get; set; }  // Cambiado de Date a DateTime

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birth: {BirthDate.ToShortDateString()}, " +
                $"Hiring: {HiringDate.ToShortDateString()}, " +
                $"Is Active: {IsActive}";
        }
    }
}
