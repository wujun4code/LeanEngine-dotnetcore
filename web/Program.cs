﻿using System;
using LeanCloud;
using LeanCloud.Engine;
namespace web
{
    class Program
    {
        static void Main(string[] args)
        {
            Cloud cloud = new Cloud().SetHooks();
            cloud.Start(args);
        }
    }
}
