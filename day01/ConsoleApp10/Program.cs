namespace Communication
{
    class Http
    {
    }

    class Ftp
    {
    }
}

namespace Disk.FileSystem
{
    class File
    {
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Communication.Http http = new Communication.Http();
            Disk.FileSystem.File file = new Disk.FileSystem.File();
        }
    }
}