namespace EFCOREMODELAPP3
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; } = null!;
    }
}
