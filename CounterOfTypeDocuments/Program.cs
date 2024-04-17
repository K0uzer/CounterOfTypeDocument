namespace RenamingDocuments;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static void Main()
    {
        FindOutThePresenceOfFolderInTheDirectory();
    }

    public static void FindOutThePresenceOfFolderInTheDirectory()
    {
        try
        {
            List<string> foldersChilderList = new List<string>() { "ЧС", "МКД" };
            //int fileCount = Directory.GetFiles(nameNewFolder).Length;
            
            //if (!Directory.Exists("nameNewFolder")) Directory.CreateDirectory(nameNewFolder);
            //else
            //{
            //    if (fileCount > 0)
            //    {
            //        string path = $"{Environment.CurrentDirectory}\\{nameNewFolder}";

            //        string[] filePaths = Directory.GetFiles($"{Environment.CurrentDirectory}\\{nameNewFolder}");
            //        foreach (string filePath in filePaths)
            //        {
                        
            //        }
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Папка пуста. Загрузите в нее данные");
            ////    }
            //}
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void WorkinkWithDocuments()
    {

    }
}
