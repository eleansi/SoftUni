using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            FileStream getImage = new FileStream("../../image.jpg", FileMode.Open);            // getting image
            FileStream copyImage = new FileStream("../../image-copy.jpg", FileMode.Create);    // destination of copy

            using (getImage)
            {
                using (copyImage)
                {
                    byte[] buffer = new byte[8192];

                    while (true)
                    {
                        int readBytes = getImage.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        copyImage.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
