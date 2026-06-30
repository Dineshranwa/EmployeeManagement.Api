namespace EmployeeManagement.Api.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime DateOfLeaving { get; set; }
        public string EmployementStatus { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
