using Genon.Interfaces.Randoms;
using System;

namespace Engine.Randoms.Number
{
    abstract class Number : IRandomVariable
    {
        public abstract String AsString();
        public abstract void Generate(Random random);
    }
}
