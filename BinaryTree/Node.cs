﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int data {  get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node() 
        {
            left = null;
            right = null;
        }
    }
}
