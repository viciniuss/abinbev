using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    public class CreateSaleRequest
    {
        public Guid CustomerId { get; set; }
        public List<CreateSaleItemRequest> Items { get; set; } = new();
    }
}