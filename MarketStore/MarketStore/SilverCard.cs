using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class SilverCard : Card
    {
        public SilverCard(Client owner, decimal turnover) : base(owner, turnover)
        {
        }

        public override decimal DiscountRate
        {
            get
            {
                if (this.Turnover >= 300)
                {
                    return this.discountRate = 3.5m;
                }
                else
                {
                    return this.discountRate = 2m;
                }
            }
        }
    }
}
