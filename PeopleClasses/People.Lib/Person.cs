namespace People.Lib;
//person base class
public class Person
{
    string _firstname { get; set; }
    string _lastname { get; set; }
    string _email { get; set; }
    DateTime _birthday;
    
    public Person(string firstName, string lastName)
    {
        _firstname = firstName;
        _lastname = lastName;
    }

    public virtual string GetName()
    {
        return $"{FirstName}.{LastName}";
    }
    public virtual void Method1()
    {
        Console.WriteLine("Base - Method1");
    }
}
