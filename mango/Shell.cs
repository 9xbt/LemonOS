﻿using System.IO;

namespace mango
{
    public static class Shell
    {
        private static SVGAIITerminal Console = Kernel.Console;

        public static void Run()
        {
            Console.Write(Kernel.Username, SVGAIIColor.Green);
            Console.Write(":");
            Console.Write(DiskManager.GetUnixLikePath(Directory.GetCurrentDirectory()), SVGAIIColor.Blue);
            Console.Write(" $ ");

            string input = Console.ReadLine().Trim();
            string[] args = input.Split(' ');
            
            switch (args[0].Trim().ToLower())
            {
                case "?":
                    Commands.Help();
                    break;

                case "help":
                    Commands.Help();
                    break;

                case "info":
                    Commands.Info();
                    break;

                case "clear":
                    Commands.Clear();
                    break;

                case "loadkeys":
                    Commands.LoadKeys(args);
                    break;

                case "su":
                    Commands.SU(args);
                    break;

                case "ls":
                    Commands.LS();
                    break;

                case "cd":
                    Commands.CD(input, args);
                    break;

                case "touch":
                    Commands.Touch(input, args);
                    break;

                case "mkdir":
                    Commands.MkDir(input, args);
                    break;

                case "cat":
                    Commands.Cat(input, args);
                    break;

                case "rm":
                    Commands.RM(input, args);
                    break;

                case "rmdir":
                    Commands.RmDir(input, args);
                    break;

                case "echo":
                    Commands.Echo(input, input.Split("echo ")[1].Split(" >> "));
                    break;

                default:
                    Console.WriteLine($"Command \"{args[0].Trim()}\" not found.", SVGAIIColor.Red);
                    break;
            }
        }
    }
}