class Person
{
    static public Person President;

    public string _name;

        private Person(string name)
    {
        _name = name;
    }

    static Person() // 정적 생성자
    {
        President = new Person("대통령"); // 정적 필드 초기화
    }
}