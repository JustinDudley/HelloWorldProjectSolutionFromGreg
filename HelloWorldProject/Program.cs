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
            var avg = tot / scores.Length;
            Console.WriteLine("Average is " + avg);
            #endregion

            // looping with foreach()
            var grandTotal = 0;
            foreach(var score in scores) {
                grandTotal += score;
            }

            // floating point numbers
            var totalDistance = 0.0;
            var distances = new double[] { 5.99,  3.56, 8.99, 7.47, 8.17, 6.78, 6.33 };
            foreach(var distance in distances) {
                totalDistance += distance;
            }
            var avgDistance = totalDistance / distances.Length;

            // arrays
            int[] students = new int[5];
            students[0] = 7;
            students[1] = 3;
            students[2] = 4;
            students[3] = 15;
            students[4] = 5;

            string[] names = new string[7];
            names[0] = "Jeremy";
            names[1] = "Alex";
        }
    }
}
