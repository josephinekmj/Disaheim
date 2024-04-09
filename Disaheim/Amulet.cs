using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{

//    // Navnekonventionen: 
//•	Klassens navn skal være i UpperCamelCase/PascalCase og i ental
//•	Attributter, der er public (+) og starter med et stort bogstav(UpperCamelCase/PascalCase),
//  skal implementeres i C# som properties med stort startbogstav.
//•	Attributter, der er private (-) og starter med et lille bogstav(lowerCamelCase),
//  skal implementeres i C# som et felt (en: field) med lille startbogstav.
//  Bemærk: Hvis et privat C# felt fungerer som et ’backing field’ for en property,
//  da skal feltnavn foranstilles med en underscore (_).
//•	En operation med samme navn som klassen(og uden returtype)
//  skal implementeres i C# som en constructor (dvs. stereotypen «constructor» udelades),
//  ellers som en metode
//  Denne navnekonvention benyttes fremover i alle kommende opgaver med mindre andet nævnes.


    public class Amulet : Merchandise
    {
        private string _design;
        private Level _quality;

        public Amulet(string itemId) : base(itemId)
        {
            _quality = Level.medium;
        }

        public Amulet(string itemId, Level quality) : base(itemId)
        {
            _quality = quality;
        }

        public Amulet(string itemId, Level quality, string design) : base(itemId)
        {
            _quality = quality;
            _design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {_quality}, Design: {_design}";
        }

        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }

        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }
    }
}
