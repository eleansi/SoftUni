namespace OOPExam20December.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    public class BlobData : IBlobData
    {
        /// <summary>
        /// Hold an information about every Blob.
        /// </summary>
        private readonly ICollection<IBlob> blops = new List<IBlob>();

        public ICollection<IBlob> Blobs 
        {
            get { return this.blops; }
            private set { }
        }

        /// <summary>
        /// Adding a Blob to the data.
        /// </summary>
        /// <param name="blob"></param>
        public void AddBlob(IBlob blob)
        {
            if (blob == null)
            {
                throw new ArgumentException("Blob cannot be created without the foll");
            }
            this.blops.Add(blob);
        }
    }
}
