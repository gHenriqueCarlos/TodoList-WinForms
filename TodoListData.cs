using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Collections;

namespace todoList_winForms
{
    public class TodoListDataEx{
        public string? TodoName { get; set; }
        public string? TodoDescription { get; set; }
        public string? TodoDate { get; set; }
        public string? TodoFinished { get; set; }
    }
    public class TodoListData{

        public List<TodoListDataEx> UserTodoList = new List<TodoListDataEx>();

        public TodoListData(bool loadData) {
            if (loadData){

            }
        }

        public void ClearTodoList()
        {
            UserTodoList.Clear();
        }
        public void SaveTodo(string TodoName, string description, string date, bool finished)
        {
            var todo = new TodoListDataEx
            { 
                TodoName = TodoName,
                TodoDescription = description,
                TodoDate = date,
                TodoFinished = finished ? "Sim" : "Não"
            };

            UserTodoList.Add(todo);
        }
        public void DeleteTodo(string TodoName) {
            foreach(var todoName in UserTodoList)
            {
                if(todoName.TodoName == TodoName)
                {
                    UserTodoList.Remove(todoName);
                    break;
                }
            }
        }
    }
}
