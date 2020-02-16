using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PracticeApi.Crosscutting;

namespace PracticeApi.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public int CardNumber { get; set; }
        [Required]
        public DateTime TimeOfTransaction { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public Currency Currency { get; set; }

        //on delete of transaction don't delete customer or bank
       // [ForeignKey("Customer")]
        //public int CustomerId { get; set; }
        [Required]
        public Customer Customer { get; set; }

        //[ForeignKey("Bank")]
        //public int BankId { get; set; }
        [Required]
        public Bank Bank { get; set; }
    }
}
//transaction has one customer and one bank

