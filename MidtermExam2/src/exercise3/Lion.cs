using MidtermExam2.exercise2;

namespace MidtermExam2.exercise3;

public class Lion : Animal
{
    private float runningSpeed = 100;

    public Lion(int id, string name, bool isCarnivorous, float runningSpeed)
        : base(id, name, isCarnivorous, runningSpeed)
    {
    }

    public float Predatory()
    {
        Console.WriteLine($"{Name} dang san lung voi toc do chay: {runningSpeed}.");
        return runningSpeed;
    }

    public void Accelerator()
    {
        runningSpeed *= 1.1f;
        Console.WriteLine($"{Name} tang toc. Toc do chay moi: {runningSpeed}.");
    }

    public void Eat(string preyName)
    {
        Console.WriteLine($"{Name} dang an {preyName}.");
    }
}