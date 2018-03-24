using System;
using System.Collections.Generic;
using System.Text;

namespace CicekSepetiBertugMete.Models.SubModel
{
    public class Rose : Material
    {
        public Rose()
        {
            this.Name = "gül";
            this.isBloomy = true;
            this.isLeafed = true;
            this.isThorny = true;
        }
    }
}
