namespace heritage
{
    public class Class1
    {
        class Employee
        {
            public string Name;
            public int Age;
            public int Salary;
        }
        class ProjectManager : Employee
        {
            public string ProjectName;
        }

        class Developer: Employee
        {
            private string ProgrammingLanguage;
        }

    }
}
