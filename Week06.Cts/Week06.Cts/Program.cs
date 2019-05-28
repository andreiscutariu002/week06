namespace Week06.Cts
{
    public class Student
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Student s = new Student
            //{
            //    Name = "1",
            //    SecondName = "2"
            //};

            //OutMethod(out s);

            //RefTypeMethod(ref s);

            //SimpleMethod(s);

            int a = 100;
            OutMethod(out a);
        }

        public static void OutMethod(out int s)
        {
            s = 10230;
        }

        public static void OutMethod(out Student s)
        {
            s = new Student();

            s.Name = "Student 123";
        }

        public static void RefTypeMethod(ref Student s)
        {
            s.Name = "Updated by ref";

            s = new Student();
            s.Name = "Updated not ok";
            s.SecondName = "Updated not ok";
        }

        public static void RefTypeMethod(ref int value)
        {
            value = 1200;
        }

        public static void SimpleMethod(Student s)
        {
            s.Name = "Updated by ref";

            s = new Student();
            s.Name = "Updated not ok";
            s.SecondName = "Updated not ok";
        }

        public static void SimpleMethod(int value)
        {
            value = 123;
        }
    }
}