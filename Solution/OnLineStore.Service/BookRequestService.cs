using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnLineStore.DataModel;
using OnLineStore.Context;
using AutoMapper;
namespace OnLineStore.Service
{
   public class BookRequestService :BaseService
    {
        public List<BookRequestModel> GetAll()
        {
            var allBookRequests = _unitOfWork.BookRequestRepository.GetAll().ToList();
            var result = Mapper.Map<IEnumerable<BookRequest>, IEnumerable<BookRequestModel>>(allBookRequests);
            return result.ToList();

        }

        public bool Add(BookRequestModel bookRequestModel)
        {
            bool result = false;
            try
            {
                bookRequestModel.StatusID = (int)Enums.Status.pending_verification;
                var bookRequest = Mapper.Map<BookRequestModel, BookRequest>(bookRequestModel);
                bookRequest.CreateDate = DateTime.Now;
                _unitOfWork.BookRequestRepository.Insert(bookRequest);
                _unitOfWork.Save();
                result = true;
            }
            catch
            {
                //Log Error Future Work
            }
            return result;
          
        }

        


    }
}
