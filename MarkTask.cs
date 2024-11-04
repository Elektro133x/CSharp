using System;

public static ToDoList MarkTask(this, string name, bool mark)
{
  foreach(Task t in list)
  {
    if (t.name.Equals(name))
    {
      t.isCompleted = mark;
    }
  }
}
