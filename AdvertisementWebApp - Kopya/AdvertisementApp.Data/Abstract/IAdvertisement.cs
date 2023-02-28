using AdvertisementApp.Core.Data.Abstract;
using AdvertisementApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Abstract
{
    public interface IAdvertisement :IEntityRepository<Advertisement>
    {

      /* Advertisement Add(); */
      //generic repository kullanmasaydık her interfacede böyle yapıp. somutları doldurmak zorunda kalırdık.


        //repository pattern: veritabanı işlemlerini bir interface üzerinden yönetme tekniğidir.

        //genericrepository ise burda genel bir interface oluşturulur. kod tekrar azalır. karmaşıklı azalır.


    }
}
