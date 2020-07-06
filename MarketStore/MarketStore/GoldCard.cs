using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class GoldCard : Card
    {
        public GoldCard(Client owner, decimal turnover) : base(owner, turnover)
        {
        }

        public override decimal DiscountRate
        {
            get
            {
                if (this.Turnover >= 100)
                {
                    this.discountRate = 2m + (int)this.Turnover / 100;
                    if (this.discountRate > 10m)
                    {
                        this.discountRate = 10m;
                    }

                    return this.discountRate;
                }
                else
                {
                    return this.discountRate = 2m;
                }
            }
        }
    }
}
