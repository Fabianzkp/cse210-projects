using System;

[Serializable]
class EternalGoal : Goal
{
    public EternalGoal(string name, int value) : base(name)
    {
        this.value = value;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded progress for the eternal goal: {name}");
        value += 100; // Example: Increment value by 100 each time
    }

    public override string GetProgress()
    {
        return "[∞]";
    }
}
