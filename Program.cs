using System;

namespace Cs_3_report2
{
    class Program
    {
        class person
        {
            //선언
            private int age;
            private string lib_id, name, phone;

            //초기값 할당
            public person()
            {
                age = 0;
                lib_id = "40001";
                name = "홍길동";
                phone = "010-1234-5678";

            }
            public person(int age, string name, string lib_id, string phone)
            {
                this.age = age;
                this.name = name;
                this.lib_id = lib_id;
                this.phone = phone;
            }
            public void show()
            {
                Console.WriteLine("이름 : {2}\n프라이머리 key : {3}\n나이 : {0}\n전화번호 : {1}", age, phone, name, lib_id);
            }
            public string getname() { return this.name; }

            //고객 정보 수정
            public void seteyes(int age) { this.age = age; }
            public void setnose(string name) { this.name = name; }
            public void setmouse(string lib_id) { this.lib_id = lib_id; }
            public void setears(string phone) { this.phone = phone; }
        }

        class library
        {
            public string book;
            public int booknum;
            public bool check;

            public library(int booknum, string book)
            {
                this.book = book;
                this.booknum = booknum;
                this.check = false; //대여여부
            }

            public void borrow() //대여여부
            {
                this.check = true;
            }

        
        }

        static void Main(string[] args)
        {
            string check = "";
            string[] l1 = { "머신러닝", "C#의 정석", "공학개론", "공업수학", "김재희" };

            library[] books = new library[5];       // class 배열 선언

            for (int i = 0; i < 5; i++)
            {
                library lib1 = new library(i, l1[i]);       
                if (i % 2 == 0) lib1.borrow();              //임의로 대여
                books[i] = lib1;                        //배열형식으로 저장

            }


            while (true)
            {
                Console.WriteLine("도서대여 프로그램입니다.");

                Console.Write("책의 정보를 확인 하겠습니까? (y/n) : ");
                check = Console.ReadLine();
                person per = new person();


                if (check == "y")
                {
                    for (int i = 0; i < books.Length; i++)
                    {

                        Console.WriteLine("{1}번째 도서 이름 : {0} ", books[i].book, i + 1);
                        if (i == books.Length - 1)
                        {
                            Console.WriteLine("\n");
                        }
                    }
                }
                else if (check == "n")
                {
                    Console.WriteLine("네 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("대소문자 혹은 문자를 확인하세요");
                }


                Console.Write("대여여부 확인 하겠습니까? (y/n) : ");
                check = Console.ReadLine();

                if (check == "y")
                {
                    for (int i = 0; i < books.Length; i++)
                    {

                        Console.WriteLine("{1}번째 도서 이름 : {0,6} \n대여여부 :{2}", books[i].book, i + 1, books[i].check);
                        if (i == books.Length - 1)
                        {
                            Console.WriteLine("\n");
                        }
                    }
                }
                else if (check == "n")
                {
                    Console.WriteLine("네 종료합니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("대소문자 혹은 문자를 확인하세요");
                }





            }
        }
    }
}
