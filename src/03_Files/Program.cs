// File и FileInfo  аналогично 
// чтение и запись

using System.Text;

string metanit = @"c:\app\metanit.txt";
string path = @"c:\app\Bible10.txt";
string newPath = @"c:\app\Bible10 - копия.txt";

//string originalText = "Hello Metanit.com";
//File.Delete(metanit);
//// запись строки
//await File.WriteAllTextAsync(metanit, originalText);
//// дозапись в конец файла
//await File.AppendAllTextAsync(metanit, "\nПривет code");

//// чтение файла
//string fileText = await File.ReadAllTextAsync(metanit);
//WriteLine(fileText);

//ReadKey();

//Encoding encoding = Encoding.GetEncoding("windows-1251");

var text = await File.ReadAllLinesAsync(path);
WriteLine(text.First());
WriteLine("прочли");

File.Delete(newPath);

await File.WriteAllLinesAsync(newPath,  text);
WriteLine("записали");

ReadLine();

var bytes = await File.ReadAllBytesAsync(path);
WriteLine("прочли");

File.Delete(newPath);
await File.WriteAllBytesAsync(newPath, bytes);
WriteLine("записали");


