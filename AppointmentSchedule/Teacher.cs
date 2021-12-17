namespace AppointmentSchedule;

public class Teacher
{
    private List<string> _evaluations;
    private List<string> _goals;
    
    public Teacher()
    {
        _evaluations = new List<string>();
        _goals = new List<string>();
    }
    
    public List<string> GetEvaluations()
    {
        return _evaluations;
    }
    
    public List<string> GetGoals()
    {
        return _goals;
    }

    public void AddEvaluation(string evaluation)
    {
        _evaluations.Add(evaluation);
    }
    
    // crud evaluation
    public void UpdateEvaluation(string evaluation, string newEvaluation)
    {
        _evaluations.Remove(evaluation);
        _evaluations.Add(newEvaluation);
    }
    
    public void DeleteEvaluation(string evaluation)
    {
        _evaluations.Remove(evaluation);
    }
    
    // crud goal
    public void AddGoal(string goal)
    {
        _goals.Add(goal);
    }
    
    public void UpdateGoal(string goal, string newGoal)
    {
        _goals.Remove(goal);
        _goals.Add(newGoal);
    }
    
    public void DeleteGoal(string goal)
    {
        _goals.Remove(goal);
    }
    
    public void PrintEvaluations()
    {
        foreach (string evaluation in _evaluations)
        {
            Console.WriteLine(evaluation);
        }
    }
    public void PrintGoals()
    {
        foreach (string goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }
}