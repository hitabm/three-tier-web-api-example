namespace StudentExample.BLL.Models
{
    public class StudentUpdateModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateOnly Birthdate { get; set; }
    }
}
