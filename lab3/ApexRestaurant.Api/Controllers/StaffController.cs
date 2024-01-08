using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SStaff;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("/api/v1")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _StaffService;
        public StaffController(IStaffService StaffService)
        {
            _StaffService = StaffService;
        }


        [HttpGet]
        [Route("/staff/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var Staff = _StaffService.GetById(id);
            if (Staff == null)
                return NotFound();
            return Ok(Staff);
        }


        [HttpGet]
        [Route("/staff/")]
        public IActionResult GetAll()
        {
            var Staffs = _StaffService.GetAll();
            return Ok(Staffs);
        }


        [HttpPost]
        [Route("/staff/create")]
        public IActionResult Post([FromBody] Staff model)
        {
            _StaffService.Insert(model);
            return Ok();
        }


        [HttpPut]
        [Route("/staff/edit")]
        public IActionResult Put([FromBody] Staff model)
        {
            _StaffService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("/staff/remove")]
        public IActionResult Delete([FromBody] Staff model)
        {
            _StaffService.Delete(model);
            return Ok();
        }
    }
}