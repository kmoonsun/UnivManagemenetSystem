using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivManagementSyetem
{
    class Student : Person
    {      
        private int grade;          // 학년
        private int scholarship;    // 장학금
        private string mento;       // 지도교수님
        private int credit;         // 이수학점
        private int permission;     // 접근 권한

        // 수강중인 과목 추가해야함.

        /** getter & setter **/
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value > 0 && value < 5)
                    grade = value;
                else
                    ErrorMsg.WrongValueError("1~4");
            }
        }

        public int Scholarship
        {
            get
            {
                return scholarship;
            }
            set
            {
                if (value >= 0)
                    scholarship = value;
                else
                    ErrorMsg.WrongValueError("0이상의 값 입력");
            }
        }

        public string Mento
        {
            get
            {
                return mento;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    mento = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }

        public int Credit
        {
            get
            {
                return credit;
            }
            set
            {
                if (value >= 1 && value <= 3)   // 1~ 3 학점만 입력 가능. 
                    credit += value;            // 누적
                else
                    ErrorMsg.WrongValueError("잘못된 값");
            }
        }

        public int Permission
        {
            get
            {
                return permission;
            }
            set
            {
                if (value > 0 && value < 4)
                    permission = value;
                else
                    ErrorMsg.WrongValueError("1~3");
            }
        }

        // 커밋 테스트ㅇ
        /** change method **/
        public void ChangeName(Student target)
        {
            if (target == null)
                ErrorMsg.NoneValue();

            else
            {
                Console.Write(target.Name + " 에서 변경할 이름 입력 >> ");
                target.Name = Console.ReadLine();
            }
        }
        

        /** TestBad **/

        string[] array = new string[30];
        List<string> listSubject = new List<string>();

        static void Main(string[] args)
        {
            Student st = new Student()
            {
                Name = "정예인",
                Id = "20140631",
                Mail = "asd@gmail.com",
                Department = "컴통무",
                JoinDate = "2014-03-21",
                Phone = "010-8203-2506",
                Rank = "학생회장",
                Grade = 1,
                Mento = "이만희",
                Scholarship = 450
            };
            st.listSubject.Add("hi");

            Professor pr = new Professor()
            {
                
            };

            pr.AddMentee(st);
            //pr.AddMentee(new Student());
            Console.WriteLine(pr.listMentee[0].Name);
            pr.RmvMentee(st);
            pr.RmvMentee(st);



            if (pr.listMentee.Any())
                Console.WriteLine("있다.");

          
            st.array[0] = "asd";
            Console.WriteLine(st.array[0] + st.listSubject[0]);

            Faculty fc = new Faculty()
            {
                Department = "오징어!!",
                Pay = 100
                
            };

            

            st.Name = "아이린";
            st.Scholarship = 230;
            Console.WriteLine(st.Name + " " + st.Mento + st.Scholarship + st.Rank + " " + fc.Pay );
        }

    }

    
}
