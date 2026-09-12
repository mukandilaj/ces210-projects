public class Job
{
    // Member variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // Constructor
    public Job()
    {
        
    }

    // Method
    public void DisplayJobInformation()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }

}
