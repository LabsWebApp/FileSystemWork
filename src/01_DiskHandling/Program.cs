DriveInfo[] drives = DriveInfo.GetDrives();

foreach (DriveInfo drive in drives)
{
    WriteLine($"Название: {drive.Name}");
    WriteLine($"Тип: {drive.DriveType}");
    if (drive.IsReady)
    {
        WriteLine($"Объем диска: {drive.TotalSize}");
        WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
        WriteLine($"Метка диска: {drive.VolumeLabel}");
        WriteLine($"Корневой каталог: {drive.RootDirectory}");
    }
    WriteLine();
}

ReadKey();