namespace SubjectApplication
{
    class Subject
    {

        public string DisciplineName { get; set; }

        public string TeacherLastName { get; set; }

        public int Semester { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2}", DisciplineName, TeacherLastName, Semester);
        }
    }
}
