using System;
using System.Collections.Generic;
using System.Text;

namespace CicekSepetiBertugMete.Models.SubModel
{
    public class Adornment : Material
    {
        public Adornment()
        {
            this.Name = "süslemeler";
            this.isBloomy = false;
            this.isLeafed = true;
            this.isThorny = false;
        }
    }
}
