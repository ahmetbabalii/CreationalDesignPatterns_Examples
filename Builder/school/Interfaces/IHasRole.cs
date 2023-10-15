using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.school.Interfaces
{
    public interface IHasRole
    {
        IAmTeaching AsTeacher { get; }
        IAmStudying AsStudent { get; }
    }
}
