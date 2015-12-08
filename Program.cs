using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
            
//using NiL.JS;            

namespace reactTest
{
    public class RestMock {
        public void Post(){
            Console.WriteLine("Rest mock post");
        }
    }
    
    public class Mocks {
        RestMock Rest = new RestMock();

    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var engine = new Jint.Engine();
               
            var code = System.IO.File.ReadAllText(@"./js/main.bundle.js");
  
            engine.SetValue("console_log", new Action<Object>(Console.WriteLine));
            engine.SetValue("__mocks__", new Mocks());
            engine.Execute(code);

            Console.Read();


        }
    }
}
