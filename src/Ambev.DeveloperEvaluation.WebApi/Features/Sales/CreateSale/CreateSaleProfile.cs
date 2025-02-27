using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

public class CreateSaleProfile : Profile
{
    public CreateSaleProfile()
    {
       CreateMap<CreateSaleCommand, Sale>()
            .ForMember(dest => dest.Id, opt => opt.Ignore()) // ID será gerado automaticamente
            .ForMember(dest => dest.Date, opt => opt.MapFrom(_ => DateTime.UtcNow))
            .ForMember(dest => dest.IsCancelled, opt => opt.MapFrom(_ => SaleEventType.SaleCreated));
    }
}
