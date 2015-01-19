using System.Collections.Generic;
using System.Linq;
using TodoApi.Models.Abstract;

namespace TodoApi.Models
{
    public class TodoRepository : ITodoRepository
    {
        private readonly List<TodoItem> _items = new List<TodoItem>();
        public IEnumerable<TodoItem> AllItems
        {
            get
            {
                return _items;
            }
        }

        public void Add(TodoItem item)
        {
            item.Id = 1 + _items.Max(x => (int?)x.Id) ?? 0;
            _items.Add(item);
        }

        public TodoItem GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public bool TryDelete(int id)
        {
            var item = GetById(id);
            if (item == null)
            {
                return false;
            }
            _items.Remove(item);
            return true;
        }
    }
}