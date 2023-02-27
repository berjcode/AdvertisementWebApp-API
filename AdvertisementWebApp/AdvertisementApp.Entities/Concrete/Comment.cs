using AdvertisementApp.Core.Entities.Abstract;
using AdvertisementApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Entities.Concrete
{
  public class Comment:EntityBase,IEntity
    {

        public string Text { get; set; }

        public int AdvertisementId { get; set; }

        public Advertisement Advertisements { get; set; }


        public int UserId { get; set; }

        public User Users { get; set; }


    }
}
