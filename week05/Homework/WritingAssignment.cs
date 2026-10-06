using System;

public class WritingAssignment : Assignment
{
    // Member variables
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Method
    public string GetWritingInformation()
    {
        // Call the getter here because _studentName is private in the base class
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}