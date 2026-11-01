using System.Text.Json;

const string fileName = "tasks.json";
bool loadFailed = false;
List<TaskItem> tasks = LoadTasks();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== タスク管理 ===");
    Console.WriteLine("1. タスクを追加");
    Console.WriteLine("2. 一覧を表示");
    Console.WriteLine("3. タスクを完了");
    Console.WriteLine("0. 保存して終了");
    Console.Write("番号を選んでください: ");

    string choice = Console.ReadLine() ?? "";
    if (choice == "1")
    {
        Console.Write("タスクの内容: ");
        string title = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("空のタスクは追加できません。");
            continue;
        }

        tasks.Add(new TaskItem { Title = title });
        Console.WriteLine("タスクを追加しました。");
    }
    else if (choice == "2")
    {
        ShowTasks();
    }
    else if (choice == "3")
    {
        ShowTasks();
        Console.Write("完了するタスク番号: ");
        string input = Console.ReadLine() ?? "";
        if (int.TryParse(input, out int number)
            && number >= 1 && number <= tasks.Count)
        {
            tasks[number - 1].IsDone = true;
            Console.WriteLine("完了にしました。");
        }
        else
        {
            Console.WriteLine("正しい番号を入力してください。");
        }
    }
    else if (choice == "0")
    {
        if (loadFailed)
        {
            Console.WriteLine("読み込みに失敗したため、上書き保存を停止します。");
            Console.WriteLine("元のファイルを確認してください。");
            break;
        }

        try
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(fileName, json);
            Console.WriteLine("保存して終了します。");
            break;
        }
        catch (IOException)
        {
            Console.WriteLine("保存できませんでした。終了せずに戻ります。");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("保存先へのアクセスが許可されていません。");
        }
    }
    else
    {
        Console.WriteLine("メニューの番号を選んでください。");
    }
}

void ShowTasks()
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("タスクはありません。");
        return;
    }

    Console.WriteLine($"タスクは全部で{tasks.Count}件です。");

    for (int i = 0; i < tasks.Count; i++)
    {
        string mark = tasks[i].IsDone ? "x" : " ";
        Console.WriteLine($"{i + 1}. [{mark}] {tasks[i].Title}");
    }
}

List<TaskItem> LoadTasks()
{
    try
    {
        if (!File.Exists(fileName))
        {
            return new List<TaskItem>();
        }

        string json = File.ReadAllText(fileName);
        List<TaskItem>? loaded = JsonSerializer.Deserialize<List<TaskItem>>(json);
        if (loaded is null)
        {
            loadFailed = true;
            return new List<TaskItem>();
        }
        if (loaded.Any(task => task is null || string.IsNullOrWhiteSpace(task.Title)))
        {
            loadFailed = true;
            Console.WriteLine("保存ファイルに不正なタスクが含まれています。");
            return new List<TaskItem>();
        }
        return loaded;
    }
    catch (IOException)
    {
        loadFailed = true;
        Console.WriteLine("保存ファイルを読み込めませんでした。");
        return new List<TaskItem>();
    }
    catch (UnauthorizedAccessException)
    {
        loadFailed = true;
        Console.WriteLine("保存ファイルを開く権限がありません。");
        return new List<TaskItem>();
    }
    catch (JsonException)
    {
        loadFailed = true;
        Console.WriteLine("保存ファイルの形式が正しくありません。");
        return new List<TaskItem>();
    }
}

public class TaskItem
{
    public string Title { get; set; } = "";
    public bool IsDone { get; set; }
}
