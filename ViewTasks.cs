using System;

public static ToDoList ViewTasks(this)
{
  foreach(Task t in list)
  {
    Console.WriteLine(t.name + " ");
    Console.Write("Выполнено: " + t.isCompleted);
  }
}
