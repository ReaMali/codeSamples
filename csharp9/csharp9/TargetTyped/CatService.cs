﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9.TargetTyped
{
    class CatService
    {
        private ConcurrentDictionary<string, ObservableList<Cat>> _catsBefore = new ConcurrentDictionary<string, ObservableList<Cat>>();
        private ConcurrentDictionary<string, ObservableList<Cat>> _cats = new(); // C# 9.0

        private List<Cat> _catList = new List<Cat>
        {
            new Cat("cat1"),
            new Cat("cat2"),
            new Cat("cat2")
        };

        // C# 9.0
        private List<Cat> _catListC9 = new()
        {
            new ("cat1"),
            new ("cat2"),
            new ("cat2")
        };

        public void CallerMethod()
        {
            this.Adopt(new Cat("my cat"));

            // C# 9.0
            this.Adopt(new("my cat"));
        }


        public void Adopt(Cat c)
        {
        }
    }
}
