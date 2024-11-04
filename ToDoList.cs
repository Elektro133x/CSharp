using System;

class Task
{
  string name;
  bool isComplete;

  public Task(string name)
  {
    this.name = name;
    isComplete = false;
  }
}

public static class ToDoList
{
  private ArrayList<Task> list;

  public ToDoList()
  {
    list = new ArrayList<Task>;
  }
}

class Program
{
  public static void Main()
  {
    Console.WriteLine("Добро пожаловать в программу To-Do List.");
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Добавить задачу");
    Console.WriteLine("2 - Удалить задачу");
    Console.WriteLine("3 - Выполнить задачу");
    Console.WriteLine("4 - Отобразить список задач");
    Console.Writeline("0 - Выход");

    while (true)
    {
      switch(Console.ReadLine())
      {
        case "1":
          // добавление задачи
          break;
        case "2":
          // удаление задачи
          break;
        case "3":
          // выполнение задачи
          break;
        case "4":
          // вывод списка
          break;
        case "0":
          return;
        default:
          Console.WriteLine("Неверный выбор, попробуйте ещё раз.");
          break;
      }
    }
  }
}
