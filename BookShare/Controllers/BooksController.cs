using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BookShare.Models;

namespace BookShare.Controllers
{
    public class BooksController : Controller
    {
        // GET: Book/Random
        public ActionResult Random()
        {
            var Book = new Book() { Name = "Merchent of Venice!" };
            return View(Book);
        }
    }
}