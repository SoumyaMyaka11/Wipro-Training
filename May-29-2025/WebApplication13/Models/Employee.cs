namespace WebApplication13.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required  string FirstName { get; set; }
        public required string LastName { get; set; }
        public required  string Gender { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Department { get; set; }
        public required string Designation { get; set; }

        public double Salary { get; set; }
    }
}
