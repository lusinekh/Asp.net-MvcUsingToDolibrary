using Asp.netMvcUsingToDolibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.netMvcUsingToDolibrary.Controllers
{
    public class ToDoController : Controller
    {
        static int id = 0;

        public static List<ToDo> GetToDoList = new List<ToDo>();

        // GET: ToDo
        public ActionResult Index()
        {
            var ToDoItem = from e in GetToDoList
                           orderby e.ID
                           select e;

            return View(ToDoItem);
        }
        public ActionResult Completed()
        {
            var result = from e in GetToDoList
                         where e.IsDone == true
                         select e;
            return View(result);
        }
        public ActionResult Active()
        {
            var result = from e in GetToDoList
                         where e.IsDone == false
                         select e;
            return View(result);
        }
        public ActionResult GetAll()
        {
            return View(GetToDoList.ToArray());
        }

        // GET: ToDo/Details/5
        public ActionResult Details(int id)
        {
            return View(GetToDoList.Where(m => m.ID == id).FirstOrDefault());
        }

        // GET: ToDo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
        [HttpPost]

        public ActionResult Create(ToDo todo)
        {
            try
            {
                todo.ID = id;
                todo.IsDone = false;
                GetToDoList.Add(todo);
                id++;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Edit/5
        public ActionResult Edit(int id)
        {
            var item = GetToDoList.Single(m => m.ID == id);
            return View(item);
        }

        // POST: ToDo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var itm = GetToDoList.Single(m => m.ID == id);

                if (TryUpdateModel(itm))
                {

                    return RedirectToAction("Index");
                }
                // TODO: Add update logic here
                return View(itm);
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GetToDoList.Where(m => m.ID == id).FirstOrDefault());
        }

        // POST: ToDo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ToDo todo = GetToDoList.Where(m => m.ID == id).FirstOrDefault();
                GetToDoList.Remove(todo);
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
