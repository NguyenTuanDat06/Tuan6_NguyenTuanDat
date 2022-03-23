using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tuan4_NguyenTuanDat.Models;
using PagedList;
namespace Tuan4_NguyenTuanDat.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DataClasses1DataContext data = new DataClasses1DataContext();
        public ActionResult Index(int ? page)
        {
            if (page == null) page = 1;
            var all_sach = (from s in data.Saches select s).OrderBy(m=>m.masach);
            int pageSize = 2;
            int pageNum = page ?? 2;   
            return View(all_sach.ToPagedList(pageNum,pageSize));
        }
    }
}