using CourseWorkStringFormat;
using System.Globalization;

namespace CourseWorkStringFormat 
{
    public class Program 
    {
        public static void Main() 
        {
            string str = "Hello";

            string str1 = "Some string";
            string str2 = "Some string";
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1 != str2);

            string escape1 = "Col1\tCol2\tCol3";
            string escape2 = "Schildt Herbert: \"C# The Complete Reference\"";
            string escape3 = "C:\\Users\\User\\source\\repos\\CourseWorkStringFormat";
            Console.WriteLine(escape1);
            Console.WriteLine(escape2);
            Console.WriteLine(escape3);


            string s1 = "C:\\Users\\User\\source\\repos\\CourseWorkStringFormat";
            string s2 = @"C:\Users\User\source\repos\CourseWorkStringFormat";
            Console.WriteLine(s1);
            Console.WriteLine(s2);


            string s3 = @"Name of project: ""CourseWorkStringFormat""";
            Console.WriteLine(s3);

            string c1 = "Coursework";
            string c2 = c1 + " number " + "1";
            c1 += "2";
            Console.WriteLine(c1);
            Console.WriteLine(c2);


            string c3 = "Coursework" + 3;
            Console.WriteLine(c3);

            char[] arr = { 'c', 'o', 'u', 'r', 's', 'e', 'w', 'o', 'r', 'k' };

            String cs1 = new String(arr);
            String cs2 = new String(arr, 6, 4);

            Console.WriteLine(cs1);
            Console.WriteLine(cs2);


            char ch1 = 'f';
            String cs3 = new String(ch1, 5);
            Console.WriteLine(cs3);


            String cs4 = "Course Work String Format";
            for (int i = 0; i < cs4.Length; i++)
                Console.Write(cs4[i]);
            Console.WriteLine();


            String concat1 = "Course";
            String concat2 = " ";
            String concat3 = "work";
            String[] concatArr = { "Course", " ", "work", " ", "string", " ", "format" };
            String concat4 = String.Concat(concat1, concat2, concat3);
            String concat5 = String.Concat(concatArr);
            Console.WriteLine(concat4);
            Console.WriteLine(concat5);


            String[] joinArr1 = { "course", "work", "string", "format" };
            object[] joinArr2 = { "course", "work", "#", 1, "string", "format", 5 };
            String join1 = String.Join('-', joinArr1);
            String join2 = String.Join('-', joinArr1, 2, 2);
            String join3 = String.Join(" => ", joinArr1);
            String join4 = String.Join(" => ", joinArr1, 2, 2);
            String join5 = String.Join('-', joinArr2);
            String join6 = String.Join('-', joinArr2, 2, 2);
            String join7 = String.Join(" => ", joinArr2);
            String join8 = String.Join(" => ", joinArr2, 2, 2);
            String join9 = String.Join('-', "course", "work", "string", "format");
            String join10 = String.Join(" => ", "course", "work", "string", "format");
            String join11 = String.Join('-', "course", "work", "#", 1, "string", "format", 5);
            String join12 = String.Join(" => ", "course", "work", "#", 1, "string", "format", 5);
            Console.WriteLine(join1);
            Console.WriteLine(join2);
            Console.WriteLine(join3);
            Console.WriteLine(join4);
            Console.WriteLine(join5);
            Console.WriteLine(join6);
            Console.WriteLine(join7);
            Console.WriteLine(join8);
            Console.WriteLine(join9);
            Console.WriteLine(join10);
            Console.WriteLine(join11);
            Console.WriteLine(join12);


            IEnumerable<string> planetsList = new List<string>() { "Mercury", "Venus", "Earth", "Mars" };
            List<Planet> planets = new List<Planet>();
            planets.Add(new Planet("Mercury"));
            planets.Add(new Planet("Venus"));
            planets.Add(new Planet("Earth"));
            planets.Add(new Planet("Mars"));
            String join13 = String.Join(" => ", planetsList);
            String join14 = String.Join('-', planets);
            String join15 = String.Join(" => ", planets);
            Console.WriteLine(join13);
            Console.WriteLine(join14);
            Console.WriteLine(join15);


            String compare1 = "course workA";
            String compare2 = "course workB";
            if (String.Compare(compare1, compare2) == 0)
            {
                Console.WriteLine("Strings are equals");
            }
            else if (String.Compare(compare1, compare2) > 0)
            {
                Console.WriteLine("First string is grather then second");
            }
            else
            {
                Console.WriteLine("Second string is grather then first");
            }


