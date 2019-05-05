using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnLineStore.Context;

namespace OnLineStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private OnLineBookStoreEntities context = new OnLineBookStoreEntities();


        public Repository<Book> BookRepository;
        public Repository<BookRequest> BookRequestRepository;
        public Repository<AspNetUser> UserRepository;
        public Repository<Category> CategoryRepository;
        public UnitOfWork()
        {
            BookRepository = new Repository<Book>(context);
            BookRequestRepository = new Repository<BookRequest>(context);
            UserRepository = new Repository<AspNetUser>(context);
            CategoryRepository = new Repository<Category>(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {

        }

    }



}
