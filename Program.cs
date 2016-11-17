using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name=System.Environment.MachineName;
            
            MyClass myClass=new MyClass(){
                Id=1,
                Name="zhangsan"
            };
            System.Console.WriteLine(myClass.Name);
        }
    }

    public class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
