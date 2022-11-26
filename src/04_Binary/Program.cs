using System;
using System.Xml;

string path = "people.dat";

// массив для записи
Person[] people =
{
    new Person("Tom", 37),
    new Person("Bob", 41),
    new Person("Petja", 99),
    new Person("Masha", 18),
};

await using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
{
    // записываем в файл значение каждого свойства объекта
    foreach (Person person in people)
    {
        writer.Write(person.Name);
        writer.Write(person.Age);
    }
    WriteLine("File has been written");
}

var list = new List<Person>();
using (BinaryReader reader = new BinaryReader(File.Open("people.dat", FileMode.Open)))
{
    // пока не достигнут конец файла
    // считываем каждое значение из файла
    while (reader.PeekChar() > -1)
    {
        var name = reader.ReadString();
        var age = reader.ReadInt32();
        // по считанным данным создаем объект Person и добавляем в список
        list.Add(new Person(name, age));
    }
}
// выводим содержимое списка people на консоль
foreach (Person person in list) WriteLine(person);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString() => $"Name: {Name}  Age: {Age}";
}