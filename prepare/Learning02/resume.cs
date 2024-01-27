public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public Resume()
    {
        _jobs = new List<Job>();
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }
}