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
    using (StreamWriter writer = new StreamWriter("C:\Users\matve\Desktop\KOD\Ошибки.txt", true)) 
    {
    writer.WriteLine(errorMessage);
    }
    }
    catch (Exception fileEx)
    {
    Console.WriteLine($"Ошибка записи в лог-файл: {fileEx.Message}");
    }
    Console.WriteLine($"Ошибка обработана. Подробности записаны в Ошибки.txt");


// Реализация событий
public static class FileManagerEvents
{   
     public static event Action<string> OnDirectoryChanged;
    public static event Action<string, string> OnFileCopied;
    public static event Action<string> OnFileDeleted;
    public static event Action<string> OnFileInfoRequested;
    public static event Action<int> OnPageChanged;

    public static void RaiseDirectoryChanged(string path) => OnDirectoryChanged?.Invoke(C:\Users\matve\Desktop\KOD);
    public static void RaiseFileCopied(string source, string destination) => OnFileCopied?.Invoke(source, destination);
    public static void RaiseFileDeleted(string path) => OnFileDeleted?.Invoke(C:\Users\matve\Desktop\KOD\feature.txt);
    public static void RaiseFileInfoRequested(string path) => OnFileInfoRequested?.Invoke(C:\Users\matve\Desktop\KOD\feature.txt);
    public static void RaisePageChanged(int page) => OnPageChanged?.Invoke(C:\Users\matve\Desktop\KOD\feature.txt);
}

public static class UIManager
{
  private string  File = File.Kracker;
   private string path = "C:\Users\matve\Desktop\KOD\feature.txt";
    private string patifa = "C:\Users\matve\Desktop\KOD";
    private int one = 1;
   private int two = 2;
   
  -----------------------------------------
if (Action OnDirectoryChanged)
{
    Console.WriteLine("Файл" + File + "изменил директорию на " + path);
}
else
{
    Console.WriteLine("Директория не найдена");
}
-------------------------------------------
if(Action OnFileCopied)
{
Console.WriteLine("Файл" + File + "Скопирован в директорию" + patifa );
}
else
{
    Console.WriteLine("Директория не найдена");
}
-------------------------------------------
if(Action OnFileDeleted)
{
Console.WriteLine("Файл" + File + "Удален" );
}
else
{
    Console.WriteLine("Файл не найден");
}
-------------------------------------------
if(Action OnFileInfoRequested)
{
Console.WriteLine("Файл" + File + "Перенесен в директорию" + patifa );
}
else
{
    Console.WriteLine("Директория не найдена");
}
-------------------------------------------
if(Action OnPageChanged)
{
    Console.WriteLine("Страница" + one "Изменена на" + two);
}
else
{
    Console.WriteLine("Страница не найдена");
}
}
// Обновленный процесс обработки команд
private static readonly Dictionary<string, Action<string[]>> commands = new()
{
    { "copy", args => FileManagerEvents.RaiseFileCopied(args[0], args[1]) },
    { "delete", args => FileManagerEvents.RaiseFileDeleted(args[0]) },
    { "info", args => FileManagerEvents.RaiseFileInfoRequested(args[0]) },
    { "cd", args => FileManagerEvents.RaiseDirectoryChanged(args[0]) },
    { "up", _ => FileManagerEvents.RaisePageChanged(-1) },
    { "down", _ => FileManagerEvents.RaisePageChanged(1) }
}

public static void ProcessCommand(string input)
{
    var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (parts.Length == 0 || !commands.ContainsKey(parts[0]))
    {
        Console.WriteLine("Неизвестная команда.");
        return;
    }

    commands[parts[0]].Invoke(parts.Skip(1).ToArray());
}

// Добавление поддержки истории команд
public static class HistoryManager
private string = new;
{
    private static readonly List<string> history = new();
    private static int currentIndex = -1;

    public static void AddCommand(string command)
    {
        history.Add(command);
        if (history.Count > 10) history.RemoveAt(0);
        currentIndex = history.Count;
    }

    public static string GetPreviousCommand()
    {
        if (currentIndex > 0) currentIndex--;
        return history.ElementAtOrDefault(currentIndex) ?? string.Empty;
    }

    public static string GetNextCommand()
    {
        if (currentIndex < history.Count - 1) currentIndex++;
        return history.ElementAtOrDefault(currentIndex) ?? string.Empty;
    }
}


// Улучшенная обработка ошибок
public static class ErrorLogger
{
    private static readonly string errorDirectory = "errors";
    private static readonly string errorFile = $"{errorDirectory}/{Guid.NewGuid()}_exception.txt";

    static ErrorLogger()
    {
        if (!Directory.Exists(errorDirectory))
        {
            Directory.CreateDirectory(errorDirectory);
        }
    }

    public static void LogError(Exception ex)
    {
        File.AppendAllText(errorFile, $"{DateTime.Now}: {ex.Message}{Environment.NewLine}");
    }
}