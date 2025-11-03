using CarDealer.Core.Interfaces;
using CarDealer.Core.Models;
using CarDealer.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealer.Infrastructure.Repositories
{
    public class InquiryRepository : IInquiryRepository
    {
        private readonly CarDealerDbContext _context;

        public InquiryRepository(CarDealerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Inquiry>> GetAllAsync()
        {
            return await _context.Inquiries.ToListAsync();
        }

        public async Task<Inquiry> GetByIdAsync(int id)
        {
            return await _context.Inquiries.FindAsync(id);
        }

        public async Task AddAsync(Inquiry inquiry)
        {
            await _context.Inquiries.AddAsync(inquiry);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var inquiry = await _context.Inquiries.FindAsync(id);
            if (inquiry != null)
            {
                _context.Inquiries.Remove(inquiry);
                await _context.SaveChangesAsync();
            }
        }
    }
}

