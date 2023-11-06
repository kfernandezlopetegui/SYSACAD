using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ForeignKeyAtributo : Attribute
    {

        public Type ReferenceType { get; }

        public ForeignKeyAtributo(Type referenceType)
        {
            ReferenceType = referenceType;
        }
    }
}
