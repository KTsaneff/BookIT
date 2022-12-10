using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookIT.Core.Models.Hotel
{
    public class HotelViewModel
    {
        public string ImageURL { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string StarCategory { get; set; } = null!;
    }
}
