namespace StudentExample.DAL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public long StudentNo { get; set; }
        public DateOnly Birthdate { get; set; }
    }
}
