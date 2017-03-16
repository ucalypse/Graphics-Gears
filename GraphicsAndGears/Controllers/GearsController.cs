using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace GraphicsAndGears.Controllers
{
    public class GearsController : Controller
    {
        
        // GET: Gears
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
       
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult PartsRequest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult SendEmail(string nameField, string makeField, string modelField, string yearField, string phoneField, string emailField)
        {
            var car = new Car();
            var customer = new Customer();

            car.Make = makeField;
            car.Model = modelField;
            car.Year = Int32.Parse(yearField);
            customer.Name = nameField;
            customer.Email = emailField;
            customer.Phone = phoneField;
            
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            message.From = new System.Net.Mail.MailAddress("ddavis70@lycos.com");
            message.To.Add(new System.Net.Mail.MailAddress("davis199994@yahoo.com"));

            message.IsBodyHtml = true;
            message.BodyEncoding = Encoding.UTF8;
            message.Subject = "Test";
            message.Body = car.Make + " " + car.Model + " " + car.Year + "\n" + customer.Name + " " + customer.Email +
                           " " + customer.Phone;

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            
            client.Send(message);
            return RedirectToAction("Success");
          //  throw new Exception("Method not implemented");
        }
        // GET: Gears/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gears/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gears/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gears/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
