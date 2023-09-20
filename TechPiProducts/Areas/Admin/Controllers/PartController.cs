using Microsoft.AspNetCore.Mvc;
using TechPi.DataAccess.Data;
using TechPi.DataAccess.Repository.IRepository;
using TechPi.Models;

namespace TechPiProducts.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public PartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Part> objPartList = _unitOfWork.Part.GetAll().ToList();//_UnitOfWork
            return View(objPartList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Part obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Part.Add(obj);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(long? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Part? partFromDb = _unitOfWork.Part.Get(u => u.Id == id);
            //Product? productFromDb1 = _db.Products.FirstOrDefault(u=>u.Id==id);
            //Product? productFromDb2 = _db.Products.Where(u=>u.Id==id).FirstOrDefault();
            if (partFromDb == null)
            {
                return NotFound();
            }
            return View(partFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Part obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Part.Add(obj);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(long? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Part? partFromDb = _unitOfWork.Part.Get(u => u.Id == id);
            if (partFromDb == null)
            {
                return NotFound();
            }
            return View(partFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(long? id)
        {
            Part? obj = _unitOfWork.Part.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Part.Remove(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
