using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeApi.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CardNumber { get; set; }
        public string Email { get; set; }

        //
        //[ForeignKey("Bank")]
        //public int BankId { get; set; }
        [Required]
        public Bank Bank { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}

//customer has one bank and many transactions
