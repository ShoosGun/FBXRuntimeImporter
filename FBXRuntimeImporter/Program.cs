﻿using System;
using System.IO;
using System.Collections.Generic;
using FBXRuntimeImporter.AnimationRead;
using System.Text;

namespace FBXRuntimeImporter
{
    //https://code.blender.org/2013/08/fbx-binary-file-format-specification/ reference to this craziness
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "";

            while (!filePath.EndsWith(".fbx"))
            {
                Console.Write("Caminho do arquivo (.fbx): ");
                filePath = Console.ReadLine();
            }

            FBXFileParser fbxFile = new FBXFileParser(filePath);

            //Console.WriteLine("Versao do Arquivo: " + fbxFile.FileVersion);
            //Console.WriteLine(fbxFile. AllNodesToString());
            var animations = fbxFile.ReadAnimation();
            
            Console.WriteLine("Arquivo Interpretado :)");
            Console.Read();
        }
    }
    
    
   
}
