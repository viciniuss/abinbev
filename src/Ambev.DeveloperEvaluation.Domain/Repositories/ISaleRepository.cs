using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleRepository
    {
        Task<Sale> GetByIdAsync(Guid id); // Buscar venda por ID
        Task<IEnumerable<Sale>> GetAllAsync(); // Buscar todas as vendas
        Task AddAsync(Sale sale); // Adicionar uma nova venda
        Task UpdateAsync(Sale sale); // Atualizar uma venda existente
        Task<bool> DeleteAsync(Guid id); // Excluir uma venda
        Task<IEnumerable<Sale>> GetSalesByCustomerIdAsync(Guid customerId); // Buscar vendas por cliente
        Task<IEnumerable<Sale>> GetSalesByBranchIdAsync(Guid branchId); // Buscar vendas por filial
    }
}
