namespace ADOAndDapperConsol.Entitis;
public class Student
{
    public int Id { get; set; }
    public long SN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public short? Age { get; set; }
    public string? Email { get; set; }
    public bool? IsActive { get; set; }
}
