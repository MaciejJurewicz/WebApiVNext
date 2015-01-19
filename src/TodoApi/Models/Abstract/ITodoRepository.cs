using System;
using System.Collections.Generic;

namespace TodoApi.Models.Abstract
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> AllItems { get; }
        void Add(TodoItem item);
        TodoItem GetById(int id);
        bool TryDelete(int id);

    }
}