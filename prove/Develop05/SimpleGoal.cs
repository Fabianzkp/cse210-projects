using System;

[Serializable]
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        this.value = value;
    }

    public override void RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            Console.WriteLine($"You completed the goal: {name}!");
        }
        else
        {
            Console.WriteLine($"Goal {name} is already completed.");
        }
    }

    public override string GetProgress()
    {
        return completed ? "[X]" : "[ ]";
    }
}
