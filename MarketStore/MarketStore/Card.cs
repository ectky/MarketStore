using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal abstract class Card
    {
        private decimal turnover;
        protected decimal discountRate;

        public Card(Client owner, decimal turnover)
        {
            this.Owner = owner;
            this.Turnover = turnover;
        }

        public decimal Turnover
        {
            get { return this.turnover; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Constants.invalidTurnover);
                }

                this.turnover = value;
            }
        }

        public Client Owner { get; set; }

        public abstract decimal DiscountRate { get; }

        public decimal CalculateDiscount(decimal purchaseValue)
        {
            if (purchaseValue < 0)
            {
                throw new ArgumentException(Constants.invalidPurchaseValue);
            }
            return purchaseValue * this.discountRate / 100;
        }

        public decimal CalculateTotal(decimal purchaseValue)
        {
            return purchaseValue - this.CalculateDiscount(purchaseValue);
        }
    }
}
