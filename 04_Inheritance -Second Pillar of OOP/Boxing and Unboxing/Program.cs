using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); // boxing happens
            list.Add("Mosh"); // boxing does not happen cause Its a reference type
            list.Add(DateTime.Today); // boxing happens

            var number = (int)list[1];

            // better way is to use a generic list
            var anotherList = new List<int>();
            anotherList.Add(1); // type safety

            var names = new List<string>();
            names.Add("test");
        }
    }
}
