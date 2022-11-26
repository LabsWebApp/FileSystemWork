// Поиск
string dirName = "C:\\";

// класс Directory
string[] dirs = Directory.GetDirectories(dirName, "*iles*");

foreach (string dir in dirs) WriteLine(dir);

// класс DirectoryInfo
var directory = new DirectoryInfo(dirName);
DirectoryInfo[] dirInfos = directory.GetDirectories("*iles*.");
foreach (DirectoryInfo dirInfo in dirInfos) WriteLine(dirInfo.Name);