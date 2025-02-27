using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// API response model for GetSale operation
/// </summary>
public class GetSaleResponse
{
    /// <summary>
    /// The unique identifier of the Sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The SaleNumber associated
    /// </summary>
    public string SaleNumber { get; set; }

    /// <summary>
    /// The Sale date 
    /// </summary>
    public DateTime Date { get; set; } 

    /// <summary>
    /// The Sale Costumer Identification
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The Sale Name Costumer
    /// </summary>
    public string CustomerName { get; set; }
     /// <summary>
    /// The Sale Branch Id
    /// </summary>
    public Guid BranchId { get; set; }
     /// <summary>
    /// The Sale Branch Name
    /// </summary>
    public string BranchName { get; set; }
     /// <summary>
    /// The Sale Amount
    /// </summary>

    public decimal TotalAmount { get; set; }
     /// <summary>
    /// If canceled sale
    /// </summary>
    public bool IsCancelled { get; set; }
     /// <summary>
    /// The Sale items
    /// </summary>

    public List<SaleItem> Items { get; set; }
}
