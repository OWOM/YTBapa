﻿using System;
using YTBapa.Library;

namespace YTbapa.PanelTool
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAdd();
            Console.Read();
        }

        public static  void TestAdd() {
            TestPanel tes = new TestPanel();
            Console.WriteLine(tes.Add());
        }

    }
}