using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShop.Controllers.Products
{
    internal class CheckStoc
    {
        internal static bool Check(Produse produs)
        {
            if (produs.Stoc > 0)
                return true;
            return false;
        }
    }
}
