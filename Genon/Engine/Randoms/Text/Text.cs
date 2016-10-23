using Genon.Interfaces.Randoms;
using System;

namespace Engine.Randoms.Text
{
    abstract class Text : IRandomVariable
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public abstract String AsString();
        public abstract void Generate(Random random);
    }
}
