namespace AppointmentSchedule;

public class Calendar
{
    private List<Appointment> _appointments;
    
    public Calendar()
    {
        _appointments = new List<Appointment>();
    }

    public Appointment Appointment
    {
        get => default;
        set
        {
        }
    }

    public void AddAppointment(string title, Doctor doctor, Patient patient)
    {
        _appointments.Add(new Appointment(_appointments.Count + 1, title, doctor, patient));
    }
    
    public void RemoveAppointment(int id)
    {
        _appointments.Remove(_appointments.Find(x => x.GetId() == id));
    }
    
    public void EditAppointment(Appointment appointment)
    {
        _appointments.Remove(appointment);
        _appointments.Add(appointment);
    }
    
    public List<Appointment> GetAppointments()
    {
        return _appointments;
    }
    
    public Appointment GetAppointment(int id)
    {
        return _appointments.Find(x => x.GetId() == id);
    }
    
    public void PrintAppointments()
    {
        foreach (Appointment appointment in _appointments)
        {
            Console.WriteLine(appointment.ToString());
        }
    }
}