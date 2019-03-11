using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivManagementSyetem
{
    class Assistant : Faculty
    {
        private int grade;
        private string lab;

        // 조교 참여중인 과목 목록 만들어야함.
        
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value > 1)
                    grade = value;
                else
                    ErrorMsg.WrongValueError("1 이상");
            }
        }

        public string Lab
        {
            get
            {
                return lab;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    lab = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }
    }
}
