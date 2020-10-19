using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities
{
    public class Game
    {
        public int GameId { get; set; }  // id
        public string Name { get; set; } // Назва гри
        public string Description { get; set; } // Опис 
        public string Category { get; set; } // Категорія 
        public decimal Price { get; set; } // Ціна
    }
}
