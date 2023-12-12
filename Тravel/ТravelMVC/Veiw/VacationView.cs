using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ТravelMVC.Model;

namespace ТravelMVC.Veiw
{
    public class VacationView
    {
        public double Money {  get; set; }
        public string Season{  get; set; }
        public double Bgnsm {  get; set; }
        public double Bgnwn {  get; set; }
        public double Balksm {  get; set; }
        public double Balkwn {  get; set; }
        public double Eu {  get; set; }
        

        public void Input()
        {
            
            Console.WriteLine("Enter money: ");
            Money =double.Parse( Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter season: ");
            Season = Console.ReadLine();

        }


        public void Output1() 
        {
           
            Console.WriteLine($"Camp - {Bgnsm:F2}");
            

        }
    }

}
