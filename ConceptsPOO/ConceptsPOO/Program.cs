﻿// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using ConceptsPOO;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("POO Concepts");
Console.WriteLine("===============");
            SalaryEmployee employee1 = new SalaryEmployee()
{
                Id = 1010,
                FirstName = "Sandra",
                LastName = "Morales",
                BirthDate = new DateTime(1990, 5, 23),
                HiringDate = new DateTime(2022, 1, 15),
                IsActive = true,
        Salary = 1815453.45M,
            };
            Console.WriteLine(employee1);

       Employee employee2 = new CommissionEmploye()
       {
           Id = 1010,
           FirstName = "Sandra",
           LastName = "Morales",
           BirthDate = new DateTime(1990, 5, 23),
           HiringDate = new DateTime(2022, 1, 15),
           IsActive = true,
       };
        }
}
}
