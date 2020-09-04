using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Display(Name ="Nome")]
        [Required(ErrorMessage ="{0} required ")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} required ")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]

        public string Email { get; set; }
        [Required(ErrorMessage = "{0} required ")]
        [Range(100.0, 500000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        [Display(Name = "Salario base")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; }
        [Required(ErrorMessage = "{0} required ")]
        [Display(Name = "Data de Aniversario")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyy}")]
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }
        [Display(Name = "Departamento")]

        public int  DepartmentId  { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary,  Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
