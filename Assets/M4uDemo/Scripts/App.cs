using UnityEngine;
using M4u;

namespace M4uDemo
{
    public class App : M4uContext
    {
        public static readonly App Instance = new App();

        public Demo Demo { get; set; }
		
        private App() { }
    }
}