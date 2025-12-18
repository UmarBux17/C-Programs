using System.Xml.Serialization;

namespace SerialOne
{

    class Program {

        static void Main(string[] args) {

            List<Person> myList = new List<Person>();
            myList.AddRange(new Person[]
                {
                    new Person("John","Smith",35),
                    new Person("Sue","Ellen",45),
                    new Person("Jake","Flint",57)
                });

            //serialization -- create a new file in the directory
            string stream = File.OpenWrite(Environment.CurrentDirectory+"\\testing.txt");
            //pass it into a typeof serializer
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            xml.Serialize(stream,myList);
            stream.Close();
            Console.WriteLine("Conversion completed>>>");

            //call the readback method
            List<Person> readList = readBack();
            foreach (Person person in readList)
            {
                Console.WriteLine($"Name: {person.FirstName}{person.LastName}, ID :{person.ID}");
            }

            Console.ReadLine();
        }//main ends

        //method --> read back from the serialzed txt file
        public static List<Person> readBack()
        {
            List<Person> readList;
            FileStream fileStream = new FileStream(Environment.CurrentDirectory
                + "\\testing.txt", FileMode.Open);

            //only the serializer can read it back
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
            readList = (List<Person>)xmlSerializer.Deserialize(fileStream);
            return readList;
        }

    }//class ends

    //new class
    public class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public Person()
        {
            //default ctor
        }


        //parametized ctor
        public Person(string firstName, string lastName, int iD)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
        }

        


    }



}

