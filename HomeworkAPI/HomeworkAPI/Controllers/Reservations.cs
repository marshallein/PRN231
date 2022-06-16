using HomeworkAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace HomeworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Reservations : ControllerBase
    {

        private readonly HomeworkDatabaseContext _databaseContext;

        public Reservations(HomeworkDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        #region API

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetAllReservation()
        {
            List<Reservation> reservations = new List<Reservation>();
            reservations = await _databaseContext.Reservations.Include(x => x.Type).ToListAsync();

            return Ok(reservations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservationById(int id)
        {
            var reservation = await _databaseContext.Reservations.Include(x => x.Type).Where(x => x.Id == id).FirstOrDefaultAsync();

            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }


        [HttpPost]
        public async Task<IActionResult> AddReservation([FromBody] Reservation reservation)
        {

            if (reservation == null)
            {
                return BadRequest();
            }

            await _databaseContext.Reservations.AddAsync(reservation);
            await _databaseContext.SaveChangesAsync();

            return Ok(new { id = reservation.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservation(int id, [FromBody] Reservation reservation)
        {
            if (reservation.Id == id)
            {
                _databaseContext.Entry<Reservation>(reservation).State = EntityState.Modified;
            }
            try
            {
                await _databaseContext.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _databaseContext.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            _databaseContext.Reservations.Remove(reservation);
            await _databaseContext.SaveChangesAsync();

            return Ok();
        }

        #endregion

    }
}
