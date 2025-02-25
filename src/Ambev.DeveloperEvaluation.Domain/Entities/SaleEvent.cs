using System;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid SaleId { get; set; }
        public string EventType { get; set; }  
        public DateTime EventDate { get; set; } = DateTime.UtcNow;
        public string EventData { get; set; }
    }
}
