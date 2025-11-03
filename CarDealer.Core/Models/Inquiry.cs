using System;

namespace CarDealer.Core.Models
{
    public class Inquiry
    {
        public int Id { get; set; }           // Primary Key
        public int CarId { get; set; }        // Связь с авто
        public string Name { get; set; }      // Имя пользователя
        public string Email { get; set; }     // Почта пользователя
        public string Phone { get; set; }     // Телефон
        public string Message { get; set; }   // Сообщение
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Дата запроса
    }
}
