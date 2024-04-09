using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
    
        public double GetValueOfBook(Book book)
        {

            return book.Price;

        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0.0;

            // switchen definerer værdien for hvert kvalitetsniveau
            switch (amulet.Quality)
            {
                case Level.low:
                    // low kvalitet amulet har en værdi på 12.5 baseret på info fra operationskontrakten 
                    value =12.5;
                    break;
                case Level.medium:
                    // medium kvalitet amulet har en værdi på 20 baseret på info fra operationskontrakten
                    value = 20;
                    break;
                case Level.high:
                    // high kvalitet amulet har en værdi på 27.5 baseret på info fra operationskontrakten
                    value = 27.5;
                    break;
            }

            return value;
        }
    }

}

