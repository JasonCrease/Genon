using System;

namespace Genon.Interfaces.Randoms
{
    public interface IRandomVariable
    {
        String AsString();

        void Generate(Random random);
    }
}
