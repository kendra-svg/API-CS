using DTO;
namespace AppLogic
{
    public class PatientManager
    {

        public Patient GetPatient(string socialSecID) {

            var result = this.GetAllPatients().Where(x => x.SocialSecurityID == socialSecID).ToList();

            if (result.Count > 0)
                return result[0];
            else
                return null;

            
        }

        public List<Patient> GetAllPatients()
        {

            //Debe conectar con Acceso a Datos y traer los datos de los pacientes

            #region "Datos para probar  que despues eliminaremos"

            //1- Paciente
            //2- Al menos una cita

            Patient patient1 = new Patient();
            patient1.SocialSecurityID = "123-45-6789";
            patient1.Name = "Juan";
            patient1.LastName = "Perez";
            patient1.Email = "jperezm@gmail.com";
            patient1.BirthDate = DateTime.Parse("01/02/1980");

            List<Patient> patients = new List<Patient>();


            //********************************************
            Appointment app = new Appointment();
            app.AppointmentDate = DateTime.Parse("01/05/2024");
            app.Title = "Consulta de rutina";
            app.Specialty = "Medicina General";

            patient1.Appointments.Add(app);


            patients.Add(patient1);

            #endregion


            return patients;
        }

        public List<Appointment> GetAppointments(string socialSecID)
        {
            /*var patientSocialSec = this.GetPatient(socialSecID);*/

            List<Patient> patients = this.GetAllPatients();



            foreach (Patient p in patients) {
                if (p.SocialSecurityID == socialSecID)
                {
                    return p.Appointments;
                }

                else { 

                    return null;
                }
                
            
            } return null;

            

            
        }

    }
}
