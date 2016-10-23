using Genon.Interfaces.Randoms;
using System.Collections.Generic;
using System;

namespace Engine
{
    class Schema
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

        internal String SerializeAsXml()
        {
            throw new NotImplementedException();
        }
    }
}
