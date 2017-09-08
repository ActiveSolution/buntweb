using System.Collections.Generic;
using System.Linq;
using System.Web.Razor.Generator;

namespace BuntWeb.Domain
{
    public class Buntlådeställen
    {
        private List<Buntlådeställe> _ställen = new List<Buntlådeställe>();

        public void LäggTill(string adress, Typ typ)
        {
            if (typ == Typ.Lämna && _ställen.Any(s => s.Adress == adress && s.Typ == Typ.Lämna))
                throw new BuntlådeställeException("Det får inte finnas två lämnaställen med samma adress");

            _ställen.Add(new Buntlådeställe { Adress = adress, Typ = typ });
        }

        public void TaBort(int index)
        {
        }

        public void Flytta(int frånIndex, int tillIndex)
        {
        }

        public IEnumerable<BuntlådeställeTabellrad> Lista()
        {
            return _ställen.Select(s => new BuntlådeställeTabellrad
            {
                Adress = s.Adress
            });
        }
    }

    internal class Buntlådeställe
    {
        public string Adress { get; set; }
        public Typ Typ { get; set; }
    }
}