            String compare3 = "course WORKA";
            String compare4 = "COURSE workB";
            if (String.Compare(compare3, compare4, true) == 0)
            {
                Console.WriteLine("Strings are equals");
            }
            else if (String.Compare(compare3, compare4, true) > 0)
            {
                Console.WriteLine("First string is grather then second");
            }
            else
            {
                Console.WriteLine("Second string is grather then first");
            }


            String compare5 = "course workA";
            String compare6 = "1course workB";
            if (String.Compare(compare5, 2, compare6, 3, 5) == 0)
            {
                Console.WriteLine("Strings are equals");
            }
            else if (String.Compare(compare5, 2, compare6, 3, 5) > 0)
            {
                Console.WriteLine("First string is grather then second");
            }
            else
            {
                Console.WriteLine("Second string is grather then first");
            }



            String compare7 = "Course WOrkA";
            String compare8 = "1couRSE workB";
            if (String.Compare(compare7, 2, compare8, 3, 5, true) == 0)
            {
                Console.WriteLine("Strings are equals");
            }
            else if (String.Compare(compare7, 2, compare8, 3, 5, true) > 0)
            {
                Console.WriteLine("First string is grather then second");
            }
            else
            {
                Console.WriteLine("Second string is grather then first");
            }


            string compare9 = "coursework";
            string compare10 = "Coursework";
            int resCompare = String.Compare(compare9, compare10, new CultureInfo("en-US"), CompareOptions.None);
            if (resCompare < 0)
                Console.WriteLine("Second string is grather then first");
            else if (resCompare > 0)
                Console.WriteLine("First string is grather then second");
            else
                Console.WriteLine("Strings are equals");

            resCompare = String.Compare(compare9, compare10, new CultureInfo("en-US"), CompareOptions.IgnoreCase);
            if (resCompare < 0)
                Console.WriteLine("Second string is grather then first");
            else if (resCompare > 0)
                Console.WriteLine("First string is grather then second");
            else
                Console.WriteLine("Strings are equals");


            String compare11 = "КУРСОВА РОБОТА";
            String compare12 = "курсова робота";
            int resCompare1;

            resCompare1 = String.Compare(compare11, 3, compare12, 3, 5, true, new CultureInfo("uk-UA"));
            if (resCompare1 < 0)
                Console.WriteLine("Second string is grather then first");
            else if (resCompare1 > 0)
                Console.WriteLine("First string is grather then second");
            else
                Console.WriteLine("Strings are equals");

            resCompare1 = String.Compare(compare11, 3, compare12, 3, 5, true, CultureInfo.InvariantCulture);
            if (resCompare1 < 0)
                Console.WriteLine("Second string is grather then first");
            else if (resCompare1 > 0)
                Console.WriteLine("First string is grather then second");
            else
                Console.WriteLine("Strings are equals");


            String compareOrd1 = "str format work";
            String compareOrd2 = "STR FORMAT WORK";
            String compareOrd3 = "some string";
            String compareOrd4 = "some text";
            int resCompareOrd1 = String.CompareOrdinal(compareOrd1, compareOrd2);
            int resCompareOrd2 = String.CompareOrdinal(compareOrd3, 1, compareOrd4, 1, 5);
            Console.WriteLine(resCompareOrd1);
            if (resCompareOrd1 < 0)
                Console.WriteLine("Second string is grather then first");
            else if (resCompareOrd1 > 0)
                Console.WriteLine("First string is grather then second");
            else
                Console.WriteLine("Strings are equals");
            Console.WriteLine(resCompareOrd2);
            if (resCompareOrd2 < 0)
                Console.WriteLine("Second string is grather then first");
            else if (resCompareOrd2 > 0)
                Console.WriteLine("First string is grather then second");
            else
                Console.WriteLine("Strings are equals");



            List<Planet> plCompArr = new List<Planet>();
            plCompArr.Add(new Planet("Mars"));
            plCompArr.Add(new Planet("Earth"));
            plCompArr.Add(new Planet("Jupiter"));
            plCompArr.Add(new Planet("Neptune"));
            plCompArr.Sort();

            foreach (var item in plCompArr)
                Console.WriteLine(item.Name);



            string compTo1 = "fstr";
            string compTo2 = "fstr";
            int resCompTo1 = compTo1.CompareTo(compTo2);
            if (resCompTo1 < 0)
                Console.WriteLine("Second string is grather then first");
            else if (resCompTo1 > 0)
                Console.WriteLine("First string is grather then second");
            else
                Console.WriteLine("Strings are equals");



