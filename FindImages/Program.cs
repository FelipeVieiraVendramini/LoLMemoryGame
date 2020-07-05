// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (C) FTW! Programação e Desenvolvimento
// Keep the headers and the patterns adopted by the project. If you changed anything in the file just insert
// your name below, but don't remove the names of who worked here before.
// 
// MemoryGame - FindImages - Program.cs
// Description:
// 
// Creator: FELIPEVIEIRAVENDRAMI [FELIPE VIEIRA VENDRAMINI]
// 
// Developed by:
// Felipe Vieira Vendramini <felipevendramini@live.com>
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FindImages
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> files = Directory.EnumerateFiles($"{Environment.CurrentDirectory}\\images_old", "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg")).ToList();

            int count = 1;
            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);
                string name = Path.GetFileNameWithoutExtension(file);
                string[] splitName = name.Split('_');
                string newName = splitName[2].Replace("8bf8", "") + extension;
                File.Copy(file, $"{Environment.CurrentDirectory}\\images\\{newName}", true);
                Console.WriteLine($"File {count++} : {name}{extension} to {newName}");
            }

            Console.WriteLine($"File Count: {files.Count}");

            Console.ReadLine();
        }
    }
}