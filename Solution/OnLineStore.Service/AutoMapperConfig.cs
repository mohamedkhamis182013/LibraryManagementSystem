using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OnLineStore.Context;
using OnLineStore.DataModel;

namespace OnLineStore.Service
{
     public class AutoMapperConfig
    {
        public static void AutoMapperRegister()
        {
            Mapper.CreateMap<Book, BookModel>()
                .ForMember(dest => dest.CategoryName,
                      opt=>opt.MapFrom(src => (src.CategoryID >0? src.Category.Name:"NoCategory")))
                 .ForMember(dest => dest.CreatedBy,
                      opt => opt.MapFrom(src => (src.UserID !=null ? src.AspNetUser.UserName : "NotFound")))
                 .ForMember(dest => dest.CreateDate,
                      opt => opt.MapFrom(src => (src.CreateDate != null ? src.CreateDate.Value.ToString("dddd, dd MMMM yyyy") : "")))
                 .ForMember(dest => dest.LastUpdateDate,
                      opt => opt.MapFrom(src => (src.LastUpdateDate != null ? src.LastUpdateDate.Value.ToString("dddd, dd MMMM yyyy") : ""))) ;
            Mapper.CreateMap<BookModel, Book>();

            Mapper.CreateMap<BookRequest, BookRequestModel>()
                 .ForMember(dest => dest.CategoryName,
                      opt => opt.MapFrom(src => (src.CategoryID > 0 ? src.Category.Name : "NoCategoryFound")))
                 .ForMember(dest => dest.RequestedBy,
                      opt => opt.MapFrom(src => (src.UserID != null ? src.AspNetUser.UserName : "NotFound")))
                 .ForMember(dest => dest.CreateDate,
                      opt => opt.MapFrom(src => (src.CreateDate != null ? src.CreateDate.Value.ToString("dddd, dd MMMM yyyy") : "NotFound")))
                 .ForMember(dest => dest.StatusString,
                      opt => opt.MapFrom(src => (src.StatusID > 0 ? src.Status.Name: "NotFound")));
            Mapper.CreateMap<BookRequestModel, BookRequest>();

            Mapper.CreateMap<AspNetUser, UserModel>()
                .ForMember(dest => dest.Roles,
                      opt => opt.MapFrom(src => (src.AspNetRoles.Count > 0 ? src.AspNetRoles.Select(x=>x.Name).ToList() : new List<string>()))); ;
            Mapper.CreateMap<UserModel, AspNetUser>();
        }
    }
}
