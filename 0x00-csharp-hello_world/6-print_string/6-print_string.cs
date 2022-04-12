using System;

class Program
{
	static void Main(string[] args)
	{
        int i = 0;
		string str = "Holberton School";
        for (i=0; i<=2;i++){
            Console.Write(str);
        }
        Console.Write("\n");
        Console.WriteLine(str.Substring(0, 9));
        }
}