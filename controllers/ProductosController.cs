


using Microsoft.AspNetCore.Mvc;
using prueba_annar_.Net.Data;
using prueba_annar_.Net.Models;

[ApiController]
[Route("api/products")]
public class ProductosController: ControllerBase
{
    private readonly AppDbContext _context;
    public ProductosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        var listUser = _context.productos.ToList();
        return Ok(listUser);
        
    }

    [HttpPost]
    public IActionResult PostProducts(Producto nuevoProducto)
    {
        _context.productos.Add(nuevoProducto);
        _context.SaveChanges();

        return Ok();
    }

    
}