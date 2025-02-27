using MediatR;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using System.Threading.Tasks;
using System.Threading;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
  public class CreateSaleCommand : IRequest<CreateSaleResponse>
    {
        public Guid CustomerId { get; set; }
        public List<CreateSaleItemCommand> Items { get; set; } = new();
    }

}