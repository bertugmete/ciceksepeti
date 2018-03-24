using System;
using System.Collections.Generic;
using System.Text;
using CicekSepetiBertugMete.Models;
using CicekSepetiBertugMete.Models.SubModel;
using CicekSepetiBertugMETE.Business.Types;

namespace CicekSepetiBertugMete.Business
{
    public class BouquetService : IBouquetService
    {
        public List<Bouquet> createAllBouquets()
        {
            List<Bouquet> myBouquet = new List<Bouquet>();
            //Rose Bouquet
            Bouquet smallRoseBouquet = new Bouquet(BouquetName.roseBouquet, 10, Size.small); smallRoseBouquet.materials = new List<Material>(); smallRoseBouquet.materials.Add(new Rose { Count = 10 }); smallRoseBouquet.materials.Add(new Adornment { Count = 5 });

            Bouquet middleRoseBouquet = new Bouquet(BouquetName.roseBouquet, 15, Size.middle); middleRoseBouquet.materials = new List<Material>(); middleRoseBouquet.materials.Add(new Rose { Count = 25 }); middleRoseBouquet.materials.Add(new Adornment { Count = 10 });

            Bouquet bigRoseBouquet = new Bouquet(BouquetName.roseBouquet, 20, Size.big); bigRoseBouquet.materials = new List<Material>(); bigRoseBouquet.materials.Add(new Rose { Count = 50 }); bigRoseBouquet.materials.Add(new Adornment { Count = 15 });

            //Gelinlikli Güller
            Bouquet smallWeddingRosery = new Bouquet(BouquetName.weddingRosery, 12, Size.small); smallWeddingRosery.materials = new List<Material>(); smallWeddingRosery.materials.Add(new Rose { Count = 5 }); smallWeddingRosery.materials.Add(new Daisy { Count = 20 }); smallWeddingRosery.materials.Add(new Adornment { Count = 5 });

            Bouquet middleWeddingRosery = new Bouquet(BouquetName.weddingRosery, 16, Size.middle); middleWeddingRosery.materials = new List<Material>(); middleWeddingRosery.materials.Add(new Rose { Count = 7 }); middleWeddingRosery.materials.Add(new Daisy { Count = 20 }); middleWeddingRosery.materials.Add(new Adornment { Count = 10 });

            Bouquet bigWeddingRosery = new Bouquet(BouquetName.weddingRosery, 20, Size.big); bigWeddingRosery.materials = new List<Material>(); bigWeddingRosery.materials.Add(new Rose { Count = 10 }); bigWeddingRosery.materials.Add(new Daisy { Count = 20 }); bigWeddingRosery.materials.Add(new Adornment { Count = 15 });

            //Orkide Buketi
            Bouquet smallOrchidBouquet = new Bouquet(BouquetName.orchidBouquet, 20, Size.small); smallOrchidBouquet.materials = new List<Material>(); smallOrchidBouquet.materials.Add(new Orchid { Count = 1 });

            Bouquet middleOrchidBouquet = new Bouquet(BouquetName.orchidBouquet, 25, Size.middle); middleOrchidBouquet.materials = new List<Material>(); middleOrchidBouquet.materials.Add(new Orchid { Count = 2 });

            Bouquet bigOrchidBouquet = new Bouquet(BouquetName.orchidBouquet, 30, Size.big); bigOrchidBouquet.materials = new List<Material>(); bigOrchidBouquet.materials.Add(new Orchid { Count = 5 });

            myBouquet.Add(smallRoseBouquet);
            myBouquet.Add(middleRoseBouquet);
            myBouquet.Add(bigRoseBouquet);

            myBouquet.Add(smallWeddingRosery);
            myBouquet.Add(middleWeddingRosery);
            myBouquet.Add(bigWeddingRosery);

            myBouquet.Add(smallOrchidBouquet);
            myBouquet.Add(middleOrchidBouquet);
            myBouquet.Add(bigOrchidBouquet);

            return myBouquet;
        }
    }
}
