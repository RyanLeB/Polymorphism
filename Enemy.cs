using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal abstract class Enemy
    {
        public virtual void Update() // what is virtual ???
        {
            Console.WriteLine("Enemy updated...");
        }
    
    }

}
