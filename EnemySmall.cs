using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class EnemySmall : Enemy
    {
        
        public void SmallUpdate() // BAD PRACTICE!!!
        {

        }

        public override void Update()
        {
            Console.WriteLine("EnemySmall updated");
        }
    
    }
}
