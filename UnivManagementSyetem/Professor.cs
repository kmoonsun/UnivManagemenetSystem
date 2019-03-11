using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivManagementSyetem
{
    class Professor : Faculty
    {
        // 과목 리스트 추가
        
        public List<Student> listMentee = new List<Student>();

        public void AddMentee(Student mentee)
        {
            listMentee.Add(mentee);
        }

        public void RmvMentee(Student mentee)
        {
            if (listMentee.Any())
                listMentee.Remove(mentee);
            else
                ErrorMsg.NoneValue();
        }

        public Student SearchMentee(Student mentee)
        {
            // student 의 display 함수 호출.
            // 모든 멘티들을 보여준 뒤, 번호로 상세정보 가능하게 한다.
            return mentee;
        }

        // public Subject InquiryCourse() { };  수강중인 과목을 조회한다.
        // public ? ViewTimetable() {};         수강 시간표를 보여준다.
        
    }
}
