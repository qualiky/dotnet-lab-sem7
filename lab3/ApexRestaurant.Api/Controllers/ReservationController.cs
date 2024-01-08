using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SReservation;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("/api/v1")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _ReservationService;
        public ReservationController(IReservationService ReservationService)
        {
            _ReservationService = ReservationService;
        }


        [HttpGet]
        [Route("/reservation/{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var Reservation = _ReservationService.GetById(id);
            if (Reservation == null)
                return NotFound();
            return Ok(Reservation);
        }


        [HttpGet]
        [Route("/reservation/")]
        public IActionResult GetAll()
        {
            var Reservations = _ReservationService.GetAll();
            return Ok(Reservations);
        }


        [HttpPost]
        [Route("/reservation/create")]
        public IActionResult Post([FromBody] Reservation model)
        {
            _ReservationService.Insert(model);
            return Ok();
        }


        [HttpPut]
        [Route("/reservation/edit")]
        public IActionResult Put([FromBody] Reservation model)
        {
            _ReservationService.Update(model);
            return Ok();
        }


        [HttpDelete]
        [Route("/reservation/remove")]
        public IActionResult Delete([FromBody] Reservation model)
        {
            _ReservationService.Delete(model);
            return Ok();
        }
    }
}