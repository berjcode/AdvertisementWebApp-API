using AdvertisementApp.Core.Entities.Abstract;
using AdvertisementApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Entities.Concrete
{

   public class Category: EntityBase,IEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        // bir kategorinin birden fazla makalesi olabilir.
        public ICollection<Advertisement> Advertisements { get; set; }

        //Koleksiyon Nedir? 
        //bir veri grubunu depolomak ve yönetmek için kullanılır.dizilere benzer ama boyutları değiştirilebilir veya dinamik olarak büyür.
        // ICollection nedir?







    }
}
