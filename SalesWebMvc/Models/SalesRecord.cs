using System;
using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required ")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2")]
        [Required(ErrorMessage = "{0} required ")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "{0} required ")]
        public  SaleStatus Status { get; set; }
        [Required(ErrorMessage = "{0} required ")]
        public  Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
