namespace AppointmentSchedule;

public class HumanResource
{
    private Teacher _teacher;
    
    public HumanResource(Teacher teacher)
    {
        _teacher = teacher;
    }
    
    public void AssignTeacher(Teacher teacher)
    {
        _teacher = teacher;
    }
    
    public List<string> GetEvaluation()
    {
        return _teacher.GetEvaluations();
    }
    
    public void AddEvaluation(string evaluation)
    {
        _teacher.AddEvaluation(evaluation);
    }
    
    public void UpdateEvaluation(string old, string @new)
    {
        _teacher.UpdateEvaluation(old, @new);
    }
    
    public void RemoveEvaluation(string evaluation)
    {
        _teacher.DeleteEvaluation(evaluation);
    }
    
    public void PrintEvaluations()
    {
        foreach (string evaluation in _teacher.GetEvaluations())
        {
            Console.WriteLine(evaluation);
        }
    }
}