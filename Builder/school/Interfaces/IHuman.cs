using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.school.Interfaces
{
    public interface IHuman
    {
        IHaveAgeAndCanHaveName WithAge(int age);
        IHaveNameAndCanHaveAge WithName(string name);
    }
}
