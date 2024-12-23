namespace OOPExam20December.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBlobFactory
    {
        IBlob CreateBLob(string name, int health, int damage, string behavior, string attack);
    }
}