            String copy1 = "course work";
            String copy2 = copy1;
            String copy3 = String.Copy(copy1);

            Console.WriteLine(Object.ReferenceEquals(copy1, copy2));
            Console.WriteLine(Object.ReferenceEquals(copy1, copy3));


            string copyTo1 = "Course Work String Format";
            char[] copyTo1Arr = new char[20];
            copyTo1.CopyTo(7, copyTo1Arr, 0, 11);
            Console.Write(copyTo1Arr);


            string indexStr1 = "My Work With Strings";
            int indexOf1 = indexStr1.IndexOf('r');
            int indexOf2 = indexStr1.IndexOf('Q');
            int indexOf3 = indexStr1.IndexOf("With");
            int indexOf4 = indexStr1.IndexOf('r', 9);
            int indexOf5 = indexStr1.IndexOf("th", 6);
            int indexOf6 = indexStr1.IndexOf("STRING", 3, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(indexOf1);
            Console.WriteLine(indexOf2);
            Console.WriteLine(indexOf3);
            Console.WriteLine(indexOf4);
            Console.WriteLine(indexOf5);
            Console.WriteLine(indexOf6);


            string indexStr2 = "work string example work";
            int lastIndexOf1 = indexStr2.LastIndexOf('r');
            int lastIndexOf2 = indexStr2.LastIndexOf('K');
            int lastIndexOf3 = indexStr2.LastIndexOf("work");
            int lastIndexOf4 = indexStr2.LastIndexOf('e', 20, 10);
            Console.WriteLine(lastIndexOf1);
            Console.WriteLine(lastIndexOf2);
            Console.WriteLine(lastIndexOf3);
            Console.WriteLine(lastIndexOf4);


            string startStr = "Work with strings";
            bool isStart1 = startStr.StartsWith('W');
            bool isStart2 = startStr.StartsWith('K');
            bool isStart3 = startStr.StartsWith("WORK", true, CultureInfo.InvariantCulture);
            bool isStart4 = startStr.EndsWith("qww");
            bool isStart5 = startStr.EndsWith('s');
            Console.WriteLine(isStart1);
            Console.WriteLine(isStart2);
            Console.WriteLine(isStart3);
            Console.WriteLine(isStart4);
            Console.WriteLine(isStart5);


            string trimStr1 = " Course Work ";
            string resTrimStr1 = trimStr1.Trim();
            Console.WriteLine(resTrimStr1);

            string trimStr2 = "%%% %%%String Format*** ***";
            char[] charsToTrim = { '*', '%', ' ' };
            string resTrimStr2 = trimStr2.Trim(charsToTrim);
            Console.WriteLine(resTrimStr2);



            string trimStr3 = "**Course Work**";
            string resTrimStr3 = trimStr3.TrimStart('*');
            Console.WriteLine(resTrimStr3);

            string trimStr4 = "^^String Format**";
            char[] charsToTrim4 = { '^', '*' };
            string resTrimStr4 = trimStr4.TrimStart(charsToTrim4);
            Console.WriteLine(resTrimStr4);


            string trimStr5 = "((Course Work))";
            string resTrimStr5 = trimStr5.TrimEnd(')');
            Console.WriteLine(resTrimStr5);

            string trimStr6 = "*%*%String Format*%*%";
            string resTrimStr6 = trimStr6.TrimEnd('*', '%');
            Console.WriteLine(resTrimStr6);


            Console.WriteLine("\tFirst example:");
            string split1 = "C#.Course work.String Format.Variant 8";
            char separator1 = '.';
            string[] resSplit1 = split1.Split(separator1);
            foreach (string st in resSplit1)
                Console.WriteLine(st);
            Console.WriteLine();


            Console.WriteLine("\tSecond example:");
            string split2 = "C#; Course work. String Format, Variant 8";
            char[] separators2 = new char[] { '.', ',', ';', ' ' };
            string[] resSplit2 = split2.Split(separators2);
            foreach (string st in resSplit2)
                Console.WriteLine(st);
            Console.WriteLine();


            Console.WriteLine("\tThird example:");
            string split3 = "C#; Course work. String Format, Variant 8";
            char[] separators3 = new char[] { '.', ',', ';', ' ' };
            string[] resSplit3 = split3.Split(separators3, StringSplitOptions.RemoveEmptyEntries);
            foreach (string st in resSplit3)
                Console.WriteLine(st);
            Console.WriteLine();


            Console.WriteLine("\tFourth example:");
            string split4 = "C#. Course work. String Format. Variant 8";
            string separator4 = ". ";
            string[] resSplit4 = split4.Split(separator4);
            foreach (string st in resSplit4)
                Console.WriteLine(st);
            Console.WriteLine();


            Console.WriteLine("\tFifth example:");
            string split5 = "C#. Course work, String Format; Variant 8";
            string[] separators5 = new string[] { ". ", "; ", ", " };
            string[] resSplit5 = split5.Split(separators5, StringSplitOptions.None);
            foreach (string st in resSplit5)
                Console.WriteLine(st);
            Console.WriteLine();


            Console.WriteLine("\tSixth example:");
            string split6 = "C#. Course work, String Format; Variant 8";
            string[] separators6 = new string[] { ". ", "; ", ", " };
            string[] resSplit6 = split6.Split(separators6, 2, StringSplitOptions.None);
            foreach (string st in resSplit6)
                Console.WriteLine(st);
            Console.WriteLine();


            String fullstring1 = "This is a course work.";
            String substring1 = fullstring1.Substring(10);
            String substring2 = fullstring1.Substring(10, 6);
            Console.WriteLine(substring1);
            Console.WriteLine(substring2);


            String partstring1 = "Name of my course work: ; My variant: 8";
            String partstring2 = "String Format";
            String resInsert = partstring1.Insert(24, partstring2);
            Console.WriteLine(resInsert);


            String fullstring2 = "Name of my course work: String Format; My variant: 8";
            String remove1 = fullstring2.Remove(24, 13);
            String remove2 = fullstring2.Remove(22);
            Console.WriteLine(remove1);
            Console.WriteLine(remove2);


            String replace1 = "course8work8str8";
            String replace2 = "cource work cource";
            String replace3 = "cource work cOURce";
            String resReplace1 = replace1.Replace('8', ' ');
            String resReplace2 = replace2.Replace("cource", "course");
            String resReplace3 = replace3.Replace("cource", "course", true, CultureInfo.CurrentCulture);
            Console.WriteLine(resReplace1);
            Console.WriteLine(resReplace2);
            Console.WriteLine(resReplace3);


            string[] planetsEn1 = new string[] { "Uranus", "Earth", "Saturn" };
            string[] planetsUa1 = new string[] { "Уран", "Земля", "Сатурн" };
            for (int i = 0; i < 3; i++)
            {
                planetsEn1[i] = planetsEn1[i].ToUpper();
                planetsUa1[i] = planetsUa1[i].ToUpper(new CultureInfo("uk-UA"));
            }
            Console.Write("Planets EN: ");
            foreach (string planet in planetsEn1)
                Console.Write($"{planet} ");
            Console.WriteLine();
            Console.Write("Planets UA: ");
            foreach (string planet in planetsUa1)
                Console.Write($"{planet} ");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                planetsEn1[i] = planetsEn1[i].ToLower();
                planetsUa1[i] = planetsUa1[i].ToLower(new CultureInfo("uk-UA"));
            }
            Console.Write("Planets EN: ");
            foreach (string planet in planetsEn1)
                Console.Write($"{planet} ");
            Console.WriteLine();
            Console.Write("Planets UA: ");
            foreach (string planet in planetsUa1)
                Console.Write($"{planet} ");
            Console.WriteLine();


