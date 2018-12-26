using System;
using glm = GenericConsole.Library.Models;

namespace GenericConsole.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var g = new glm.GenericModel<string>();
            //var h = new glm.GenericModel<int>();
            //g.Hello();
            //h.Hello();
            PlayWithGeneric();

        }

        static void PlayWithGeneric()
        {
            var c1 = new glm.Client();
            var c2 = new glm.Client();
            // var clientele = new glm.Client();

            foreach (var item in glm.Client.Clients.Peoples)
            {
                Console.WriteLine("{0}\n{1}", item.Name, item.Title); //the {0}.. is place holder for the first item, new line, holder for second item

            }
        }

        static void PlayWithGenericEmployee()
        {
            var c1 = new glm.Employee<glm.Associate>();
            var c2 = new glm.Employee<glm.Trainer>();

            foreach (var item in glm.Employee<glm.Associate>.Employees.Peoples)
            {
                Console.WriteLine("{0}\n{1}", item.Name, item.Title);
            }
        }
        
    }
} 
