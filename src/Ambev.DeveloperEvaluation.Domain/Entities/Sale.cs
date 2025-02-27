using System;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string SaleNumber { get; set; }
        public DateTime Date { get; set; }
        
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }

        public Guid BranchId { get; set; }
        public string BranchName { get; set; }

        public decimal TotalAmount => Items.Sum(i => i.TotalAmount);
        public bool IsCancelled { get; set; }

        public List<SaleItem> Items { get; set; } = new List<SaleItem>();
    }
}
