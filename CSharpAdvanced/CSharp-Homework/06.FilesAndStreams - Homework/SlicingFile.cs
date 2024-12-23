using System;
using System.Collections.Generic;
using System.IO;

class SlicingFile
{
    static void Main()
    {
        //Slice("../../solid.avi", "../../part-", 5);
        List<string> destinations = new List<string>();
        for (int i = 1; i <= 5; i++)
        {
            destinations.Add("../../part-" + i + ".avi");
        }
        Assemble(destinations, "../../decompressed.avi");
    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        FileStream source = new FileStream(sourceFile, FileMode.Open);
        List<FileStream> destination = new List<FileStream>();

        for (int i = 0; i < parts; i++)
        {
            destination.Add(new FileStream(destinationDirectory + (i + 1) + ".avi", FileMode.Create));
            byte[] buffer = new byte[source.Length / parts];
            int readBytes = source.Read(buffer, 0, buffer.Length);
            destination[i].Write(buffer, 0, readBytes);
        }
    }

    static void Assemble(List<string> files, string destinationDirectory)
    {
        FileStream destination = new FileStream(destinationDirectory, FileMode.Create);
        List<FileStream> sources = new List<FileStream>();

        for (int i = 0; i < files.Count; i++)
        {
            sources.Add(new FileStream(files[i], FileMode.Open));
            byte[] buffer = new byte[files[i].Length];
            int readBytes = sources[i].Read(buffer, 0, buffer.Length);
            destination.Write(buffer, 0, readBytes);
        }
    }
}