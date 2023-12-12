using Microsoft.AspNetCore.Mvc;
using webapiproj.DataLayer;
using webapiproj.Objects;
using Microsoft.Extensions.Configuration;

namespace webapiproj.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    ProductData _productData ;
    private readonly IConfiguration _configuration;

    public ProductController(IConfiguration configuration)
    {
        _configuration = configuration;
        _productData = new ProductData(_configuration.GetValue<string>("Data:DefaultConnection:ConnectionString"));
    }

    [HttpGet(Name = "GetProduct")]
    public IEnumerable<Product> Get()
    {
        return _productData.GetAll();
    }

    [HttpPost(Name = "SaveProduct")]
    public bool Save(Product data)
    {
        return _productData.Save(data.description);
    }
}
