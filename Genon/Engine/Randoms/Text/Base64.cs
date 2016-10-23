using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Randoms.Text
{
    class Base64 : Text
    {
        private string str;
        private static char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();

        public override String AsString()
        {
            return str;
        }

        public override void Generate(Random random)
        {
            int lengthToMake = random.Next(this.MinLength, MaxLength);
            char[] chars = new char[lengthToMake];

            for (int i = 0; i < lengthToMake; i++)
                chars[i] = letters[random.Next(64)];

            str = new string(chars);
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
