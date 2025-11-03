using CarDealer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealer.Core.Interfaces
{
    public interface IInquiryRepository
    {
        Task<IEnumerable<Inquiry>> GetAllAsync();    // Все запросы
        Task<Inquiry> GetByIdAsync(int id);         // Запрос по Id
        Task AddAsync(Inquiry inquiry);             // Добавить запрос
        Task DeleteAsync(int id);                   // Удалить запрос
    }
}
