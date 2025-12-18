// See https://aka.ms/new-console-template for more information

namespace BasicOne
{

    class Program
    {
        static void Main(string[] args)
        {
            //different variables
            //placeholders

            //declare
            string name;
            string city;
            sbyte age; //varibales / methods / classes
                       //8 bit signed integer -128 -->> 127
            int pin;

            Console.WriteLine("Enter your name >>>");
            name = Console.ReadLine();

            Console.WriteLine("Enter your city >>>");
            city = Console.ReadLine();

            Console.WriteLine("Enter your age >>>");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin >>>");
            pin = Int32.Parse((Console.ReadLine()));
            //int32 && int64
            //signed imteger

            //output
            //Console.WriteLine("====================");
            //Console.WriteLine("---Your Profile Detail---");
            //Console.WriteLine("Name: "+name);
            //Console.WriteLine("City: "+city);
            //Console.WriteLine("Age: "+age);
            //Console.WriteLine("Pin: "+pin);
            //Console.WriteLine("====================\n\n");

            //output using place holders
            Console.WriteLine("---Your profile details--- \n Name: {0} \n City: {1} \nAge: {2} \nPin: {3}"
                ,name,city,age,pin);


            Console.ReadLine();//console open for output






        }

    }
}
