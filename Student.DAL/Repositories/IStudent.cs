namespace StudentExample.DAL.Repositories
{
    // CRUD: Create, Read, Update, Delete
    public interface IStudent
    {
        public Task<Models.Student?> Create(Models.Student? student);
        public void Delete(Models.Student? student);

        public void Update(Models.Student? student);

        public IEnumerable<Models.Student> GetAll();

        public Models.Student? GetById(int Id);

    }
}
