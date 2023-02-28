using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Abstract.UnitOfWork
{
   public interface IUnitOfWork :IAsyncDisposable
    {

        //unitofwork.Advertisement
        IAdvertisement Advertisement { get; }
        ICategory Categories { get; }

        IComment Comments { get; }

        IUser Users { get; }

        IUserRole UserRoles { get; }



        Task<int> SaveAsync();



    }
}
