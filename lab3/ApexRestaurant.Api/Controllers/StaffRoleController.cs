using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SStaffRole;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("/api/v1")]
    public class StaffRoleController : ControllerBase
    {
        private readonly IStaffRoleService _StaffRoleService;
        public StaffRoleController(IStaffRoleService StaffRoleService)
        {
            _StaffRoleService = StaffRoleService;
        }


        [HttpGet]
        [Route("/staff-role/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var StaffRole = _StaffRoleService.GetById(id);
            if (StaffRole == null)
                return NotFound();
            return Ok(StaffRole);
        }


        [HttpGet]
        [Route("/staff-role/")]
        public IActionResult GetAll()
        {
            var StaffRoles = _StaffRoleService.GetAll();
            return Ok(StaffRoles);
        }


        [HttpPost]
        [Route("/staff-role/create")]
        public IActionResult Post([FromBody] StaffRole model)
        {
            _StaffRoleService.Insert(model);
            return Ok();
        }


        [HttpPut]
        [Route("/staff-role/edit")]
        public IActionResult Put([FromBody] StaffRole model)
        {
            _StaffRoleService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("/staff-role/remove")]
        public IActionResult Delete([FromBody] StaffRole model)
        {
            _StaffRoleService.Delete(model);
            return Ok();
        }
    }
}