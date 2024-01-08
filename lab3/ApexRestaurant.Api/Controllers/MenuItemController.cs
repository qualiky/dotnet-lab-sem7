using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenuItem;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("/api/v1")]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _MenuItemService;
        public MenuItemController(IMenuItemService MenuItemService)
        {
            _MenuItemService = MenuItemService;
        }


        [HttpGet]
        [Route("/menu-item/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var MenuItem = _MenuItemService.GetById(id);
            if (MenuItem == null)
                return NotFound();
            return Ok(MenuItem);
        }


        [HttpGet]
        [Route("/menu-item/")]
        public IActionResult GetAll()
        {
            var MenuItems = _MenuItemService.GetAll();
            return Ok(MenuItems);
        }


        [HttpPost]
        [Route("/menu-item/create")]
        public IActionResult Post([FromBody] MenuItem model)
        {
            _MenuItemService.Insert(model);
            return Ok();
        }


        [HttpPut]
        [Route("/menu-item/edit")]
        public IActionResult Put([FromBody] MenuItem model)
        {
            _MenuItemService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("/menu-item/remove")]
        public IActionResult Delete([FromBody] MenuItem model)
        {
            _MenuItemService.Delete(model);
            return Ok();
        }
    }
}