            string format1 = "course";
            string format2 = "work";
            Console.WriteLine(format1 + " " + format2);


            int a1 = 10;
            int b1 = 7;
            double c_1 = 5.78;
            double vol1 = a1 * b1 * c_1;
            Console.WriteLine("Rectangular parallelepiped: {0}, {1}, {2}. Volume: {3}", a1, b1, c1, vol1);


            int a2 = 89;
            double b2 = 41.5;
            double c_2 = 63.9;
            double vol2 = a2 * b2 * c_2;
            string messParal = String.Format("Rectangular parallelepiped: {0}, {1}, {2}. Volume: {3}", a2, b2, c2, vol2);
            Console.WriteLine(messParal);


            DateTime now = DateTime.Now;
            CultureInfo culture = new CultureInfo("uk-UA");
            string format3 = String.Format(culture, "Culture:\t{0}\nEnglish:\t{1}\nDisplay:\t{2}\nDateTime:\t{3}",
                culture.Name, culture.EnglishName, culture.DisplayName, now);
            Console.WriteLine(format3);


            double x1 = 14.89233042;
            double x2 = 42.60293338;
            double x3 = 3.6;
            double x4 = 1.4;
            string format4 = String.Format("x1:{0, 15} x2:{1,15}", x1, x2);
            string format5 = String.Format("x3:{0, -5} x4:{1,-5}", x3, x4);
            Console.WriteLine(format4);
            Console.WriteLine();
            Console.WriteLine(format5);


