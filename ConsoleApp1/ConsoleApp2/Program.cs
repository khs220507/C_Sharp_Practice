int n = 5;
if(n is string) // 컴파일 오류 발생
{
    Console.WriteLine("변수 n은 string 타입");
}

string txt = "text";
if (txt is int)// 컴파일 오류 발생
{
    Console.WriteLine("변수 txt는 int 타입");
}