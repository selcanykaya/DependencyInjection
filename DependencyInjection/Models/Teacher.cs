namespace DependencyInjection.Models
{
    // Teacher sınıfı ITeacherı implemente ediyor
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Öğretmenin adı ve soyadını döndüren metot
        public string GetInfo()
        {
            return $"Teacher name is {FirstName} {LastName}";
        }
    }
}
