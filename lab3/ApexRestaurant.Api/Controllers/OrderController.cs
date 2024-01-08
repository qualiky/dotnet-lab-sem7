using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SOrder;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("/api/v1")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;
        public OrderController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }


        [HttpGet]
        [Route("/order/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var Order = _OrderService.GetById(id);
            if (Order == null)
                return NotFound();
            return Ok(Order);
        }


        [HttpGet]
        [Route("/order/")]
        public IActionResult GetAll()
        {
            var Orders = _OrderService.GetAll();
            return Ok(Orders);
        }


        [HttpPost]
        [Route("/order/create")]
        public IActionResult Post([FromBody] Order model)
        {
            _OrderService.Insert(model);
            return Ok();
        }


        [HttpPut]
        [Route("/order/edit")]
        public IActionResult Put([FromBody] Order model)
        {
            _OrderService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("/order/remove")]
        public IActionResult Delete([FromBody] Order model)
        {
            _OrderService.Delete(model);
            return Ok();
        }
    }
}