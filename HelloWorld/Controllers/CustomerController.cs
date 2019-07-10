using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer obj = new Customer { CustomerCode = "1001", CustomerName = "Brijesh" };
            return View("Customer", obj);
        }

        public ActionResult Enter()
        {
            return View("EnterCustomer");
        }

        public ActionResult Submit(Customer obj)
        {
            return View("Customer", obj);
        }

        public ActionResult ModalPopUp()
        {
            return View();
        }
    }

    public class customerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            string custCode = objContext.Request.Form["txtCustomerCode"];
            string custName = objContext.Request.Form["txtCustomerName"];

            Customer obj = new Customer()
            {
                CustomerCode = custCode,
                CustomerName = custName,
            };

            return obj;
        }
    }
}