using CicekSepetiBertugMete.Models.SubModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CicekSepetiBertugMete.Models
{
    public class Bouquet
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Size { get; set; }
        public List<Material> materials { get; set; }

        public Bouquet(string name,int price,string size)
        {
            this.Name = name;
            this.Price = price;
            this.Size = size;
            this.materials = materials;
        }
    }
}
