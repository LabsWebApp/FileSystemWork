string path = "note1.txt";
string text = "Hello World\nHello METANIT.COM";

// полная перезапись файла 
await using (StreamWriter writer = new StreamWriter(path, false))
{
    await writer.WriteLineAsync(text);
}
// добавление в файл
await using (StreamWriter writer = new StreamWriter(path, true))
{
    await writer.WriteLineAsync("Addition");
    await writer.WriteAsync("4,5");
}

// асинхронное чтение
using (StreamReader reader = new StreamReader(path))
{
    text = await reader.ReadToEndAsync();
    Console.WriteLine(text);
}

WriteLine("---------");

// асинхронное чтение
using (StreamReader reader = new StreamReader(path))
{
    while (await reader.ReadLineAsync() is { } line)
    {
        Console.WriteLine(line);
    }
}