using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WAD_SRMS_Project.models;
using WAD_SRMS_Project.Models;

namespace WAD_SRMS_Project.controllers
{
    public class CRUD_Operation : Controller
    {
        // GET: CRUD_Operation
        private readonly AppDbContext _Db;

        public CRUD_Operation(AppDbContext Db)
        {
            _Db = Db;
        }

        public ActionResult Index ()
        {
            var datalist = _Db.loginmodel.ToList();
            return View(datalist);
        }

        [HttpGet]
        public ActionResult Create()
            {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Login model)
        {
            _Db.loginmodel.Add(model);
            _Db.SaveChanges();
            ViewBag.Message = "Data Insert Succesfully";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _Db.loginmodel.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Login Model)
        {
            var data = _Db.loginmodel.Where(x => x.Id == Model.Id).FirstOrDefault();
            if (data != null)
            {
                data.Id = Model.Id;
                data.Email = Model.Email;
                data.Password = Model.Password;
                data.Repeat_Password = Model.Repeat_Password;
               

                _Db.SaveChanges();
            }
            return RedirectToAction("index");
        }
        public ActionResult Detail(int ID)
        {
            var data = _Db.loginmodel.Where(x => x.Id == ID).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int ID)
        {
            var data = _Db.loginmodel.Where(x => x.Id == ID).FirstOrDefault();
            _Db.loginmodel.Remove(data);
            _Db.SaveChanges();
            ViewBag.Message = "Record Deleted Succesfuly";
            return RedirectToAction("index");
        }




    }
}
