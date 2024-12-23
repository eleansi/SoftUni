using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam20December.Interfaces
{
    public interface IBlobData
    {
        ICollection<IBlob> Blobs { get; }

        void AddBlob(IBlob blob);
    }
}
