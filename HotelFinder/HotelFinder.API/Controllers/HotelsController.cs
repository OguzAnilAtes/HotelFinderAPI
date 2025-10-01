using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        /// <summary>
        /// Get all hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var hotels = await _hotelService.GetAllHotels();
            return Ok(hotels); //200 + data
        }

        /// <summary>
        /// Get hotel by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")] //api/hotels/gethotelbyid/2
        public async Task<IActionResult> GetHotelById(int id)
        {
            var hotel = await _hotelService.GetHotelById(id);
            if (hotel != null)
            {
                return Ok(hotel); //200 + data
            }
            return NotFound(); //404
        }
        /// <summary>
        /// Get hotel by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{name}")] //api/hotels/gethotelbyname/Titanic
        public async Task<IActionResult> GetHotelByName(string name)
        {
            var hotel = await _hotelService.GetHotelByName(name);
            if (hotel != null)
            {
                return Ok(hotel); //200 + data
            }
            return NotFound(); //404
        }

        [HttpGet]
        [Route("[action]")] //api/hotels/gethotelbyidandname?id=1&name=Titanic  --query string example
        public IActionResult GetHotelByIdAndName(int id, string name)
        {
            return Ok();
        }

        /// <summary>
        /// Create a new hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")] //api/hotels/createhotel
        public async Task<IActionResult> CreateHotel([FromBody] Hotel hotel)
        {
            var createdHotel = await _hotelService.CreateHotel(hotel);
            return CreatedAtAction("Get", new { id = createdHotel.Id }, createdHotel); //201 + data
        }

        /// <summary>
        /// Update an existing hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")] //api/hotels/updatehotel
        public async Task<IActionResult> UpdateHotel([FromBody] Hotel hotel)
        {
            if (await _hotelService.GetHotelById(hotel.Id) != null)
            {
                var updatedHotel = await _hotelService.UpdateHotel(hotel);
                return Ok(updatedHotel); //200 + data
            }
            return NotFound(); //404
        }

        /// <summary>
        /// Delete a hotel by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")] //api/hotels/deletehotel/2
        public async Task<IActionResult> DeleteHotel(int id)
        {
            if (await _hotelService.GetHotelById(id) != null)
            {
                await _hotelService.DeleteHotel(id);
                return Ok(); //200
            }
            return NotFound(); //404
        }
    }
}
