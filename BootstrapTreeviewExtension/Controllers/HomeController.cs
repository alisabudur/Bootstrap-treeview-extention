using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapTreeviewExtension.Models;

namespace BootstrapTreeviewExtension.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<TreeviewNode> GetTreeItems()
        {
            return new List<TreeviewNode>
            {
                new TreeviewNode
                {
                    Text = "Teacher 1",
                    Selectable = false,
                    State = new NodeState
                    {
                        Expanded = true
                    },
                    Params = new { teacherId = 1, name = "Alisa"},
                    Nodes = new List<TreeviewNode>
                    {
                        new TreeviewNode
                        {
                            Text = "Student 1",
                            Selectable = false,
                            State = new NodeState
                            {
                                Expanded = true
                            },
                            Params = new { studentId = 11},
                            Nodes = new List<TreeviewNode>
                            {
                                new TreeviewNode
                                {
                                    Text = "Grade 1",
                                    Selectable = false,
                                    State = new NodeState
                                    {
                                        Expanded = true
                                    },
                                    Params = new { gradeId = 111}
                                }
                            }
                        },
                        new TreeviewNode
                        {
                            Text = "Student 2",
                            Selectable = false,
                            State = new NodeState
                            {
                                Expanded = true
                            },
                            Params = new { studentId = 12},
                        }
                    }
                },
                new TreeviewNode
                {
                    Text = "Teacher 2",
                    Selectable = false,
                    Params = new { teacherId = 2, name = "Daniela"},
                    State = new NodeState
                    {
                        Expanded = true
                    },
                    Nodes = new List<TreeviewNode>
                    {
                        new TreeviewNode
                        {
                            Text = "Student 3",
                            Selectable = false,
                            Params = new { studentId = 23},
                        },
                        new TreeviewNode
                        {
                            Text = "Student 4",
                            Selectable = false,
                            Params = new { studentId = 24},
                        }
                    }
                }
            };
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