            int x5 = 17575;
            string format6 = String.Format("x5: {0:d}", x5);
            string format7 = String.Format("x5: {0:d8}", x5);
            Console.WriteLine(format6);
            Console.WriteLine(format7);


            double x6 = 15.897;
            string format8 = String.Format("x6: {0:f}", x6);
            string format9 = String.Format("x6: {0:f5}", x6);
            Console.WriteLine(format8);
            Console.WriteLine(format9);


            double percent1 = 0.94295688;
            string format10 = String.Format("Percentages: {0:P}", percent1);
            string format11 = String.Format("Percentages: {0:P4}", percent1);
            Console.WriteLine(format10);
            Console.WriteLine(format11);


            decimal x7 = 76118.7112m;
            string format12 = String.Format("{0,-15:0,000.00} {0,-15:#.00000} {0,-15:000.00#}", x7);
            Console.WriteLine(format12);


            long phone1 = 380987654321;
            long phone2 = 987654321;
            string format13 = String.Format("Phone:{0: +###(##)-###-##-##}", phone1);
            string format14 = String.Format("Phone:{0: +380(##)-###-##-##}", phone2);
            Console.WriteLine(format13);
            Console.WriteLine(format14);


            double exp = 0.0001102356;
            string format15 = String.Format("{0:0.##E+00}", exp);
            Console.WriteLine(format15);


            int a = 3, b = 4, c = 7;
            Console.WriteLine($"Rectangular parallelepiped: {a}, {b}, {c}. Volume: {a * b * c}");


            DateTime dtnow = DateTime.Now;

            Console.WriteLine($"m: {dtnow:m}");
            Console.WriteLine($"Y: {dtnow:Y}");
            Console.WriteLine($"M: {dtnow:M}");
            Console.WriteLine($"t: {dtnow:t}");
            Console.WriteLine($"U: {dtnow:U}");
            Console.WriteLine($"D: {dtnow:D}");
            Console.WriteLine($"d: {dtnow:d}");
            Console.WriteLine($"F: {dtnow:F}");
            Console.WriteLine($"f: {dtnow:f}");
            Console.WriteLine($"G: {dtnow:G}");
            Console.WriteLine($"g: {dtnow:g}");
            Console.WriteLine($"T: {dtnow:T}");
            Console.WriteLine($"y: {dtnow:y}");
            Console.WriteLine($"u: {dtnow:u}");
            Console.WriteLine($"O: {dtnow:O}");
            Console.WriteLine($"o: {dtnow:o}");
            Console.WriteLine($"R: {dtnow:R}");
            Console.WriteLine($"r: {dtnow:r}");
            Console.WriteLine($"s: {dtnow:s}");



            List<DateTime> datesList = new List<DateTime>();
            datesList.Add(DateTime.Now);
            datesList.Add(new DateTime(2022, 11, 21, 14, 41, 3));
            datesList.Add(new DateTime(2021, 10, 13, 14, 15, 31));
            datesList.Add(new DateTime(2020, 12, 15, 10, 2, 1));

            Console.WriteLine("DateTime Information:\n");
            string format16;
            foreach (DateTime item in datesList)
            {
                format16 = String.Format("Time: {0,8:t} on date: {0,9:d}", item);
                Console.WriteLine(format16);
            }


            DateTime date1;
            string strDate1;
            CultureInfo provider1 = new CultureInfo("uk-UA", false);
            strDate1 = "01.05.2022";

