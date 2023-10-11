public class Computer
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown() { }
    public void Reset() { }
}

public class Notebook : Computer
{
    bool fingerScan; // Notebook 타입에 해당하는 멤버만 추가
    public bool HasFingerScanDevice() { return fingerScan; }
}

public class Desktop : Computer
{
}

public class Netbook : Computer
{
    bool fingerScan;
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if(powerOn == true)
        {
            Shutdown();
        }
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook noteBook = new Notebook();
            noteBook.Boot(); // Notebook 인스턴스에 대해 부모의 메서드 호출
        }
    }
}