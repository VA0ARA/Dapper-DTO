using ADOAndDapperConsol.Entitis;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Threading;

namespace ADOAndDapperConsol.Repositoris.ADO;
public class DapperRepository
{
    public List<Student> GetStudents()
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=Maktab104;";
        using var cn = new SqlConnection(connectionString);
        var sql = $"Select * from dbo.Students";
        var cmd = new CommandDefinition(sql);
        var result = cn.Query<Student>(cmd);
        return result.ToList();
    }
    public void AddStudent(Student student)
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=Maktab104;";
       
        string sql = "INSERT dbo.Students(SN,FirstName,LastName,Age,Email,IsActive)VALUES(@SN,@FirstName,@LastName,@Age,@Email,@IsActive)";
        using var cn = new SqlConnection(connectionString);
        var command = new CommandDefinition(sql, student);
        cn.Execute(command);
    }
}
