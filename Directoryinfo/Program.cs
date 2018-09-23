using System;
using System.IO;

namespace Directoryinfo
{
    public class Program
    {
        public static void Main()
        {
            string miDirectorio = @"c:\";
            DirectoryInfo dir = new DirectoryInfo(miDirectorio);
            FileInfo[] infoFicheros = dir.GetFiles();
            foreach (FileInfo InfoUnFich in infoFicheros)
            {

                Console.WriteLine("{0},de tamaño {1}, creado{2}",InfoUnFich.Name,InfoUnFich.Length,InfoUnFich.CreationTime);
                Console.ReadKey();



            }
        }
    }
}
