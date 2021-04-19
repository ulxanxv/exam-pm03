using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SubjectApplication
{
    class SubjectUtil
    {

        public static Subject[] Sort(Subject[] plan)
        {
            return plan.AsQueryable<Subject>()
                .OrderBy(subject => subject.Semester)
                .ThenBy(subject => subject.DisciplineName)
                .ToArray();
        }

        public static void SaveIntoFile(Subject[] plan, string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                File.Create(path).Close();
            }

            foreach (Subject subject in plan)
            {
                File.AppendAllText(path, subject.ToString() + "\n");
            }
        }

        public static Subject[] FillMassive(int length)
        {
            Subject[] array = new Subject[length];

            for (int i = 0; i < length; ++i)
            {
                Subject subject = new Subject();

                Console.Write(string.Format("[{0}]: Введите название дисциплины :: ", i));
                subject.DisciplineName = Console.ReadLine();

                Console.Write(string.Format("[{0}]: Введите фамилию преподавателя :: ", i));
                subject.TeacherLastName = Console.ReadLine();

                while (true)
                {
                    int semester;
                    Console.Write(string.Format("[{0}]: Введите семестр :: ", i));
                    if (int.TryParse(Console.ReadLine(), out semester))
                    {
                        subject.Semester = semester;
                        break;
                    }

                    Console.Write("\t:: неверное значение, повтор...\n");
                }

                array[i] = subject;
            }

            return array;
        }

    }
}
