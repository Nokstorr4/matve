using System;
using System.Net.Http;


private static void ShowFileStructure()
{
Console.WriteLine("\nВ этой папке есть:");

// вывод
foreach (var dir in Directory.GetDirectories("."))
{
Console.WriteLine("[Папка] " + dir);
}

foreach (var file in Directory.GetFiles("."))
{
Console.WriteLine("[Файл] " + file);
}
}


 public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }



// реализуем копирование катологов и файлов
static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
{
    // создаем переменную dirs
    string dirs = new dirs;


    // Получить информацию об исходном каталоге
    var dir = new DirectoryInfo(sourceDir);

    // Создаем основной каталог
    Directory.CreateDirectory(destinationDir);

    // Получаем файлы в исходном каталоге и копируем в основной
    foreach (FileInfo file in dir.GetFiles())
    {
        string targetFilePath = Path.Combine(destinationDir, file.Name);
        file.CopyTo(targetFilePath);
    }

    // Рекурсив и копия подкатологов, рекурсивно вызвать метод
    if (recursive)
    {
        foreach (DirectoryInfo subDir in dirs)
        {
            string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
            CopyDirectory(subDir.FullName, newDestinationDir, true);
        }
    }
}

// блок кода, который может допустить ошибку
    try 
    {
        string targetFilePath = Path.Combine(destinationDir, file.Name);
    {
        Directory.CopyTo(targetFilePath, true);
    }
        catch (IOException ex)
     {
        Console.WriteLine($"Ошибка при копировании каталога {file.FullName}: {ex.Message}");
     }
    }
    // последствия ошибки
    catch
    {
    Console.WriteLine("Ошибка");
    }



      string FF = ($"Ошибка при копировании файла {file.FullName}: {ex.Message}");
      StreamWrite Fail = new StreamWrite ( "C:\Users\matve\Desktop\KOD\Ошибки.txt")
      Console.WriteLine(error);




     // удаляем каталог
string dirName = "C:\Users\matve\Desktop\KOD\experiments";
 
DirectoryInfo dirInfo = new DirectoryInfo(dirName);
try {
string dirName = "C:\Users\matve\Desktop\KOD\experiments";
}
DirectoryInfo dirInfo = new DirectoryInfo(dirName);
if (dirInfo.Exists)
{
dirInfo.Delete(true);
Console.WriteLine("Каталог удален");
}
else
{
return false;
}


// удаление файла
string dirName = "C:\Users\matve\Desktop\KOD\experiments\Extended.txt";
 
 FileInfo dirInfo = new FileInfo(dirName);
try {
string dirName = "C:\Users\matve\Desktop\KOD\experiments\Extended.txt";
}
FileInfo dirInfo = new FileInfo(dirName);
if (dirInfo.Exists)
{
dirInfo.Delete(true);
Console.WriteLine("Файл удален");
}
else
{
return false;
}

// Получение информации о размерах и системный атрибутах файла и каталога
var fileInfo = new FileInfo(path);
long sizeInBytes = fileInfo.Length;
DateTime creationTime = fileInfo.CreationTime;
DateTime lastAccessTime = fileInfo.LastAccessTime;
DateTime lastWriteTime = fileInfo.LastWriteTime;
bool isReadOnly = fileInfo.IsReadOnly;

try{
    var dirInfo = new dirInfo(path);
long sizeInBytes = fileInfo.Length;
DateTime creationTime = fileInfo.CreationTime;
DateTime lastAccessTime = fileInfo.LastAccessTime;
DateTime lastWriteTime = fileInfo.LastWriteTime;
bool isReadOnly = fileInfo.IsReadOnly;
}
if(dir.Exists(path))
{
 dirInfo.CreationTime(true);
 Console.WriteLine("CreationTime");

  dirInfo.lastAccessTime(true);
 Console.WriteLine("lastAccessTime");

 dirInfo.sizeInBytes(true);
 Console.WriteLine("sizeInBytes");

 dirInfo.isReadOnly(true);
 Console.WriteLine("isReadOnly");
}
else
{
    return false;
}


// Сохранение ошибок в txt файл. true - добавляет в конец.   
    try
    {
    using (StreamWriter writer = new StreamWriter("C:\\Users\\matve\\Desktop\\KOD\\Ошибки.txt", true)) 
    {
    writer.WriteLine(errorMessage);
    }
    }
    catch (Exception fileEx)
    {
    Console.WriteLine($"Ошибка записи в лог-файл: {fileEx.Message}");
    }
    Console.WriteLine($"Ошибка обработана. Подробности записаны в Ошибки.txt");




           