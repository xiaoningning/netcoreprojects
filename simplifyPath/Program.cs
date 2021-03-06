﻿using System;
using System.Collections.Generic;

namespace simplifyPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Solution();
            string p = "/home/foo/.ssh/../.ssh2/key";
            Console.WriteLine("simplify path {0}", obj.SimplifyPath(p));
        }
    }
    public class Solution {
        public string SimplifyPath(string path) {
            var s = new Stack<string>();
            string[] p = path.Split('/');
            foreach(string c in p){
                if (c == ".." && s.Count !=0) s.Pop();
                else if (!string.IsNullOrEmpty(c) 
                         && c != "." && c != "..") s.Push(c);
            }
            var res = new List<string>();
            while(s.Any()){
                res.Insert(0, s.Pop());
            }
            return "/" + string.Join("/", res);
        }
    }
}
