using Genon.Interfaces.Randoms;
using System.Collections.Generic;

namespace Engine
{
    abstract class Schema
    {
        IList<IRandomVariable> _fields;

        public IList<IRandomVariable> Fields
        {
            get { return _fields; }
        }

        public IRandomVariable GetField(int fieldNum)
        {
            return _fields[fieldNum];
        }
    }
}
