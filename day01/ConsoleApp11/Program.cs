using Communication;
using Disk.FileSystem;
using File = Disk.FileSystem.File;

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
            Http http = new Http();
            File file = new File();
        }
    }
}