using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAccessModifiers
{
    public class LibraryItem
    {
        protected internal string Title {  get; set; } = string.Empty;
        public string GetTitle() { return Title; }
        public LibraryItem(string title) { Title = title; }
    }
    public class Book : LibraryItem
    {
        public Book(string title) : base (title)
        {

        }
    }


}


