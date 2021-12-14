using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //INDEX - GET
        public IActionResult Index()
        {
            IEnumerable<Product> objProductList = _unitOfWork.Product.GetAll();
            return View(objProductList);
        }

        //UPSERT - GET
        public IActionResult Upsert(int? id)
        {
            Product product = new();
            if(id == null || id == 0)
            {
                //CREATE
                return View(product);   
            }
            else
            {
                //UPDATE
            }

            return View(product);
        }
        //UPSERT - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product obj)
        {
            return View();
        }
    }
}
