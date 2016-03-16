using MVC5Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Homework.Controllers
{
    public abstract class BaseController : Controller
    {
        protected 客戶資料Repository repo客戶資料 = RepositoryHelper.Get客戶資料Repository();        
        protected 客戶銀行資訊Repository repo客戶銀行資訊 = RepositoryHelper.Get客戶銀行資訊Repository();
        protected 客戶聯絡人Repository repo客戶聯絡人 = RepositoryHelper.Get客戶聯絡人Repository();
        protected vm客戶關聯資料統計表Repository repo客戶關聯資料統計表 = RepositoryHelper.Getvm客戶關聯資料統計表Repository();

        // GET: Base
        public ActionResult Index2()
        {
            return View();
        }

        protected override void HandleUnknownAction(string actionName)
        {
            this.Redirect("/").ExecuteResult(this.ControllerContext);

            //base.HandleUnknownAction(actionName);
        }
    }
}