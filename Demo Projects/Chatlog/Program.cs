﻿using System;
using System.Collections.Generic;
using System.Threading;
using ffxivlib;

namespace ChatlogTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FFXIVLIB instance = new FFXIVLIB();
            Chatlog c = instance.getChatlog();
            while (true)
                {
                    if (c.isNewLine())
                        {
                            List<Chatlog.Entry> test = c.getChatLogLines();
                            if (test.Count > 0)
                                Console.WriteLine("{0} new log lines", test.Count.ToString());
                            foreach (Chatlog.Entry line in test)
                                Console.WriteLine("{0}[{1}] -> {2}", line.timestamp.ToString(), line.code, line.text);
                        }
                    Thread.Sleep(300);
                }
        }
    }
}