using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using TWTodos.Contexts;
using TWTodos.Models;

namespace TWTodos.Controllers;

public class TodoController : Controller
{
    private readonly TWTodosContext _context;

    public TodoController(TWTodosContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewData["Title"] = "Lista de Tarefas";
        var todos = _context.Todos.ToList();   
        return View(todos);
    }
    
}