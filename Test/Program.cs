using System;
using System.Collections.Generic;
using SimpleMapper;

namespace Test
{
    public class Obj
    {
        public string name { get; set; }
    }
    public class Obje
    {
        public string Name { get; set; }
    }
    public class A
    {
        public string Id { get; set; }
        public List<Obj> arr { get; set; }
        public Obj o1 { get; set; }
        public DateTime dt { get; set; }
        public Dictionary<string, string> abc { get; set; }
    }
    public class B
    {

        public int Id { get; set; }
        public List<Obje> arr { get; set; }
        public Obje o1 { get; set; }
        public DateTime dt { get; set; }
        public Dictionary<string, string> abc { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A
            {
                Id = "23",
                arr = new List<Obj> { new Obj { name = "abbba" } },
                o1 = new Obj { name = "abc" },
                dt = DateTime.Now
            };
            a.abc = new Dictionary<string, string>();
            a.abc.Add("aa", "bb");

            var alist = new List<A> { a };

            var blist = Mapper.Map<List<B>>(alist);
            Console.WriteLine(blist[0].abc["aa"]);
        }
    }
}
