using AppLogic;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        [HttpGet]
        public List<Appointment> GetAppointments(string socialSecID) { 
            PatientManager pm = new PatientManager();

            return pm.GetAppointments(socialSecID);
        }

    }
}
