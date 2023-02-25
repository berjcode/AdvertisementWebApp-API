using AdvertisementApp.Core.Entities.Abstract;
using AdvertisementApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Entities.Concrete
{
    public class Advertisement:EntityBase,IEntity
    {
        public string Title { get; set; }

        public string  Content { get; set; }

        

        public string  Photo { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Photo4 { get; set; }

        public DateTime Date { get; set; }


        public int  ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoTags { get; set; }

        //Bir ilanın bir tane sahibi vardır.
        public int UserId { get; set; }
        public User User { get; set; }



        public int  CategoryId { get; set; }
        //NavigationProperty
        public Category Category { get; set; }


        // 
        public ICollection<Comment> Comments { get; set; }




    }
}
