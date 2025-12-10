public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(
        string name, string description, int points,
        int bonusPoints, int targetCount, int currentCount = 0)
        : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = currentCount;
    }

    public override void RecordEvent()
    {
        _currentCount++;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string Display()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {base.Display()} -- Completed {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonusPoints}|{_targetCount}|{_currentCount}";
    }

    public int GetBonus() => _bonusPoints;
    public int GetCount() => _currentCount;
}
