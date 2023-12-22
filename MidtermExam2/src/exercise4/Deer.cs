using MidtermExam2.exercise2;

namespace MidtermExam2.exercise4;

public class Deer : Animal
{
    private float runningSpeed;

    public Deer(int id, string name, bool isCarnivorous, float runningSpeed)
        : base(id, name, isCarnivorous, runningSpeed)
    {
    }
    
    public float Run()
    {
        Console.WriteLine($"{Name} is running with a speed of {runningSpeed}.");
        return runningSpeed;
    }
}