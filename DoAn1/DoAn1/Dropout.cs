﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class Dropout: Module
    {
        private float p;
        private bool inplace;

        public float P { get => p; set => p = value; }
        public bool Inplace { get => inplace; set => inplace = value; }

        public Dropout(string name,List<Layer> inputs,List<Layer> outputs,float p,bool inplace) : base(name, inputs, outputs) {
            this.p = p;
            this.inplace = inplace;
        }
    }
}