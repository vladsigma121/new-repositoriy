public class StudentMethod
{
    private string fullName;
    private readonly string groupNumber;
    private readonly string recordBookNumber;
    private string snils;

    public StudentMethod(string fullName, string groupNumber, string recordBookNumber, string snils)
    {
        this.fullName = fullName;
        this.groupNumber = groupNumber;
        this.recordBookNumber = recordBookNumber;
        this.snils = snils;
    }

    public string GetFullName()
    {
        return fullName;
    }

    public void SetFullName(string value)
    {
        fullName = value;
    }

    public string GetGroupNumber()
    {
        return groupNumber;
    }

    public string GetRecordBookNumber()
    {
        return recordBookNumber;
    }

    public string GetSnils()
    {
        return snils;
    }

    public string GetInformation()
    {
        return $"ФИО: {GetFullName()}, Группа: {GetGroupNumber()}, Номер зачетной книжки: {GetRecordBookNumber()}, СНИЛС: {GetSnils()}";
    }
}
