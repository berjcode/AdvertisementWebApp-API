using AdvertisementApp.Data.Abstract;
using AdvertisementApp.Data.Abstract.UnitOfWork;
using AdvertisementApp.Data.Concrete.Entityframework.Contexts;
using AdvertisementApp.Data.Concrete.Entityframework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Data.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {


        private readonly AdvertisementAppContext _context;
        private EfAdvertisementRepository _advertisementRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfUserRepository _userRepository;
        private EfUserRoleRepository _userRoleRepository;
        public UnitOfWork(AdvertisementAppContext context)
        {
            _context = context;
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public IAdvertisement Advertisement => _advertisementRepository ?? new EfAdvertisementRepository(_context);

        public ICategory Categories =>  _categoryRepository ?? new EfCategoryRepository(_context);


        public IComment Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IUser Users  => _userRepository ?? new EfUserRepository(_context);

        public IUserRole UserRoles  => _userRoleRepository ?? new EfUserRoleRepository(_context);

      

        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync(); //int döner.
        }


    }
}
