using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly DefaultContext _context;

        public SaleRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Sale> GetByIdAsync(Guid id)
        {
            return await _context.Sales.Include(s => s.Items) // Incluindo os itens da venda
                                        .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Sale>> GetAllAsync()
        {
            return await _context.Sales.Include(s => s.Items).ToListAsync();
        }

        public async Task AddAsync(Sale sale)
        {
            await _context.Sales.AddAsync(sale);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Sale sale)
        {
            _context.Sales.Update(sale);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var sale = await GetByIdAsync(id);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Sale>> GetSalesByCustomerIdAsync(Guid customerId)
        {
            return await _context.Sales.Where(s => s.CustomerId == customerId)
                                        .Include(s => s.Items)
                                        .ToListAsync();
        }

        public async Task<IEnumerable<Sale>> GetSalesByBranchIdAsync(Guid branchId)
        {
            return await _context.Sales.Where(s => s.BranchId == branchId)
                                        .Include(s => s.Items)
                                        .ToListAsync();
        }
    }
}
