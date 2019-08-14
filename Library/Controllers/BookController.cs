using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Library.Models;


namespace LibraryControllers
{

    class BookController : Controller
    {
        private readonly LibraryContext _db;

        public BookController(LibraryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var books = _db.Books.ToList();
            return View(books);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {

            var model = _db.Books
            .Include(book => book.Genres)
            .ThenInclude(join => join.Genre)
            .FirstOrDefault(book => book.BookId == id);
            //inlcudes, then include
            return View(model);
        }
    }
}