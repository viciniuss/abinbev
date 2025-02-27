using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
   public class CreateSaleItemRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}