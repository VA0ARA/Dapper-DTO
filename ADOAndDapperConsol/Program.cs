using ADOAndDapperConsol.Entitis;
using ADOAndDapperConsol.Repositoris.ADO;


namespace ADOAndDapperConsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ADO
            //AdoRepository adoRepo = new AdoRepository();
            //Student st = new()
            //{
            //    Id = 1,
            //    SN = 3216546946,
            //    FirstName = "Ali",
            //    LastName = "Hashemi",
            //    IsActive = true,
            //    Email = "ali.hashemi@gmail.com",
            //    Age = 26
            //};
            //adoRepo.AddStudent(st);
            //var students = adoRepo.GetStudents();
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"{student.Id} - {student.FirstName} {student.LastName} - {student.Age}");
            //}
            #endregion
            #region Daper
            DapperRepository dapperRepo = new DapperRepository();
            /*            Student st = new()
                        {
                            Id = 2,
                            SN = 3216546946,
                            FirstName = "Ali2",
                            LastName = "Hashemi2",
                            IsActive = true,
                            Email = "ali.hashemi@gmail.com2",
                            Age = 26
                        };

                        dapperRepo.AddStudent(st);*/
            var students = dapperRepo.GetStudents();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} - {student.FirstName} {student.LastName} - {student.Age}");
            }
            #endregion
        }
    }
}









