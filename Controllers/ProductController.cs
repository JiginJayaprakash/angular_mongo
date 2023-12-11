using Microsoft.AspNetCore.Mvc;
using angular_mongo.DataLayer;
using angular_mongo.Objects;

namespace angular_mongo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public JsonResult Post(string desc)
    {
        ProductData _productData = new ProductData();
        return Json(_productData.Save(desc));
    }

    [HttpGet]
    public JsonResult Get()
    {
        ProductData _productData = new ProductData();
        return Json(_productData.GetAll());
    }
}
