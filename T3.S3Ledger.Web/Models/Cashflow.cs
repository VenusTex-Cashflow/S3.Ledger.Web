using System;
using static T3.S3Ledger.Web.Enums;

namespace T3.S3Ledger.Web.Models
{
    public class Cashflow
    {
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
        public long CustomerId { get; set; }
        public CustomerModel Customer { get; set; }

        public TransactionType CashInOut { get; set; }
    }
}
