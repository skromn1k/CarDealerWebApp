using System;

namespace CarDealer.Core.Models
{
    public class Car
    {
        public int Id { get; set; }            // Primary Key
        public string Make { get; set; }       // Производитель
        public string Model { get; set; }      // Модель авто
        public int Year { get; set; }          // Год выпуска
        public decimal Price { get; set; }     // Цена
        public string Description { get; set; } // Описание авто
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Дата добавления
    }
}
