using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Contracts
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<IPersonActivity> Activities { get; set; }

        public Person()
        {
            Activities = new List<IPersonActivity>();
        }
    }

    public interface IPersonActivity
    {
        string Name { get; }
        string DoWork();
    }
}
