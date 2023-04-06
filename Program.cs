using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

string path = "D:\\project c++\\ConsoleApp13\\ConsoleApp13\\bin\\Debug\\schedule.csv";
// асинхронное чтение
using (StreamReader reader = new StreamReader(path))
{
   
   string text =  reader.ReadToEnd();





    text = text.Replace(",", "");// замена , на ""

    text = text.Replace("Группа - ", ""); // удаление Группа - 
    text = text.Replace("", "");


    Console.WriteLine(text);    // 









}

