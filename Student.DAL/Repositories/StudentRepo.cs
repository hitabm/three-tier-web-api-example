using StudentExample.DAL.Data;

namespace StudentExample.DAL.Repositories
{
    // CRUD: Create, Read, Update, Delete
    public class StudentRepo(AppDbContext appDbContext) : IStudent
    {
        private readonly AppDbContext _appDbContext = appDbContext;

        public async Task<Models.Student?> Create(Models.Student? student)
        {
            try
            {
                if (student != null)
                {
                    var _student = _appDbContext.Students.Add(student);
                    await _appDbContext.SaveChangesAsync();
                    return _student.Entity;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }

        public void Delete(Models.Student? student)
        {
            try
            {
                if (student != null)
                {
                    var _student = _appDbContext.Students.Remove(student);
                    if (_student != null)
                    {
                        _appDbContext.SaveChangesAsync();
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Models.Student> GetAll()
        {
            try
            {
                var _students = _appDbContext.Students.ToList();
                if (_students != null)
                {
                    return _students;
                }
                else
                {
                    return Enumerable.Empty<Models.Student>();
                    //return [];
                }
            }
            catch
            {
                throw;
            }
        }

        public Models.Student? GetById(int Id)
        {
            try
            {
                var _student = _appDbContext.Students.FirstOrDefault(x => x.Id == Id);
                if (_student != null)
                {
                    return _student;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw;
            }
        }

        public void Update(Models.Student? student)
        {
            try
            {
                if (student != null)
                {
                    var _student = _appDbContext.Update(student);
                    if (_student != null)
                    {
                        _appDbContext.SaveChangesAsync();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
