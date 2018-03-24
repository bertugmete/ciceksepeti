using CicekSepetiBertugMete.Business;
using CicekSepetiBertugMete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSepetiBertugMETE.Business
{
    class ConsoleService : IConsole
    {
        public void writeToConsole()
        {
            BouquetService bouquetService = new BouquetService();
            List<Bouquet> _myBouquet = bouquetService.createAllBouquets();
            string midresult = "";

            string lastResult = "";
            int sayac = 0;
            foreach (Bouquet bouquet in _myBouquet)
            {
                if (sayac % 3 == 0)
                {
                    midresult += string.Format("- {0}", bouquet.Name) + ":";
                }
                midresult += string.Format("\n\t - {0} \n \t \t - İçerik:", bouquet.Size);

                foreach (Material material in bouquet.materials)
                {
                    midresult += string.Format(" {0} adet {1} +", material.Count, material.Name);
                }
                midresult = midresult.Substring(0, midresult.Length - 1) + "\n";
                midresult += string.Format("\t \t - Fiyat : {0} TL \n", bouquet.Price);

                lastResult += midresult;
                midresult = "";
                sayac++;
            }
            Console.WriteLine(lastResult);
            Console.ReadLine();
        }

    }
}
