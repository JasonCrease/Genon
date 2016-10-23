using Genon.Interfaces.Randoms;
using System;

namespace Engine.Randoms.Number
{
    internal abstract class Number : IRandomVariable
    {
        public abstract String AsString();
        public abstract string AsXml();
        public abstract void Generate(Random random);
        public abstract void SetFromXml();
    }
}
