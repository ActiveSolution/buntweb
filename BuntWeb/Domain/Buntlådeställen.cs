using System.Collections.Generic;

namespace BuntWeb.Domain
{
    public class Buntlådeställen
    {
        public void LäggTill(string adress, Typ typ)
        {
        }

        public void TaBort(int index)
        {
        }

        public void Flytta(int frånIndex, int tillIndex)
        {
        }

        public IEnumerable<BuntlådeställeTabellrad> Lista()
        {
            return new[]
            {
                new BuntlådeställeTabellrad
                {
                    Adress = "Kungstensgatan 1",
                    Typ = "Lämna",
                    Index = 0,
                    Buntlådenummer = 1
                },
                new BuntlådeställeTabellrad
                {
                    Adress = "Kungstensgatan 3",
                    Typ = "Lämna",
                    Index = 1,
                    Buntlådenummer = 2
                },
                new BuntlådeställeTabellrad
                {
                    Adress = "Kungstensgatan 1",
                    Typ = "Hämta",
                    Index = 2,
                    Buntlådenummer = 1
                },
                new BuntlådeställeTabellrad
                {
                    Adress = "Kungstensgatan 5",
                    Typ = "Lämna",
                    Index = 3,
                    Buntlådenummer = 3
                },
                new BuntlådeställeTabellrad
                {
                    Adress = "Kungstensgatan 5",
                    Typ = "Hämta",
                    Index = 4,
                    Buntlådenummer = 3
                },
                new BuntlådeställeTabellrad
                {
                    Adress = "Kungstensgatan 1",
                    Typ = "Hämta",
                    Index = 5,
                    Buntlådenummer = 1
                },
            };
        }
    }
}