using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ТravelMVC.Model;
using ТravelMVC.Veiw;

namespace ТravelMVC.Controllers
{
    public class VacationController
    {
        private VacationDestination myModel=new VacationDestination();
        private VacationView myView=new VacationView();

        public VacationController()
        {
            myView.Input();

            myModel.Money=myView.Money;
            myModel.Season=myView.Season;
            myView.Bgnsm=myModel.CalculateSpendBgnSummer();
            myView.Bgnwn=myModel.CalculateSpendBgnWinter();
            myView.Balksm=myModel.CalculateSpendBalkanSummer();
            myView.Balkwn=myModel.CalculateSpendBalkanWinter();
            myView.Eu=myModel.CalculateSpendEurope();

            myView.Output1();
            
        }

    }
}
