using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubjectApplication
{
    class SubjectUtil
    {

        public static Subject[] Sort(Subject[] Plan)
        {
            return Plan.AsQueryable<Subject>()
                .OrderBy(subject => subject.Semester)
                .ThenBy(subject => subject.DisciplineName)
                .ToArray();
        }

    }
}
