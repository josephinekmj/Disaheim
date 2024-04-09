using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        //her gøres listerne tilgængelig udenfor klassen via property
        public List<Book> Books { get; private set; }

        public List<Amulet> Amulets { get; private set; }

        public Controller()
        {
            // her initialiseres properties som tomme lister i constructor´ne
            Books = new List<Book>();
            Amulets = new List<Amulet>();
        }

        // denne metode tilføjer en bog til listen af bøger
        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        // denne metode tilføjer en amulet til listen af amuletter
        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
