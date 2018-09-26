using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace lab2
{
    class Program
    {

        delegate double operation(double n1, double n2);

        static int multiplication(int n1, int n2)
        {
            return n1 * n2;
        }

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();


            Student s = new Student("Nasser Alsubhi", "DB", "CS", "SQU", "nalsubhi996@gmail.com", 94944011);

            students.Add(s);
            Console.Write(s.toString());


            Console.WriteLine("Number of object created: " + Student.count);
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
                count++;
            }

            public Student()
            {
                count++;
            }

            public string toString()
            {
                return("Student Name: " + fullName +"\nStudent Course: " + course + "\nStudent Subject: " + subject + "\nStudent University: " + university + "\nStudent E-mail: " + eMail + "\nStudent Phone: " + phoneNumber + "\n");
            }



        }

        public class Person
        {
            string name;
            int age;
            double gpa;
         
        }

        public class MobilePhone
        {
            public enum BatteryType {LiIon, NiMH, NiCd };
            private string model;
            private Nullable<decimal> price;
            BatteryType battery;

            public MobilePhone(string theModel)
            {
                model = theModel;
                price = null;
                battery = BatteryType.LiIon;
            }

            public MobilePhone(string theModel, Nullable<decimal> thePrice)
            {
                model = theModel;
                price = thePrice;
                battery = BatteryType.LiIon;
            }

            internal BatteryType Battery
            {
                get { return battery; }
                set { battery = value; }
            }
            Screen s;

            public string Model
            {
                get { return model; }
                set { model = value; }
            }
  

            public Nullable<decimal> Price
            {
                get { return price; }
                set { price = value; }
            }
           
           
        }

        public class Battery{
            private string model;
            private int hoursTalk;
            private string idleTime;

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            public string IdleTime
            {
                get { return idleTime; }
                set { idleTime = value; }
            }

            public int HoursTalk
            {
                get { return hoursTalk; }
                set { hoursTalk = value; }
            }
        }

        public class Screen{

            private double size;
            private string color;

            public double Size
            {
                get { return size; }
                set { size = value; }
            }
            
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
        }


    }


}
