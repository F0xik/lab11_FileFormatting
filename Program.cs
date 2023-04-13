using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.SqlTypes;

string path = "D:\\project c++\\ConsoleApp13\\ConsoleApp13\\bin\\Debug\\schedule.csv";
List<string> files = new List<string>(); 
files.RemoveAll(it => it.Equals(",,,,,,,,,,,,")); // замена запятых
files.RemoveAll(it => it.Equals(",,,,,,,,,,,,,,,,,,,,,,,,"));
files.RemoveAll(it => it.Equals(", ,   ,, ,   ,, ,   ,, ,   ,, ,   ,, ,   ,"));
files.RemoveAll(it => it.Split(",")[0] != "1" && it.Split(",")[1] == "");



using (StreamReader reader = new StreamReader(path))
{
    
    string? text;
    while ((text = await reader.ReadLineAsync()) != null) //ассинхронное чтение файла до конца
    {
        var result = String.Join(" ", text.ToCharArray());
        // форматирование
        text = text.Replace("Ауд.", ""); text = text.Replace("407", "");
        text = text.Replace("Группа -", "");
        text = text.Replace("-", "");
        text = text.Replace("Учебная практика", "Учебная практика(-)");
        text = text.Replace("01 (-)", "01()");
        text = text.Replace('"', ' '); text = text.Replace("Предмет", "");
        text = text.Replace(",", " "); text = text.Replace("занятия", "");
        text = text.Replace("1.Иностранный язык", "\tИностраный язык(407/422)\u00A0\u00A0"); text = text.Replace("вид", "");
        text = text.Replace("2.Иностранный язык", "\tИностраный язык(407/422)\t"); text = text.Replace("бассейн 1", "");
        text = text.Replace("133", ""); text = text.Replace("419", "");
        text = text.Replace("132", ""); text = text.Replace("402", "");
        text = text.Replace("319", ""); text = text.Replace("323", "(323)");
        text = text.Replace("409", ""); text = text.Replace("418", "(418)");
        text = text.Replace("312", ""); 
        text = text.Replace("Электротехника", "\t\t\t\t\t\t\t\t\t\t\t\t\tЭлектротехника");
        text = text.Replace("Физическая культура", "\tФизическая культура(бас)\u00A0\u00A0");
        text = text.Replace("ОБЖ", "\tОБЖ(312)\t\t\u00A0 ");
        text = text.Replace("Информатика и ИКТ", "\tИнформатика  и  ИКТ\t\u00A0\u00A0");
        text = text.Replace("Химия", "\tХимия\u00A0\u00A0"); text = text.Replace("Физика", "\tФизика(402)\t\t\t\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0");
        text = text.Replace("Понедельник", "\tПонедельник\t\t"); text = text.Replace("Вторник", "  Вторник");
        text = text.Replace("Среда", "\t\tСреда"); text = text.Replace("Четверг", "\t\t\tЧетверг");
        text = text.Replace("Пятница", "\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0Пятница"); text = text.Replace("Суббота", "");
        text = text.Replace("История", "\tИстория(419)\t\t\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0"); text = text.Replace("Черчение", "\tЧерчение(319)\t\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0");
        text = text.Replace("Русский язык", "\tРусский язык(-)\t"); text = text.Replace("Литература", "\tЛитература");
        text = text.Replace("МДК 01.01", "\tМДК 01.01"); text = text.Replace("Математика", $"\tМатематика(133) \u00A0");
        text = text.Replace("Обществознание", "\t\tОбществознание"); text = text.Replace("Материаловедение", "\tМатериаловедение");
        text = text.Replace("Слесарное дело", "\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0Слесарное дело(319)");
        text = text.Replace("МДК 02.01", "\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0МДК 02.01(132)");
        text = text.Replace("Биология", "\t\tБиология");
        text = text.Replace("411", ""); text = text.Replace("318", "(318)"); text = text.Replace("Химия", "Химия(411)\t\t");
        text = text.Trim();
        int j = 0;
        text = Regex.Replace(text, "[ ]+", " ");
        if (j < 34) { if (!string.IsNullOrWhiteSpace(text)) files.Add(text); }
        j++;
    }
    
}

files[5] = null; files[6] = null;
files[8] = files[8] + " " + " ";
files[9] = null; files[10] = null;
files[11] = files[11] + " ";
files[12] = null; files[13] = null;

foreach (var element in files) {if (element != null)
        Console.WriteLine(element);
}

