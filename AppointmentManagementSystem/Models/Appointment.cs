namespace AppointmentManagementSystem.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Date { get; set; }
    }
}
