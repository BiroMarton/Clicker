using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    [Serializable]
    class GameData
    {
        public double money;
        public double amount;
        public double moreAmount;
        public bool winnable;
        public DateTime previousDate;
        [NonSerialized]
        public DateTime currentDate;
        


        public GameData(double money,double amount, double moreAmount, bool winnable, DateTime previousDate)
        {
            this.money = money;
            this.amount = amount;
            this.moreAmount = moreAmount;
            this.previousDate = previousDate;
            currentDate = DateTime.Now;
        }

        public int elapsedTime()
        {
            try
            {
                System.TimeSpan elapsed = currentDate.Subtract(previousDate);
                return Convert.ToInt32(elapsed.TotalSeconds);
            }
            catch (NullReferenceException ne)
            {
                return 0;
            }
            catch (ArgumentNullException an)
            {
                return 0;
            }

        }
    }
}
