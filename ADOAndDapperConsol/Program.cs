using ADOAndDapperConsol.Entitis;
using ADOAndDapperConsol.Repositoris.ADO;


namespace ADOAndDapperConsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ADO
            AdoRepository adoRepo = new AdoRepository();
            Student st = new()
            {
                SN = 3216546946,
                FirstName = "Ali",
                LastName = "Hashemi",
                IsActive = true,
                Email = "ali.hashemi@gmail.com",
                Age = 26
            };
            adoRepo.AddStudent(st);
            var students = adoRepo.GetStudents();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} - {student.FirstName} {student.LastName} - {student.Age}");
            }
            #endregion
            #region Daper
            /*DapperRepository dapperRepo = new DapperRepository();

dapperRepo.AddStudent(st);
var students = dapperRepo.GetStudents();
foreach (var student in students)
{
    Console.WriteLine($"{student.Id} - {student.FirstName} {student.LastName} - {student.Age}");
}*/
            #endregion

        }
    }
}









