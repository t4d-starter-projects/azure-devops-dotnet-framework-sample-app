using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleApp.Web.Models.EntityManager;
using SampleApp.Web.Models.ViewModels;

namespace SampleApp.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      var contactManager = new ContactManager();
      return View(contactManager.All());
    }

    [HttpPost]
    public ActionResult AppendContact(NewContactView newContact)
    {
      var contactManager = new ContactManager();
      contactManager.Append(newContact);
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteContact(int contactId)
    {
      var contactManager = new ContactManager();
      contactManager.Remove(contactId);
      return RedirectToAction("Index");
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}