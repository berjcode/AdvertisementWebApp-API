using AdvertisementApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Core.Entities.Concrete
{
    public abstract class EntityBase :IEntity
    {
        public virtual int Id { get; set; }

        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual DateTime UpdatedDate { get; set; } = DateTime.Now;

        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;



    }
}
