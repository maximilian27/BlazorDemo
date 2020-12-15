using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace BlazorDemo.Pages.TodoList
{
    public partial class TodoList
    {
        // dependency injection (a.k.a. services can be injected)
        [Inject] IJSRuntime JS { get; set; }
        [Inject] private HttpClient Http { get; set; }
        
        // list should not have fixed dimension
        public IList<Todo> todos = new List<Todo>();
        // private ElementReference list, we use a dictionary in order to store the references;
        private Dictionary<string, ElementReference> list = new Dictionary<string, ElementReference>();
        private string _newTodo;
        private int _hoveredElementIndex = -1;
        
        // fetch data 
        protected override async Task OnInitializedAsync()
        {
            todos = await Http.GetFromJsonAsync<IList<Todo>>("sample-data/list.json");
            // built in JS methods can be accessed directly like in the example below
            // invoke js console.log method
            await JS.InvokeAsync<string>("console.log", todos);

        }
        
        // add todoitem
        private void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(_newTodo))
            {
                todos.Add(new Todo { Name = _newTodo });
                _newTodo = string.Empty;
            }
        }
        
        // delete functionality is handled in JS as a demo purpose
        // we need to use "async Task" instead of "async void" in order to await the result from the async JS invocation
        private async Task DeleteToto(int index, string elem) 
        {
            await JS.InvokeAsync<string>("console.log", elem);
            //manually remove element from dictionary
            list.Remove(elem);
            // "deleteTodo" JS method can be found in /wwwroot/js/helpers.js
            todos = await JS.InvokeAsync<IList<Todo>>("deleteTodo", todos, index);
        }
        
        private async void MouseOver(ElementReference reference, int index)
        {
            _hoveredElementIndex = index;
            await JS.InvokeVoidAsync("mouseoverHandler", reference);
        }

        private void MouseOut(int index)
        {
            // await JS.InvokeVoidAsync("console.log", hoveredElementIndex);
            _hoveredElementIndex = -1;
        }
        
        public class Todo
        {
            public string Name { get; set; }

            public bool IsDone { get; set; }
        }
    }
}