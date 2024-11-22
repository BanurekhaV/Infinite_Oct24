using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTest
{
    public class Cart
    {
        private readonly IProductRepository _prodrepo;

        private readonly Dictionary<int, int> items;

        public Cart(IProductRepository prepo)
        {
            _prodrepo = prepo;
            items = new Dictionary<int, int>();
        }

        public void AddItem(int prd_id, int qty)
        {
            Products prod = _prodrepo.GetByID(prd_id);

            if (prod != null)
            {
                if (items.ContainsKey(prd_id))
                {
                    items[prd_id] += qty;
                }
                else
                {
                    items[prd_id] = qty;
                }
            }
        }

        public int GetTotalCount()
        {
            return items.Values.Sum();
        }
        
    }
}
