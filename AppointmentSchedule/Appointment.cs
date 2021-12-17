namespace AppointmentSchedule;

public class Appointment
{
    private int _id;
    private string _title;
    private Doctor _doctor;
    private Patient _patient;
    
    public Appointment(int id, string title, Doctor doctor, Patient patient)
    {
        _id = id;
        _title = title;
        _doctor = doctor;
        _patient = patient;
    }

    public Patient Patient
    {
        get => default;
        set
        {
        }
    }

    public Doctor Doctor
    {
        get => default;
        set
        {
        }
    }

    public int GetId()
    {
        return _id;
    }

    public override string ToString()
    {
        return $"{_id} {_title} {_doctor.GetName()} {_patient.GetName()}";
    }
}