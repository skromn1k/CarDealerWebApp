using CarDealer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDealer.Core.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllAsync();       // Получить все авто
        Task<Car> GetByIdAsync(int id);            // Получить авто по Id
        Task AddAsync(Car car);                    // Добавить авто
        Task UpdateAsync(Car car);                 // Обновить авто
        Task DeleteAsync(int id);                  // Удалить авто
    }
}

