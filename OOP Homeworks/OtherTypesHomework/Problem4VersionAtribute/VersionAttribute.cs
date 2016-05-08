using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4VersionAtribute
{
    [AttributeUsage(
        AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method
        | AttributeTargets.Struct)]


    public class VersionAttribute : Attribute
    {
        private int major;

        private int[] minor;

        public VersionAttribute(int major, params int[] minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The major must be positive integer");
                }

                this.major = value;
            }
        }

        public int[] Minor
        {
            get
            {
                return this.minor;
            }

            set
            {
                foreach (var min in value)
                {
                    if (min < 0)
                    {
                        throw new ArgumentOutOfRangeException("The minor cannot be negative");
                    }
                    
                }

                this.minor = value;

            }
        }

        public override string ToString()
        {
            return string.Format("Current version: {0}.{1}", this.Major, string.Join(".", this.Minor));
        }
    }
}
