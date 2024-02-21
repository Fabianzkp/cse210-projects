using System;

[Serializable]
abstract class Goal
{
    protected string name;
    protected bool completed;
    protected int value;

    public Goal(string name)
    {
        this.name = name;
        completed = false;
        value = 0;
    }

    public abstract void RecordEvent();

    public abstract string GetProgress();

    public void MarkComplete()
    {
        completed = true;
    }

    public int GetValue()
    {
        return value;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public string GetName()
    {
        return name;
    }
}
