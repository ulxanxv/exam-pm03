using System;
using System.IO;

namespace SubjectApplication
{
    class Program
    {

        private static string Path = "..\\..\\..\\Plan.txt";
        private static Subject[] Plan;

        static void Main(string[] args)
        {
            int length;
            while (true)
            {
                Console.Write("Введите размер массива :: ");
                if (int.TryParse(Console.ReadLine(), out length))
                {
                    break;
                }
                Console.Write("\t:: неверное значение, повтор...\n");
            }

            Console.Write("\tУспешно. Ввод массива...\n");
            Plan = SubjectUtil.FillMassive(length);
            Console.Write("\n\tУспешно. Вывод массива...\n");
            foreach (Subject subject in Plan)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", subject.DisciplineName, subject.TeacherLastName, subject.Semester));
            }


            Console.Write("\n\tУспешно. Сортировка...\n");
            foreach (Subject subject in SubjectUtil.Sort(Plan))
            {
                Console.WriteLine(string.Format("{0} {1} {2}", subject.DisciplineName, subject.TeacherLastName, subject.Semester));
            }

            Console.Write("\n\tУспешно. Сохранение в файл...\n");
            SubjectUtil.SaveIntoFile(Plan, Path);
        }

    }
}
