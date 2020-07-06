using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    internal class Client
    {
        private string name;
        private ushort age;

        public Client(string name, ushort age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException(Constants.invalidName);
                }

                this.name = value;
            }
        }

        public ushort Age
        {
            get { return this.age; }
            set
            {
                if (value <= 16)
                {
                    throw new ArgumentException(Constants.invalidAge);
                }

                this.age = value;
            }
        }
    }
}
