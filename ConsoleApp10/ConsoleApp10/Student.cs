public class Student
{
    private string fullName;
    private readonly string groupNumber;
    private readonly string recordBookNumber;

    public string Snils { get; private set; }

    public Student(string fullName, string groupNumber, string recordBookNumber, string snils)
    {
        this.fullName = fullName;
        this.groupNumber = groupNumber;
        this.recordBookNumber = recordBookNumber;
        this.Snils = snils;
    }

    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public string Information
    {
        get
        {
            return $"ФИО: {FullName}, Группа: {groupNumber}, Номер зачетной книжки: {recordBookNumber}, СНИЛС: {Snils}";
        }
    }
}