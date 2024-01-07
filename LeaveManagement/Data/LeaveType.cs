using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Data
{
    public class LeaveType :BaseEntity
    {
       
        public string Name { get; set; }
        //[Display(Name = "Defaul Number of Days")]
        public int DefaultDays { get; set; }

       
    }
}
