using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IShopProperties
    {
        string Name { get; set; }
        string Description { get; set; }
        string Brand { get; set; } 
        int Pieces { get; set; }
        decimal Price { get; set; }
    }
}
