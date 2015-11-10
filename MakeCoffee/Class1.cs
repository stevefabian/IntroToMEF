using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Contracts;

namespace MakeCoffee
{
    [Export(typeof(IPersonActivity))]
    public class Class1 : IPersonActivity
    {
        public string Name => "MakeCoffee";

        public string DoWork()
        {
            return "My Plugin makes a Damn fine cup of Coffee!!!";
        }
    }
}
