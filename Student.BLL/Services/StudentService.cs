using StudentExample.BLL.Models;
using StudentExample.DAL.Models;
using StudentExample.DAL.Repositories;

namespace StudentExample.BLL.Services
{
    public class StudentService(IStudent student)
    {
        public readonly IStudent _student = student;

        // previously constructor was defined separately like below
        /*
        public StudentService(IStudent student)
        {
            _student = student;
        }
        */

        public async Task<Student?> AddStudent(StudentAddModel? student)
        {
            try
            {
                if (student == null)
                {
                    throw new ArgumentNullException(nameof(student));
                }
                else
                {
                    var random = new Random();
                    var newStudent = new Student
                    {
                        Birthdate = student.Birthdate,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        StudentNo = student.StudentNo,
                        Id = random.Next(0, 100),
                    };
                    return await _student.Create(newStudent);
                }
            }
            catch
            {
                throw;
            }
        }

        public void DeleteStudent(int id)
        {
            try
            {
                if (id > 0)
                {
                    var student = _student.GetById(id);
                    if (student != null)
                    {
                        _student.Delete(student);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public void UpdateStudent(Student? student)
        {
            try
            {
                if (student != null)
                {
                    _student.Update(student);
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Student> GetStudents()
        {
            try
            {
                return _student.GetAll().ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
