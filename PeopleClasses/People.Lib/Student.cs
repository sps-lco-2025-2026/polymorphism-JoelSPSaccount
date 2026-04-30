namespace People.Lib;

/// <summary>
/// a derived class, which inherits from the base class 
/// </summary>
public class Student : Person
{
    public string _yeargroup { get; set; }

    public Student(string firstname, string lastname, string email, DateTime birthday, string yearGroup = null)
        : base(firstname, lastname, email, birthday)
    {
        _yeargroup = yearGroup ?? CalculateYearGroup();
    }

    private int CalculateAge(DateTime birthday)
    {
        int age = DateTime.Now.Year - birthday.Year;

        if (DateTime.Now < birthday.AddYears(age))
            age--;

        return age;
    }
    private string CalculateYearGroup()
    {
        int age = CalculateAge(_birthday);

        if (age <= 11)
            return "Primary";
        else if (age <= 16)
            return "Secondary";
        else if (age <= 18)
            return "College";
        else
            return $"University";
    }

    public override string GetName()
    {
        return $"{base.GetName()} ({_yeargroup})";
    }
}
