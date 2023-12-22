namespace MidtermExam2.exercise2;

public class Animal
{
    private readonly int id;
    public string Name { get; set; }
    private readonly bool isCarnivorous;
    private readonly float runningSpeed;

    public Animal(int id, string name, bool isCarnivorous, float runningSpeed)
    {
        this.id = id;
        this.Name = name;
        this.isCarnivorous = isCarnivorous;
        this.runningSpeed = runningSpeed;
    }

    public Animal()
    {
        this.id = 0;
        this.Name = "Unknown";
        this.isCarnivorous = false;
        this.runningSpeed = 0.0f;
    }
}