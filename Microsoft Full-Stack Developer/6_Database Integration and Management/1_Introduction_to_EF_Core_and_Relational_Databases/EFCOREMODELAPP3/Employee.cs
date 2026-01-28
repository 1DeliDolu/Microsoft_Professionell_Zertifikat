namespace EFCOREMODELAPP3
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public DateTime HireDate { get; set; }

        public string DepartmentID { get; set; }

        public Department Department { get; set; }
        public decimal Salary { get; set; }
    }
}