string dirName = "C:\\";
// если папка существует
if (Directory.Exists(dirName))
{
    WriteLine("static Directory:");
    Console.WriteLine("Подкаталоги:");
    string[] dirs = Directory.GetDirectories(dirName);
    foreach (string s in dirs)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
    Console.WriteLine("Файлы:");
    string[] files = Directory.GetFiles(dirName);
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }
}

WriteLine("\nDirectoryInfo:");

var directory = new DirectoryInfo(dirName);

if (directory.Exists)
{
    Console.WriteLine("Подкаталоги:");
    DirectoryInfo[] dirs = directory.GetDirectories();
    foreach (DirectoryInfo dir in dirs)
    {
        Console.WriteLine(dir.FullName);
    }
    Console.WriteLine();
    Console.WriteLine("Файлы:");
    FileInfo[] files = directory.GetFiles();
    foreach (FileInfo file in files)
    {
        Console.WriteLine(file.FullName);
    }
}

ReadKey();