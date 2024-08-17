using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachine
{
    internal class Machine
    {
        private int rpm;
        private int washingTime;
        private string mode;
        private int timeBeforeStart;
        private int temperature;

        public int TimeBeforeStart
        {
            get { return timeBeforeStart; }
            set { if (value >= 0) timeBeforeStart = value; 
            else Console.WriteLine("Без отложеной стирки");
            }
        }

        public void SimpleMode()
        {
            temperature = 60;
            rpm = 1000;
            washingTime = 60;
            mode = "обычная стирка";
            if (timeBeforeStart > 0)
            {
                Console.WriteLine($"Стирка запустится через {timeBeforeStart} минут(ы).  Режим - <{mode}>. Время стирки составляет {washingTime} минут, температура {temperature} градусов, обороты режима отжима {rpm} оборотов в минуту");
            }
            else
            {
                Console.WriteLine($"Стирка запущена в режиме <{mode}>. Время стирки составляет {washingTime} минут, температура {temperature} градусов, обороты режима отжима {rpm} оборотов в минуту");
            }
        }

        public void FastMode()
        {
            temperature = 40;
            rpm = 1200;
            washingTime = 15;
            mode = "быстрая стирка";
            if (timeBeforeStart > 0)
            {
                Console.WriteLine($"Стирка запустится через {timeBeforeStart} минут(ы).  Режим - <{mode}>. Время стирки составляет {washingTime} минут, температура {temperature} градусов, обороты режима отжима {rpm} оборотов в минуту");
            }
            else
            {
                Console.WriteLine($"Стирка запущена в режиме <{mode}>. Время стирки составляет {washingTime} минут, температура {temperature} градусов, обороты режима отжима {rpm} оборотов в минуту");
            }
        }

    }
}