            try
            {
                date1 = DateTime.ParseExact(strDate1, "d", provider1);
                Console.WriteLine("{0} => {1}", strDate1, date1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка для дати: {0}", strDate1);
            }

            strDate1 = "1.11.2021";
            try
            {
                date1 = DateTime.ParseExact(strDate1, "d", provider1);
                Console.WriteLine("{0} => {1}", strDate1, date1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка для дати: {0}", strDate1);
            }

            try
            {
                date1 = DateTime.ParseExact(strDate1, "d.MM.yyyy", provider1);
                Console.WriteLine("{0} => {1}", strDate1, date1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка для дати: {0}", strDate1);
            }


            DateTime dateTime2 = DateTime.Now;
            Console.WriteLine(dateTime2.ToString("MM/dd/yyyy"));
            Console.WriteLine(dateTime2.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(dateTime2.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(dateTime2.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(dateTime2.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(dateTime2.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(dateTime2.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(dateTime2.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(dateTime2.ToString("MMMM dd"));
            Console.WriteLine(dateTime2.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            Console.WriteLine(dateTime2.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            Console.WriteLine(dateTime2.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            Console.WriteLine(dateTime2.ToString("HH:mm"));
            Console.WriteLine(dateTime2.ToString("hh:mm tt"));
            Console.WriteLine(dateTime2.ToString("H:mm"));
            Console.WriteLine(dateTime2.ToString("h:mm tt"));
            Console.WriteLine(dateTime2.ToString("HH:mm:ss"));
            Console.WriteLine(dateTime2.ToString("yyyy MMMM"));


            DateTime dateTime3 = DateTime.Now;

            Console.WriteLine(dateTime3.ToString("dddd dd MMMM",
                CultureInfo.CreateSpecificCulture("en-CA")));
            Console.WriteLine(dateTime3.ToString("dddd dd MMMM",
                CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(dateTime3.ToString("dddd dd MMMM",
                CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine();
            Console.WriteLine(dateTime3.ToString("ddd d MMM",
                CultureInfo.CreateSpecificCulture("en-CA")));
            Console.WriteLine(dateTime3.ToString("ddd d MMM",
                CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(dateTime3.ToString("ddd d MMM",
                CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine();
            Console.WriteLine(dateTime3.ToString("hh:mm:ss.ff tt",
                CultureInfo.CreateSpecificCulture("en-CA")));
            Console.WriteLine(dateTime3.ToString("hh:mm:ss.ff tt",
                CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(dateTime3.ToString("hh:mm:ss.ff tt",
                CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine();
            Console.WriteLine(dateTime3.ToString("MMM (M) MMMM",
                CultureInfo.CreateSpecificCulture("en-CA")));
            Console.WriteLine(dateTime3.ToString("MMM (M) MMMM",
                CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(dateTime3.ToString("MMM (M) MMMM",
                CultureInfo.CreateSpecificCulture("es-ES")));



            Programmer programmer1 = new Programmer("Барлоу", "Кевiн", 21, 14000, Position.Junior);
            Programmer programmer2 = new Programmer("Андерс", "Олiвер", 28, 27000, Position.Middle);
            Programmer programmer3 = new Programmer("Роуз", "Лiдiя", 35, 41000, Position.Senior);
            Programmer programmer4 = new Programmer("Вейн", "Джо", 46, 57000, Position.Lead);
            programmer1.ShowInfo1("G");
            programmer1.ShowInfo1("F");
            programmer1.ShowInfo1("D");
            programmer1.ShowInfo1("X");

            programmer2.ShowInfo1("G");
            programmer2.ShowInfo1("F");
            programmer2.ShowInfo1("D");
            programmer2.ShowInfo1("X");

            programmer3.ShowInfo1("G");
            programmer3.ShowInfo1("F");
            programmer3.ShowInfo1("D");
            programmer3.ShowInfo1("X");

            programmer4.ShowInfo1("G");
            programmer4.ShowInfo1("F");
            programmer4.ShowInfo1("D");
            programmer4.ShowInfo1("X");


            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Junior, "D"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Middle, "D"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Senior, "D"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Lead, "D"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Junior, "F"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Middle, "F"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Senior, "F"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Lead, "F"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Junior, "G"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Middle, "G"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Senior, "G"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Lead, "G"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Junior, "X"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Middle, "X"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Senior, "X"));
            Console.WriteLine("Значення перерахунку: {0}", Enum.Format(typeof(Position), Position.Lead, "X"));



            Console.ReadLine();

        }
    }
    public enum Position
    {
        Junior = 5,
        Middle = 7,
        Senior = 9,
        Lead = 12
    }

    public class Programmer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Position Position { get; set; }

        public Programmer(string lastName, string firstName, int age, double salary, Position position)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
            this.Salary = salary;
            this.Position = position;
        }

        public void ShowInfo1(string format)
        {
            Console.WriteLine($"{this.LastName} {this.FirstName}, " +
                $"вiк: {this.Age}, " +
                $"зарплата: {this.Salary}," +
                $" посада: {this.Position.ToString(format)}");
        }
    }
    public class Planet : IComparable<Planet>
    {
        public string Name { get; set; }

        public Planet(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public int CompareTo(Planet? planet)
        {
            if (planet is null)
                throw new ArgumentException("Помилка! Значення параметра не може бути null!");
            return this.Name.CompareTo(planet.Name);
        }

    }
}

