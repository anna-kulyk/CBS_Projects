using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L7
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class AccessLevelAttribute : Attribute
    {
        private AccessLevelEnum _accessLevel;

        public AccessLevelAttribute(AccessLevelEnum accessLevel)
        {
            _accessLevel = accessLevel;
        }

        public AccessLevelEnum AccessLevel
        {
            get { return _accessLevel; }
        }
    }
}
