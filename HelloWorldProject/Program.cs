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
            //int i = 1;
            //int j = 0;
            //int k = i / j;
            string instructor = "";
            instructor = "Greg";
            Console.WriteLine(instructor);
            string lastname = "Doud"; // my lastname
            Console.WriteLine(instructor + " " + lastname);
            // looping with while
            var ints = new int[] { 1, 2, 3, 4, 5 };
            var total = 0;
            var index = 0;
            while(index < 5) {
                total = total + (ints[index] * ints[index]);
                index = index + 1;
            }
            Console.WriteLine("Value is " + total);
            // looping with for()
            total = 0;
            for(var idx = 0; idx < 5; idx = idx + 1) {
                total = total + (ints[idx] * ints[idx]);
            }
            Console.WriteLine("Value is " + total);


            var scores = new int[] { 738, 609, 307, 959, 805, 689, 402, 972, 359, 140 };
            #region assignment compute the average
            var tot = 0;
            for(var idx = 0; idx < scores.Length; idx++) {
                tot = tot + scores[idx];
            }
            var avg = tot / scores.Length ;
            Console.WriteLine("Average is " + avg);
            #endregion

            // looping with foreach()
            var grandTotal = 0;
            foreach(var score in scores) {
                grandTotal += score;
            }
        }
    }
}
