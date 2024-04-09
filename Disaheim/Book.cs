using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise //her ses at Book nedarver fra Merchandise 
    {
        private string _title;
        private double _price;

        public Book(string itemId) : base(itemId) //base keyword kalder på baseklassen Merchandise ItemId da Book klassen nedarver ItemId fra Merchandiae 
        {
        }//tom fordi den bruger constructor fra merchandise klassen

        public Book(string itemId, string title) : base(itemId)
        {
            _title = title;
        } //henter itemId fra merchandise klassen, nedarvning

        public Book(string itemId, string title, double price) : base(itemId)
        {
            _title = title;
            _price = price;
        } //henter itemId fra merchandise 

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {_title}, Price: {_price}";
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

