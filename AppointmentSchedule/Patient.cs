namespace AppointmentSchedule;

public class Patient
{
    private readonly string _name;
    
    public Patient(string name)
    {
        _name = name;
    }
    
    public string GetName()
    {
        return _name;
    }
}