using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnLineStore.DataModel;
using AutoMapper;
using OnLineStore.Context;

namespace OnLineStore.Service
{
     public class BookService : BaseService
    {

         public List<BookModel> GetAll()
         {
             var allBooks =_unitOfWork.BookRepository.GetAll().ToList();
             var result = Mapper.Map<IEnumerable<Book>, IEnumerable<BookModel>>(allBooks);
             return result.ToList();
         }

         public BookModel GetBook(int ID)
         {
             if (ID > 0)
             {
                return Mapper.Map<Book,BookModel>(_unitOfWork.BookRepository.GetByID(ID));
             }
             else
             {
                 return new BookModel();
             }
         }

         public bool AddEdit(BookModel bookModel)
         {
             bool result = false;
             try
             {
                 //bookRequestModel.StatusID = (int)Enums.Status.pending_verification;
                 var book = Mapper.Map<BookModel, Book>(bookModel);

                 if (book.ID > 0)
                 {
                     book.CreateDate = DateTime.Now;
                     _unitOfWork.BookRepository.Update(book);
                 }
                 else
                 {
                     book.CreateDate = DateTime.Now;
                     _unitOfWork.BookRepository.Insert(book);

                 }
                 _unitOfWork.Save();
                 result = true;
             }
             catch
             {
                 //Log Error Future Work
             }
             return result;

         }

         public Dictionary<string, string> GetAllCategories()
         {
             return _unitOfWork.CategoryRepository.GetAll().ToDictionary(o => o.ID.ToString(), o => o.Name);
         }
         public bool Delete(int ID)
         {
             bool result = false;
             try
             {
                 _unitOfWork.BookRepository.Delete(ID);
                 _unitOfWork.Save();
                 result = true;

             }
             catch
             {
                 //log error
             }
             return result;
         }
    }
}
