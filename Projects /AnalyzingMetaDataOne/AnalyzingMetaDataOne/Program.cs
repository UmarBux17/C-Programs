using System.Reflection;

namespace analyzingMetaDataOne
{
    public class Program
    {
        //global file path
        static string path = "/Users/buxologist/Desktop/dll/CarLibrary.dll";

        static void Main(string[] args)
        {
            //create assembly object
            Assembly assembly = Assembly.LoadFile(path);
            Type[] types = assembly.GetTypes();

            foreach (var type in types)
            {
                Console.WriteLine("Type : " + type.Name);
                //method info
                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("----Method: " + method.Name);
                    //parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var param in parameters)
                    {
                        Console.WriteLine("--Parameters: " + param.Name
                            + ", Type: " + param.ParameterType);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}