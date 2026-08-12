public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _pointsEarned = -_points; // lose points instead of gaining them
    }

    public override bool IsComplete()
    {
        return false; // like an eternal goal, it's ongoing (e.g. "smoked a cigarette")
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }
}