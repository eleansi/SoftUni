namespace OOPExam20December.Core.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using Models;

    public class BlobFactory : IBlobFactory
    {
        /// <summary>
        /// Produce a blob with given name, health, damage, behavior and attack.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <param name="behavior"></param>
        /// <param name="attack"></param>
        /// <returns></returns>
        public IBlob CreateBLob(string name, int health, int damage, string behavior, string attack)
        {
            var blob = new Blob(name, health, damage, behavior, attack);
            return blob;
        }
    }
}
