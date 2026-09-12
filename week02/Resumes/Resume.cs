using System. Collections. Generic;
public class Resume
{
    // Member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Constructor
    public Resume()
    {

    }

    // Method
    public void DisplayNameAndJobs()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInformation();
        }
    }
}