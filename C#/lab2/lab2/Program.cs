using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace lab2
{
    class Program
    {

        delegate int operation(int n1, int n2);

        static int multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        static void Main(string[] args)
        {
            //Student s = new Student("Nasser Alsubhi", "DB", "CS", "SQU", "nalsubhi996@gmail.com", 94944011);
            //s.print();

            operation op = multiplication;
            Console.WriteLine(op(2,3));
        }


        public class Student
        {

            private string fullName, course, subject, university, eMail;
            Nullable<decimal> phoneNumber;
            public static int count = 0;


            public Nullable<decimal> PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = ((phoneNumber==0) || (phoneNumber==null))? null :value; }
            }

            public string EMail
            {
                get { return eMail; }
                set { eMail = value.Contains("@")? value: null; }
            }

            public string University
            {
                get { return university; }
                set { university = value; }
            }

            public string Subject
            {
                get { return subject; }
                set { subject = value; }
            }

            public string FullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

            public string Course
            {
                get { return course; }
                set { course = value; }
            }
            
            


            public Student(string fn, string c, string sub, string us, string em, Nullable<decimal> ph)
            {
                fullName = fn;
                course = c;
                subject = sub;
                university = us;
                eMail = em;
                phoneNumber = ph;
                Student.count++;
            }

            public Student()
            {
                Student.count++;
            }

            public void print()
            {
                Console.WriteLine("Student Name: " + fullName +"\nStudent Course: " + course + "\nStudent Subject: " + subject + "\nStudent University: " + university + "\nStudent E-mail: " + eMail + "\nStudent Phone: " + phoneNumber);
            }

        }

    }


}
