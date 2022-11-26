const string path = @"C:\SomeDir";
const string newPath = @"C:\SomeFolder";
const string subpath = @"program\avalon";

//DirectoryInfo dirInfo = new DirectoryInfo(path);
//if (!dirInfo.Exists) dirInfo.Create();
//dirInfo.CreateSubdirectory(subpath);

if (!Directory.Exists(path)) Directory.CreateDirectory(path);
Directory.CreateDirectory(Path.Combine(path, subpath));
WriteLine("Каталог создан");
ReadKey();

DirectoryInfo dirInfo = new DirectoryInfo(path);

if (dirInfo.Exists && !Directory.Exists(newPath))
{
    dirInfo.MoveTo(newPath);
    // или так
    // Directory.Move(oldPath, newPath);
    WriteLine("Каталог перемещён");
}


ReadKey();

if (dirInfo.Exists)
{
    dirInfo.Delete(true);
    WriteLine("Каталог удален");
}
else
{
    WriteLine("Каталог не существует");
}

if (Directory.Exists(newPath))
{
    Directory.Delete(newPath, true);
    WriteLine("Каталог удален");
}
else
{
    WriteLine("Каталог не существует");
}

ReadKey();