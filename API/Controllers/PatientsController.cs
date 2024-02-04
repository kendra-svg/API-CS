using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")] /*con action se refiere al nombre, por ejemplo GetPatient*/
    /*despues del https://localhost:7176/ viene el URI (uniform resoure identifier) que empieza a partir del api/*/
    [ApiController]
    public class PatientsController : ControllerBase
    {
        [HttpGet]
        public string GetPatient(int id) 
        {
            return "Datos del GET";
        }

        [HttpGet]
        public string GetAllPatient()
        {
            return "Datos del GetAllPatients";
        }

    }
}
