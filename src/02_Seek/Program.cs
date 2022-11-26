using System.Text;

string path = "note.dat";

string text = "hello world";

await using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
{
    // преобразуем строку в байты
    byte[] input = Encoding.Default.GetBytes(text);
    // запись массива байтов в файл
    fstream.Write(input, 0, input.Length);
    Console.WriteLine("Текст записан в файл");
}
// чтение части файла
await using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
{
    // перемещаем указатель в конец файла, до конца файла- пять байт
    fstream.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока

    // считываем четыре символов с текущей позиции
    byte[] output = new byte[5];
    await fstream.ReadAsync(output, 0, output.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(output);
    Console.WriteLine($"Текст из файла: {textFromFile}"); // world
}

Console.ReadKey();

string path2 = "note2.dat";

string text2 = "hello world";

// запись в файл
using (FileStream fstream = new FileStream(path2, FileMode.OpenOrCreate))
{
    // преобразуем строку в байты
    byte[] input = Encoding.Default.GetBytes(text2);
    // запись массива байтов в файл
    fstream.Write(input, 0, input.Length);
    Console.WriteLine("Текст записан в файл");
}
using (FileStream fstream = new FileStream(path2, FileMode.OpenOrCreate))
{
    // заменим в файле слово world на слово house
    string replaceText = "house";
    fstream.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока
    byte[] input = Encoding.Default.GetBytes(replaceText);
    await fstream.WriteAsync(input, 0, input.Length);

    // считываем весь файл
    // возвращаем указатель в начало файла
    fstream.Seek(0, SeekOrigin.Begin);
    byte[] output = new byte[fstream.Length];
    await fstream.ReadAsync(output, 0, output.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(output);
    Console.WriteLine($"Текст из файла: {textFromFile}"); // hello house
}