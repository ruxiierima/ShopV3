using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    internal class CautareProduse
    {
        internal static List<Produse> searchP(string s)
        {
            List<Produse> produse = new List<Produse>();
            List<Produse> searched = new List<Produse>();
            produse = ProduseController.GetProduse().ToList();
            foreach(Produse p in produse)
            {
                
                int ok = 0;
                for(int i = 0; i < s.Length; i++)
                {
                    if (p.NumeProdus[i] != s[i])
                    {
                        ok = 1;
                    }
                }
                if (ok == 0)
                {
                    searched.Add(p);
                }
            }

            return searched;
        }
    }
}
