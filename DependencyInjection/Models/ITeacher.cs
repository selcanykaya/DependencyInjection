namespace DependencyInjection.Models
{
    // Öğretmen için base interface 
    public interface ITeacher
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        public string GetInfo();
       
    }
}
