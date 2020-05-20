using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace zadanie5
{
    class Student
    {
        private int Id;
        private string FIO;
        private int Group;
        private string Data;
        private int a = 0;
        public int id
        {
            get { return Id; }
            set { if(value >=0) a++; Id = value; }
        }
        public int grp
        {
            get { return Group; }
            set { if (value >= 0) Group = value; }
        }
        public string fio
        {
            get { return FIO; }
            set { if (value != "" || value != " ") FIO = value; }
        }
        public string dat
        {
            get { return Data; }
            set { if (value != "" || value != " ") Data = value; }
        }
        public void Info()
        {
            Console.WriteLine($"\nID: 0{id} \tФИО: {FIO} \tГруппа номер: {Group}\tДата роджения: {Data}");
        }
        public void add()//добавляем данные
        {
            Student s = new Student();
            string n, d;
            Console.Write("Введите ФИО студента: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            a++;
            s.id = a;
            s.fio = n;
            s.grp = g;
            s.dat = d;
            s.Info();
        }
        public void redakt()//изменяем
        {
            string n, d;
            Student ak = new Student();
            Console.Write("Введите ФИО студента: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Введите номер группы: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату рождения: ");
            d = Convert.ToString(Console.ReadLine());
            a++;
            ak.id = a;
            ak.fio = n;
            ak.grp = g;
            ak.dat = d;
            ak.Info();
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student ak = new Student();
            ak.dat = "12.10.2000";
            ak.fio = "Зябликов Василий Петячкин";
            ak.grp = 1;
            ak.id = 1;
            Console.WriteLine("Что вы хотите сделать?\n1.Добавить студента\n2.Изменить данные студента\n3.Удалить студента");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: { ak.Info(); ak.add();  break; }
                case 2: { ak.Info(); ak.redakt(); break; }
                case 3:{ ak = null; break; } //удоляем
            }
        }
    }
}
