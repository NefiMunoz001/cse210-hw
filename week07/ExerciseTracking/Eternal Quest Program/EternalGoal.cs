public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // No completion; always repeatable
    }

    public override bool IsComplete() => false;

    public override string Display()
    {
        return $"[∞] {base.Display()}";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}|{_description}|{_points}";
    }
}
