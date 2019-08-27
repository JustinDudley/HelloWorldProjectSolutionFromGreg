using System;

namespace HelloWorldProject {

    class Program { 

        static void Main(string[] args) {
            Console.Write("Hello C# Boot Camp World!");
            Console.WriteLine("At MAX Technical Training");
            int daysInBootcamp = 6;
            if(daysInBootcamp == 6) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
            string instructor = "";
            instructor = "Greg";
            Console.WriteLine(instructor);
            string lastname = "Doud"; // my lastname
            Console.WriteLine(instructor + " " + lastname);
        }
    }
}
