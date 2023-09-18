using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class main
    {
        static void Main(string[] args)
        {
            List<Student> studentlist = new List<Student>();
            List<Teacher> teacherList = new List<Teacher>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1: Them sinh vien");
                Console.WriteLine("2: Them giao vien");
                Console.WriteLine("3: Xuat danh sach sinh vien");
                Console.WriteLine("4: Xuat danh sach giao vien");
                Console.WriteLine("5: So luong Sinh Vien trong danh sach");
                Console.WriteLine("6: Xuat danh sach sinh vien thuoc Khoa CNTT");
                Console.WriteLine("7: Xuat danh sach giao vien dia chi o Quan 9");
                Console.WriteLine("8: Xuat danh sach sinh vien cos DBT cao nhat thuoc khoa CNTT");
                Console.WriteLine("9: So luong tung loai hoc sinh trong lop");
                Console.WriteLine("0: Thoat");
                Console.WriteLine("Chon chuc nang (0-8): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addSV(studentlist);
                        break;
                    case "2":
                        themSV(teacherList);
                        break;
                    case "3":
                        xuatDSSV(studentlist); 
                        break;
                    case "4":                        
                        xuatDSGV(teacherList); 
                        break;
                    case "5":
                        xuatTongSV(studentlist);
                        break;
                    case "6":
                        xuatSVCNTT(studentlist, "CNTT");
                        break;
                    case "7":
                        xuatGVQ9(teacherList, "Quan 9");
                        break;
                    case "8":
                        xuatDTBHighestCNTT(studentlist, "CNTT");
                        break;
                    case "9":
                        xuatSLstudentClass(studentlist);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh. ");
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le. Vui long chon lai !!");
                        break;
                }
                Console.WriteLine();
            }

        }

       
        //case 1: add student
        private static void addSV(List<Student> studentlist)
            {
                Console.WriteLine("==> Nhap so luong sinh vien: ");
                int n = Convert.ToInt32(Console.ReadLine());
                List<Student> studnets = new List<Student>(n);

                for (int i = 0; i < n; i++)
                {
                    Student st = new Student();
                    Console.WriteLine($"Nhap sinh vien thu {i + 1}");
                    st.addSV();
                    studentlist.Add(st);

                }
            }

        //case 2: add teacher
        private static void themSV(List<Teacher> teacherList)
        {
            Console.WriteLine("==> Nhap so luong giao vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Teacher> teachers = new List<Teacher>(n);

            for (int i = 0; i < n; i++)
            {
                Teacher st = new Teacher();
                Console.WriteLine($"Nhap giao vien thu {i + 1}");
               st.addGV();
                teachers.Add(st);
                

            }

        }

        // Case 3: Xuat DS sinh vien
        private static void xuatDSSV(List<Student> studentlist)
        {
            Console.WriteLine("\n\t===Danh sach SV ===");
            foreach (Student student in studentlist)
            {
                student.ShowSV();
            }

        }
        // case 4: Xuat DS giao vien
        private static void xuatDSGV(List<Teacher> teacherList)
        {
            Console.WriteLine("\n\t===Danh sach Giao Vien ===");
            foreach (Teacher teacher in teacherList)
            {
                teacher.ShowGV();
            }
        }

        //Case 5: Tong so luong sinh vien 

        private static void xuatTongSV(List<Student> studentlist)
        {
            int totalStudents = studentlist.Count; 
            Console.WriteLine("Tong so luong sinh vien: "+ totalStudents);
            Console.ReadLine();
        }

        //Case 6: Xuat danh sach cac sinh vien thuoc khoa CNTT
        private static void xuatSVCNTT(List<Student> studentlist,string falcuty)
        {
            Console.WriteLine("\n==> Danh sach sinh vien thuoc khoa {0}", falcuty);
            var students = studentlist.Where(s => s.Faculty.Equals(falcuty, StringComparison.OrdinalIgnoreCase));
            xuatSVCNTT(studentlist,"CNTT");
        }
        //Case 7: Xuat DS Giao Vien o Quan 9

        private static void xuatGVQ9(List<Teacher> teacherList, string Address)
        {
            Console.WriteLine("\t\tDanh sach giao vien dia chi quan 9", Address);
            var teacher = teacherList.Where(s => s.Address.Equals(Address, StringComparison.OrdinalIgnoreCase));
            xuatGVQ9(teacherList,"Quan 9");
        }


        //Case 8: Xuat danh sach sinh vien cos DBT cao nhat thuoc khoa CNTT
        private static void xuatDTBHighestCNTT(List<Student> studentlist, string faculty)
        {
            Console.WriteLine("\t\tDanh sach sinh vien cos DBT cao nhat thuoc khoa CNTT");
            var StudentMax = studentlist.Max(s => s.averageScore);
            var students = studentlist.Where(s => s.averageScore == StudentMax && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var item in students)
            {
                xuatDTBHighestCNTT(students, "CNTT");
            }
        }

        //Case 9: So luong tung loai hoc sinh trong lop
        private static void xuatSLstudentClass(List<Student> studentlist)
        {
            var Xuatsac = studentlist.Count(s => s.averageScore >= 9 && s.averageScore <= 10);
            var Gioi = studentlist.Count(s => s.averageScore >= 8 && s.averageScore < 9);
            var Kha = studentlist.Count(s => s.averageScore >= 7 && s.averageScore < 8);
            var TrungBinh = studentlist.Count(s => s.averageScore >= 5 && s.averageScore < 7);
            var Yeu = studentlist.Count(s => s.averageScore >= 4 && s.averageScore < 5);
            var Kem = studentlist.Count(s => s.averageScore < 4);
            Console.WriteLine("Xuất Sắc: {0}, Giỏi: {1}, Khá: {2}, Trung Bình: {3}, Yếu: {4}, Yếu: {5}, Kém: {6}", Xuatsac, Gioi, Kha, TrungBinh, Yeu, Kem);
        }

    }
}
