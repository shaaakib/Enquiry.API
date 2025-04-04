namespace Enquiry.API.Models
{
    public class EmployeeViewModel
    {
        public int employeeId { get; set; }
        public string name { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public string projectName { get; set; }
        public string city { get; set; }
        public string address { get; set; }

        public List<EmployeeFamily> employeeFamilies { get; set; }
    }
}
