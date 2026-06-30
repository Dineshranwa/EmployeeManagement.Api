namespace EmployeeManagement.Api.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public required string EmployeeCode { get; set; } = string.Empty;
        public required string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public required string PhoneNumber { get; set; } = string.Empty;
        public DateTime JoiningDate { get; set; }
        public DateTime? DateOfLeaving { get; set; }
        public string EmployementStatus { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public bool IsActive { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
