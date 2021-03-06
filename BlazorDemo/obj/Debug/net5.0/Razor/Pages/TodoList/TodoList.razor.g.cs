#pragma checksum "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61df4f980a44df57849c1d55f849f7d896135987"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Pages.TodoList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using BlazorDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/_Imports.razor"
using BlazorDemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
 if (todos != null)

// @bind directive is similar to Angular's ngModel
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "b-j7yqc9v92x");
            __builder.AddContent(2, "Todo (");
            __builder.AddContent(3, 
#nullable restore
#line 6 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
               todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "bg-dark p-2 d-flex justify-content-start align-items-center");
            __builder.AddAttribute(8, "b-j7yqc9v92x");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "placeholder", "Something todo");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                                   _newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newTodo = __value, _newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(13, "b-j7yqc9v92x");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        <div class=\"mx-2\" b-j7yqc9v92x></div>\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-success");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-j7yqc9v92x");
            __builder.AddContent(19, "Add todo");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "my-list pl-0");
            __builder.AddAttribute(22, "b-j7yqc9v92x");
#nullable restore
#line 17 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
         for (int i = 0; i < todos.Count(); i++)
        {
            // we need to capture the loop variable in latest blazor
            // see "https://ericlippert.com/2009/11/12/closing-over-the-loop-variable-considered-harmful-part-one" for reference
            int index = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "my-2" + " p-2" + " " + (
#nullable restore
#line 23 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                   (index == hoveredElementIndex) ? "bg-secondary" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                 () => MouseOver(list[todos[index].Name], index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                () => MouseOut(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "b-j7yqc9v92x");
            __builder.AddElementReferenceCapture(28, (__value) => {
#nullable restore
#line 22 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                     list[todos[index].Name] = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "d-flex form-group");
            __builder.AddAttribute(31, "b-j7yqc9v92x");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-danger");
            __builder.AddAttribute(34, "title", "delete todo");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                                                                 (() => DeleteToto(index, todos[index].Name))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "b-j7yqc9v92x");
            __builder.AddMarkupContent(37, "<span class=\"oi oi-trash\" b-j7yqc9v92x></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n                    <div class=\"mx-2\" b-j7yqc9v92x></div>\n                    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "class", "w-25 form-control");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                                             todos[index].Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todos[index].Name = __value, todos[index].Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(43, "b-j7yqc9v92x");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                    <div class=\"mx-2\" b-j7yqc9v92x></div>\n                    ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "checkbox");
            __builder.AddAttribute(47, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
                                                   todos[index].IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todos[index].IsDone = __value, todos[index].IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.AddAttribute(49, "b-j7yqc9v92x");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 38 "/Users/maximilianboth/projects/BlazorDemo/BlazorDemo/Pages/TodoList/TodoList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
