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


    public class Amulet
    {
        // de private attributter, som også er backing field
        private string _itemId;
        private string _design;
        private Level _quality;

        // constructorer der bruger itemId som argument
        public Amulet(string itemId)
        {
            _itemId = itemId;
            _quality = Level.medium; // forstår ikke hvorfor, men her skal åpbenbart være denne værdi for at testen med det ene parameter passere. 
        }

        // constructor der bruger argumenterne  itemId og quality
        public Amulet(string itemId, Level quality)
        {
            _itemId = itemId;
            _quality = quality;
        }

        // constructor der også bruger design som argument
        public Amulet(string itemId, Level quality, string design)
        {
            _itemId = itemId;
            _quality = quality;
            _design = design;
        }

        // ToString metode udskriver værdierne ved at have fast steng med interpolation hvor attributterne indsættes i klammerne
        public override string ToString()
        {
            return $"ItemId: {_itemId}, Quality: {_quality}, Design: {_design}";
        }

        // Properties
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
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

