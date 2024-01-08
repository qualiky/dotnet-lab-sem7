using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.STable;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("/api/v1")]
    public class TableController : ControllerBase
    {
        private readonly ITableService _TableService;
        public TableController(ITableService TableService)
        {
            _TableService = TableService;
        }


        [HttpGet]
        [Route("/table/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var Table = _TableService.GetById(id);
            if (Table == null)
                return NotFound();
            return Ok(Table);
        }


        [HttpGet]
        [Route("/table/")]
        public IActionResult GetAll()
        {
            var Tables = _TableService.GetAll();
            return Ok(Tables);
        }


        [HttpPost]
        [Route("/table/create")]
        public IActionResult Post([FromBody] Table model)
        {
            _TableService.Insert(model);
            return Ok();
        }


        [HttpPut]
        [Route("/table/edit")]
        public IActionResult Put([FromBody] Table model)
        {
            _TableService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("/table/remove")]
        public IActionResult Delete([FromBody] Table model)
        {
            _TableService.Delete(model);
            return Ok();
        }
    }
}