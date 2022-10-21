using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ExemploErro
{
    [Serializable]
    public class MyClassExceptionException : System.Exception
    {
        public MyClassExceptionException() 
        { 

        }
        public MyClassExceptionException(string message) : base(message) 
        { 
            
        }
        public MyClassExceptionException(string message, System.Exception inner) : base(message, inner) 
        { 

        }
        protected MyClassExceptionException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) 
            { 

            }

        public string? MyProperty {get; set;}
           
    }
    
}