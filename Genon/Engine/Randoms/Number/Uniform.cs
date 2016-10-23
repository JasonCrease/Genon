using System;

namespace Engine.Randoms.Number
{
    class Uniform : Number
    {
        long MinValue { get; set; }
        long MaxValue { get; set; }

        long _Value;

        bool IsLong {
            get {
                return (MaxValue > int.MaxValue || MinValue < int.MinValue);
            }
        }

        public override String AsString()
        {
            throw new NotImplementedException();
        }

        public override void Generate(Random random)
        {
            if (IsLong)
                _Value = random.Next((int)MinValue, (int)MaxValue);
            else
            {
                // From http://stackoverflow.com/questions/6651554/random-number-in-long-range-is-this-the-way. 
                // Make better solution!
                long result = random.Next((Int32)(MinValue >> 32), (Int32)(MaxValue >> 32));
                result = (result << 32);
                result = result | (long)random.Next((Int32)MinValue, (Int32)MaxValue);
                _Value = result;
            }

        }
    }
}
