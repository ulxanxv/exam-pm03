using System;
using System.IO;

namespace SubjectApplication
{
    class Program
    {
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
            Subject[] plan = SubjectUtil.FillMassive(length);

            Console.Write("\n\tУспешно. Сортировка...\n");
            foreach (Subject subject in SubjectUtil.Sort(plan))
            {
                Console.WriteLine(string.Format("{0} {1} {2}", subject.DisciplineName, subject.TeacherLastName, subject.Semester));
            }

            Console.Write("\n\tУспешно. Сохранение в файл...\nВведите путь :: ");
            string path = Console.ReadLine();
            while (true)
            {
                try
                {
                    SubjectUtil.SaveIntoFile(plan, path);
                    break;
                }
                catch (IOException)
                {
                    Console.Write("\t:: неверное значение, повтор...\n");
                }
            }
        }

    }
}
