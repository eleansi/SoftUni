namespace OOPExam20December.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBlob : IBehavior, IAttackable
    {
        string Name { get; }

        int Health { get; }

        int Damage { get; }
    }
}
