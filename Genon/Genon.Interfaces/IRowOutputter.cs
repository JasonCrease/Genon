using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genon.Interfaces
{
    public interface IRowOutputter
    {
        void WriteRow(IDataRow row);
    }
}
