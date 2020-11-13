using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndBaseClassesExercise
{
    class Order : IEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
