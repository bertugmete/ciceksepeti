using System;
using System.Collections.Generic;
using System.Text;

namespace CicekSepetiBertugMete.Models
{
    public class Material
    {
        public string Name { get; set; }
        //Cicekli
        protected bool isBloomy { get; set; }
        //dikenli
        protected bool isThorny { get; set; }
        //yaprakli
        protected bool isLeafed { get; set; }
        public int Count { get; set; }
    }
}
