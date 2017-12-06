﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dvspisuk
{
    class Queue
    {
        private List<string> cont;
        public void Push(string value)
        {
            this.cont.Add(value);
        }
        public string Pop()
        {
            string popped = cont[0];
            cont.RemoveAt(0);
            return popped;
        }
        public bool Empty
        {
            get { return cont.Count == 0; }
        
        }
        public Queue()
        {
            this.cont = new List<string>();
        }

    }
}
