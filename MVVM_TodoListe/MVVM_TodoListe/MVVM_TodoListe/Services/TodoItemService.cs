using MVVM_TodoListe.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MVVM_TodoListe.Services
{
    public class TodoItemService
    {
        public List<TodoItem> GetTodoItems()
        {
            // 1) json runterladen
            // 2) deserialisieren
            // 3) todoitem-liste zurückgeben

            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://jsonplaceholder.typicode.com/todos").Result;
            }

            return JsonConvert.DeserializeObject<List<TodoItem>>(json);
        }
    }
}
