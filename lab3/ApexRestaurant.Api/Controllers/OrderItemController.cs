using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SOrderItem;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("/api/v1")]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _OrderItemService;
        public OrderItemController(IOrderItemService OrderItemService)
        {
            _OrderItemService = OrderItemService;
        }


        [HttpGet]
        [Route("/order-item/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var OrderItem = _OrderItemService.GetById(id);
            if (OrderItem == null)
                return NotFound();
            return Ok(OrderItem);
        }


        [HttpGet]
        [Route("/order-item/")]
        public IActionResult GetAll()
        {
            var OrderItems = _OrderItemService.GetAll();
            return Ok(OrderItems);
        }


        [HttpPost]
        [Route("/order-item/create")]
        public IActionResult Post([FromBody] OrderItem model)
        {
            _OrderItemService.Insert(model);
            return Ok();
        }


        [HttpPut]
        [Route("/order-item/edit")]
        public IActionResult Put([FromBody] OrderItem model)
        {
            _OrderItemService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("/order-item/remove")]
        public IActionResult Delete([FromBody] OrderItem model)
        {
            _OrderItemService.Delete(model);
            return Ok();
        }
    }
}