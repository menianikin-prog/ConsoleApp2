using System;

namespace StudentApp
{
    
    public class Student
    {
        
        public string Fio;
        public float Grade1;
        public float Grade2;

        
        public void ShowData()
        {
            Console.WriteLine($"Студент: {Fio}");
            Console.WriteLine($"Оценка 1: {Grade1}");
            Console.WriteLine($"Оценка 2: {Grade2}");
        }

        
        public float SredOcenka()
        {
            return (Grade1 + Grade2) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student();

           
            student1.Fio = "Иванов";
            student1.Grade1 = 3;
            student1.Grade2 = 5;

            
            Console.WriteLine("--- Информация о студенте ---");
            student1.ShowData();

           
            float average = student1.SredOcenka();
            Console.WriteLine($"Средняя оценка: {average:F1}");

            Console.ReadKey(); 
        }
    }
}