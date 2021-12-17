namespace AppointmentSchedule;

public class Doctor
{
    private readonly string _name;
    private readonly string _specialty;
    
    public Doctor(string name, string specialty)
    {
        _name = name;
        _specialty = specialty;
    }
    
    public string GetName()
    {
        return _name;
    }

    public string GetSpecialty()
    {
        return _specialty;
    }
    
}