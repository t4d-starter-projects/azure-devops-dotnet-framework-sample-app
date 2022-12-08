using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleApp.Web.Models.DB;
using SampleApp.Web.Models.ViewModels;

namespace SampleApp.Web.Models.EntityManager
{
  public class ContactManager
  {
    public List<ContactView> All()
    {
      using (SampleAppEntities db = new SampleAppEntities())
      {
        return db.Contacts.Select(c => new ContactView() {
          Id = c.Id,
          FirstName = c.FirstName,
          LastName = c.LastName
        }).ToList();
      }
    }

    public ContactView Append(NewContactView newContact)
    {
      using (SampleAppEntities db = new SampleAppEntities())
      {
        var result = db.InsertContact(newContact.FirstName, newContact.LastName);
        return result.Select(c => new ContactView()
        {
          Id = c.Id,
          FirstName = c.FirstName,
          LastName = c.LastName
        }).Single();
      }
    }

    public void Remove(int contactId)
    {
      using (SampleAppEntities db = new SampleAppEntities())
      {
        var result = db.DeleteContact(contactId);
      }
    }
  }
}