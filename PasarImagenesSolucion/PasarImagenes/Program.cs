using System;
using System.IO;
using System.Threading.Tasks;

namespace PasarImagenes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\FRANCISCO RIERA\source\repos\PasarImagenesSolucion\PasarImagenes\imagenes1\";
            string path2 = @"C:\Users\FRANCISCO RIERA\source\repos\PasarImagenesSolucion\PasarImagenes\imagenes2\";

            string[] lst = Directory.GetFiles(path1);

            int a = 1;
            foreach(var archivo in lst)
            {
                File.Copy(archivo, path2 + "a" + a + ".jpg");
                a++;
                Console.WriteLine("se paso ya sin paralelo ¡¡¡¡¡¡");
            }


            Parallel.ForEach(lst, (archivo) =>
            {
                File.Copy(archivo, path2 + "a" + a + ".jpg");
                a++;
                Console.WriteLine("se paso ya con paralelo ¡¡¡¡¡¡");
            });
        }
    }
}
