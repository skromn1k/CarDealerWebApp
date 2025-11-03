namespace CarDealer.Core.Interfaces
{
    using CarDealer.Core.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IInquiryService
    {
        Task<IEnumerable<Inquiry>> GetAllInquiriesAsync();
        Task<Inquiry> GetInquiryByIdAsync(int id);
        Task AddInquiryAsync(Inquiry inquiry);
        Task DeleteInquiryAsync(int id);
    }
}
