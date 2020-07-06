using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class BronzeCard : Card
    {
        public BronzeCard(Client owner, decimal turnover) : base(owner, turnover)
        {
        }

        public override decimal DiscountRate
        {
            get
            {
                if (this.Turnover < 100)
                {
                    return this.discountRate = 0;
                }
                else if (this.Turnover >= 100 && this.Turnover < 300)
                {
                    return this.discountRate = 1m;
                }
                else
                {
                    return this.discountRate = 2.5m;
                }
            }
        }
    }
}
