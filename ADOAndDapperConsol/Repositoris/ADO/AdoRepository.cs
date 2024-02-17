using ADOAndDapperConsol.Entitis;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading;

namespace ADOAndDapperConsol.Repositoris.ADO;
public class AdoRepository
{
    public List<Student> GetStudents()
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=Maktab104;";
        using (SqlConnection cn = new SqlConnection(connectionString))
        {

            try
            {
                cn.Open();
                SqlCommand command = cn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from dbo.Students";
                var reader = command.ExecuteReader();
                List<Student> students = new List<Student>();
                while (reader.Read())
                {
                    Student st = new Student()
                    {
                        Id= (int)reader["Id"],
                        FirstName= (string)reader["FirstName"],
                        LastName= (string)reader["LastName"],
                        SN= (long)reader["SN"],
                        Age = (byte)reader["Age"],
                        Email= (string?)reader["Email"],
                        IsActive = (bool?)reader["IsActive"]
                    };
                    students.Add(st);
                }
                cn.Close();
                return students;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
    
    }

    public void AddStudent(Student student)
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=Maktab104;";
        using (SqlConnection cn = new SqlConnection(connectionString))
        {
            try
            {
                cn.Open();
                string query = "INSERT dbo.Students(SN,FirstName,LastName,Age,Email,IsActive)VALUES(@SN,@FirstName,@LastName,@Age,@Email,@IsActive)";

                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    cmd.Parameters.Add("@SN", SqlDbType.BigInt).Value = student.SN;
                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = student.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = student.LastName;
                    cmd.Parameters.Add("@Age", SqlDbType.TinyInt).Value = student.Age;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = student.Email;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = student.IsActive;
                    cmd.ExecuteScalar();
                    
                }  
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                 cn.Close();
            }
        }
    }
}
