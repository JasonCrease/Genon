using System;
using System.Runtime.CompilerServices;


namespace Engine.Randoms.Number
{
    internal class Uniform : Number
    {
        public long MinValue { get; set; }
        public long MaxValue { get; set; }

        long _Value;

        bool IsLong {
            get {
                return (MaxValue > int.MaxValue || MinValue < int.MinValue);
            }
        }

        public override String AsString()
        {
            return _Value.ToString();
        }

        public override void Generate(Random random)
        {
            if (IsLong)
                throw new NotImplementedException("Cannot generate longs yet");
            else
                _Value = random.Next((int)MinValue, (int)MaxValue);

        }

        public override string AsXml()
        {
            throw new NotImplementedException();
        }

        public override void SetFromXml()
        {
            throw new NotImplementedException();
        }
    }
}
