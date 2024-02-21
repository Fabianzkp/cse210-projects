using System;

[Serializable]
class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name)
    {
        this.value = value;
        this.targetCount = targetCount;
        currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        Console.WriteLine($"You recorded progress for the checklist goal: {name}");

        if (currentCount >= targetCount)
        {
            completed = true;
            value += 500; // Example: Bonus points when checklist is completed
            Console.WriteLine($"Congratulations! Goal {name} is completed!");
        }
    }

    public override string GetProgress()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }
}
