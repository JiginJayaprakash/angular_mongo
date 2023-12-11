using Microsoft.AspNetCore.Mvc;
using webapiproj.DataLayer;
using webapiproj.Objects;

namespace webapiproj.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet(Name = "GetProduct")]
    public IEnumerable<Product> Get()
    {
        ProductData _productData = new ProductData();
        return Json(_productData.GetAll());
    }
}
