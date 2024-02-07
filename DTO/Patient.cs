namespace DTO
{
    public class Patient
    {

        public Patient()
        {
            this.Appointments = new List<Appointment>(); /*Aca se inicializa para que no sea nula*/
        }

        public string SocialSecurityID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public List<Appointment> Appointments { get; set; } /*Aca se declara como atributo de la clase*/

    }
}
