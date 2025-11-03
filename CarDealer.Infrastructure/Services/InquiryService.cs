namespace CarDealer.Infrastructure.Services
{
    using CarDealer.Core.Interfaces;
    using CarDealer.Core.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class InquiryService : IInquiryService
    {
        private readonly IInquiryRepository _repository;

        public InquiryService(IInquiryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Inquiry>> GetAllInquiriesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Inquiry> GetInquiryByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddInquiryAsync(Inquiry inquiry)
        {
            // минимальная валидация, можно расширить
            if (inquiry == null) throw new ArgumentNullException(nameof(inquiry));
            if (string.IsNullOrWhiteSpace(inquiry.Name)) throw new ArgumentException("Name required");
            if (string.IsNullOrWhiteSpace(inquiry.Email)) throw new ArgumentException("Email required");

            // при необходимости: установка CreatedAt
            if (inquiry.CreatedAt == default) inquiry.CreatedAt = DateTime.UtcNow;

            await _repository.AddAsync(inquiry);
        }

        public async Task DeleteInquiryAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}