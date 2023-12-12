using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ТravelMVC.Controllers;
using ТravelMVC.Veiw;

namespace ТravelMVC.Model
{
    public class VacationDestination
    {

        private double money;
        private string season;

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public string Season
        {
            get { return season; }
            set { season = value; }
        }

        public VacationDestination(double money, string season)
        {
            this.Money = money;
            this.Season = season;
        }

        public VacationDestination()
        {

        }


        public double CalculateSpendBgnSummer()
        {
            double Bgnsm = Money / 100.0 * 30;
            return
                Bgnsm;
        }

        public double CalculateSpendBgnWinter()
        {
            double Bgnwn= Money / 100.0 * 70;
            return Bgnwn;
        }

        public double CalculateSpendBalkanSummer()
        {
            double Balksm= Money / 100.0 * 40;
            return Balksm;
        }

        public double CalculateSpendBalkanWinter()
        {
            double Balkwn= Money / 100.0 * 80;
            return Balkwn;
        }

        public double CalculateSpendEurope()
        {
            double Eu= Money / 100.0 * 90;
            return Eu;
        }
            
    }
}
