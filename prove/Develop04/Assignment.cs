using System;

namespace MathsApp
{
    public class Assignment
    {
        private string _studentName;
        private string _topic;

        // Constructor
        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        // Method to get summary
        public string GetSummary()
        {
            return $"Student: {_studentName}, Topic: {_topic}";
        }

        // Method to get student name
        public string GetStudentName()
        {
            return _studentName;
        }
    }
}
