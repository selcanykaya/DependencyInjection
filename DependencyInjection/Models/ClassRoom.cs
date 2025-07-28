namespace DependencyInjection.Models
{
    // ClassRoom sınıfı, içine IOgretmen türünde nesne alıyor -dependency injection
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
}
