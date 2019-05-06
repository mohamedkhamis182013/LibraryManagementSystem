using OnLineStore.DataModel;
using OnLineStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace OnLineStore.Controllers
{
	[Authorize]
	public class BookController : Controller
	{

		private BookService _bookService;
		private BookRequestService _bookRequestService;

		public BookService BookService
		{
			get
			{
				return _bookService ?? new BookService();
			}
			private set
			{
				_bookService = value;
			}
		}

		public BookRequestService BookRequestService
		{
			get
			{
				return _bookRequestService ?? new BookRequestService();
			}
			private set
			{
				_bookRequestService = value;
			}
		}
		//
		// GET: /Book/
		public ActionResult Index()
		{
			return View(BookService.GetAll());
		}

		public ActionResult AddEdit(int ID)
		{
			ViewBag.categories = BookService.GetAllCategories();
			return View(BookService.GetBook(ID));
		}
		[HttpPost]
		public ActionResult AddEdit(BookModel bookModel)
		{
			 bookModel.UserID = User.Identity.GetUserId();
			 BookService.AddEdit(bookModel);
			 return RedirectToAction("Index");
		}

		public ActionResult Delete(int ID)
		{
			return Content(BookService.Delete(ID)?"1":"0");
		}

        public ActionResult RequestBook()
        {
            ViewBag.categories = BookService.GetAllCategories();
            return View(new BookRequestModel());
        }
        [HttpPost]
        public ActionResult RequestBook(BookRequestModel bookRequestModel)
        {
            bookRequestModel.UserID = User.Identity.GetUserId();
            BookRequestService.Add(bookRequestModel);
            return RedirectToAction("Index");
        }

        public ActionResult AllBookRequest()
        {
            return View(BookRequestService.GetAll());
        }
	}
}