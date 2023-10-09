class Person
{
    static public int CountOfInstance;
    public string _name;

    public Person(string name)
    {
        CountOfInstance++;
        _name = name;
    }   
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Person.CountOfInstance); // 출력 결과 : 0
        Person person1 = new Person("김현수");
        Person person2 = new Person("김현수");
        Console.WriteLine(Person.CountOfInstance); // 출력 결과 : 2
    }
}