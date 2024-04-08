using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {

        // de private attributter, som også er backing field
        private string _itemId;
        private string _title;
        private double _price;

        // konstruktør der tager itemId som argument 
        public Book(string itemId)
        {
            _itemId = itemId;
        }

        // konstruktør der tager price og itemId til argument
        public Book(string itemId, string title)
        {
            _itemId = itemId;
            _title = title;
        }

        // konstruktør der tager itemId, title og price som argument 
        public Book(string itemId, string title, double price)
        {
            _itemId = itemId;
            _title = title;
            _price = price;
        }

        // ToString metode udskriver værdierne ved at have fast steng med interpolation hvor attributterne indsættes i klammerne
        public override string ToString()
        {
            return $"ItemId: {_itemId}, Title: {_title}, Price: {_price}";
        }

        // Properties der bruger de private backing field attributter 
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
