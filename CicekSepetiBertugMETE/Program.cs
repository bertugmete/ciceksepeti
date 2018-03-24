using CicekSepetiBertugMete.Business;
using CicekSepetiBertugMete.Models;
using CicekSepetiBertugMETE.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSepetiBertugMETE
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleService consoleService = new ConsoleService();
            consoleService.writeToConsole();
        }
    }
}
