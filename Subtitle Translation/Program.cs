using System;
using System.IO;

namespace Subtitle_Translation {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Give source file path having correct time line (May be english)");
            Console.WriteLine("Give destination file path");

            Console.WriteLine("Enter Soure file path");
            String sourcePath = Console.ReadLine(); ;
            while(!File.Exists(sourcePath)) {
                Console.WriteLine("Please enter correct source file path");
                sourcePath = Console.ReadLine(); ;
                Console.Read();
            }
            string[] source = File.ReadAllLines(sourcePath);
            string input = "N";
            do {
                Console.WriteLine("Enter Destination file path");
                String destiPath = Console.ReadLine(); ;
                while(!File.Exists(destiPath)) {
                    Console.WriteLine("Please enter correct source file path");
                    destiPath = Console.ReadLine();
                    Console.Read();
                }
                string[] destination = File.ReadAllLines(destiPath);
                for(int i = 0; i < source.Length; i += 3) {
                    destination[i] = source[i];
                }

                File.WriteAllLines(destiPath, destination);
                Console.WriteLine("Successfully created " + destiPath);
                Console.WriteLine("Do you have another file for translation ?(Y?N)");
                input = Console.ReadLine();

            } while(input.ToUpper() == "Y");

            Console.Read();
        }
    }
}
