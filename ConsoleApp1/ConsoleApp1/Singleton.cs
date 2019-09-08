using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private Singleton()
        {
        }
    }
}

//Был выбрал именно этот способ реализации из соображений потокобезопасности и отложенной реализации.
//Оба свойства обеспечиваются использованием типа Lazy<> (по умолчанию объекты Lazy<> потокобезопасны), о котором прочитал тут:
//https://docs.microsoft.com/en-us/dotnet/framework/performance/lazy-initialization

