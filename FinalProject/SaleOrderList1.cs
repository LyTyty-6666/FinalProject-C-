using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class SaleOrderList1
    {
        private List<SaleOrder1> lists = new List<SaleOrder1>();
        public void AddFunction(SaleOrder1 list)
        {
            lists.Add(list);
        }
    }
}
