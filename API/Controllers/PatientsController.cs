using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AppLogic;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")] /*con action se refiere al nombre, por ejemplo GetPatient*/
    /*despues del https://localhost:7176/ viene el URI (uniform resoure identifier) que empieza a partir del api/*/
    [ApiController]
    public class PatientsController : ControllerBase
    {
        [HttpGet]
        public Patient GetPatient(string socialSecId) 
        {
            PatientManager pm = new PatientManager();
            return pm.GetPatient(socialSecId);
        }

        [HttpGet]
        public List<Patient> GetAllPatient()
        {
            /*List<Patient> patients = new List<Patient>();
            Patient p = new Patient();

            /*List<Appointment> app = new List<Appointment>(); /*Esta es otra opcion de iniciar la lista 1/2*/

            /*p.Appointments = app; /*Esta es otra opcion de iniciar la lista 2/2*/

           /* patients.Add(p); /*Lineas anteriores se comentarion porque ahora se usa PatientManager*/

            PatientManager pm = new PatientManager();

            return pm.GetAllPatients();
        }

    }
}
