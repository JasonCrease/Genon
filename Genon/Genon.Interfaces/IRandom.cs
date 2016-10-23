using System;

namespace Genon.Interfaces.Randoms
{
    public interface IRandomVariable
    {
        String AsString();

        // This is necessary for XML Serialization when saving the file. This should contain all data necessary to serialize the file
        String AsXml();

        // From this XML resprentation, create yourself
        void SetFromXml();

        void Generate(Random random);
    }
}
