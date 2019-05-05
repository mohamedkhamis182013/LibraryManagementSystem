using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnLineStore.Repository;
namespace OnLineStore.Service 
{
     public class BaseService
    {
        public UnitOfWork _unitOfWork;
        public BaseService()
        {
            _unitOfWork = new UnitOfWork();
        } 
    }
}
