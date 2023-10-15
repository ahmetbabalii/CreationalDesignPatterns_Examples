using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.school.Dtos.Descriptors
{
    public class MemberDescriptor
    {
        public MemberDescriptor(MemberDescriptor other = null)
        {
            if (other != null)
            {
                Name = other.Name;
                Age = other.Age;
                Role = other.Role;
            }
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public MemberRole Role { get; set; }

        public virtual MemberDescriptor Clone()
        {
            return new MemberDescriptor(this);
        }
    }
}
