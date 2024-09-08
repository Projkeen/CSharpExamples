using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Accessors__get__set_
{
    public class Wallet
    {
        private int cash;

        //public Wallet(int cash)
        //{
        //       this.cash = cash;
        //}

        public Wallet()
        {
                
        }

        //public int GetCash()
        //{
        //    Console.WriteLine(cash);
        //    return cash;
        //}

        //public void SetCash(int value)
        //{
        //    if (value >= 0)
        //        cash = value;
        //}

        public int Cash
        {
            get { return cash; }
            set { if (value>=0)
                    cash = value;
            }
        }
    }
}
