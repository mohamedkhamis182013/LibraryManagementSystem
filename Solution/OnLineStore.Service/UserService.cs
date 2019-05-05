using AutoMapper;
using OnLineStore.Context;
using OnLineStore.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Service
{
    public class UserService : BaseService
    {

        public List<UserModel> GetAllUsers()
        {
            var allUsers = _unitOfWork.UserRepository.GetAll().ToList();
            var result = Mapper.Map<IEnumerable<AspNetUser>, IEnumerable<UserModel>>(allUsers);
            return result.ToList();
        }

        public bool AddEdit(UserModel userModel)
        {
            bool result = false;
            try
            {
                //bookRequestModel.StatusID = (int)Enums.Status.pending_verification;
                var user = Mapper.Map<UserModel, AspNetUser>(userModel);

                  _unitOfWork.UserRepository.Insert(user);
                result = true;
            }
            catch
            {
                //Log Error Future Work
            }
            return result;

        }

        public bool Delete(UserModel userModel)
        {
            bool result = false;
            try
            {
                var user = Mapper.Map<UserModel, AspNetUser>(userModel);
                _unitOfWork.UserRepository.Delete(user);
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
