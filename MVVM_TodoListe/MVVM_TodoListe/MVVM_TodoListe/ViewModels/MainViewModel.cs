using MVVM_TodoListe.Models;
using MVVM_TodoListe.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM_TodoListe.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly TodoItemService service;

        private List<TodoItem> todoitemliste;

        public List<TodoItem> ToDoItemListe
        {
            get => todoitemliste;
            set => SetProperty(ref todoitemliste, value);
        }

        public Command GetToDoCommand { get; set; }

        public MainViewModel()
        {
            // Kontrollfreak-Antipattern

            service = new TodoItemService();
            GetToDoCommand = new Command(GetToDoItems);
        }

        private void GetToDoItems(object obj)
        {
            ToDoItemListe = service.GetTodoItems();
        }
    }
}
