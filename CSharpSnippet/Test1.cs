using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSnippet
{
    public class Test1
    {
        public string Name { get; set; }

        public bool EqualsValues(object obj)
        {
            if (!(obj is Test1))
            {
                return false;
            }

            Test1 other = (Test1)obj;
            return this.Name == other.Name;
        }
    }
}
