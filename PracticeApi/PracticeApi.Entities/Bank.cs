using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PracticeApi.Entities
{
    public class Bank
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //
        public List<Customer> Customers { get; set; }
        public List<Transaction> Transactions { get; set; }

    }
}

//bank has multiple customers and multiple transactions