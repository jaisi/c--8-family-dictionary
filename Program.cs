using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Krista"},
                {"age", "42"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Henry"},
                {"age", "47"}
            });

            

            foreach (var dictPair in myFamily) {
                Console.WriteLine(dictPair.Value["name"] + " is my " + dictPair.Key + " and  is " + dictPair.Value["age"] + " years old");
            }


            
        }
    }
}
