using celilcavus.funi.Interfaces;
using Funi.Databases;
using Funi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Funi.Controllers;

[ApiController]
[Route("Api/[Controller]")]
public class ShopController : ControllerBase
{
    private IShop _shop;

    public ShopController(IShop shop)
    {
        _shop = shop;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var values = _shop.GetAll();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult Post(Shop shop)
    {
        _shop.Add(shop);
        _shop.Save();
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var getByValue = _shop.GetById(id);
        return Ok(getByValue);
    }
    [HttpGet("IsActive/{IsActive}")]
    public IActionResult GetIsActive(bool IsActive)
    {
        var getByValue = _shop
        .GetAll()
        .Where(x => x.IsActive == IsActive)
        .ToList();
        return Ok(getByValue);
    }

    public IActionResult Put(Shop shop)
    {
        _shop.Update(shop);
        _shop.Save();
        return NoContent();
    }
    [HttpGet("{id}")]
    public IActionResult Delete(int id)
    {
        var v = _shop.GetById(id);
        _shop.Delete(v);
        _shop.Save();
        return NoContent();
    }
}