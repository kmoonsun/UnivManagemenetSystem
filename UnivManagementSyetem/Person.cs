using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivManagementSyetem
{
    class Person
    {
        private string name;        // 이름
        private string id;          // 학번
        private string phone;       // 전화번호
        private string mail;        // 이메일
        private string department;  // 학과
        private string joinDate;    // 입사, 입학일
        private string rank;        // 직책 (교수, 학생회장, 처장 등)

        public Person(string name, string id, string phone, string mail, string department, string joinDate, string rank)
        {
            this.name = name;
            this.id = id;
            this.phone = phone;
            this.mail = mail;
            this.department = department;
            this.joinDate = joinDate;
            this.rank = rank;
        }

        public Person()
        {

        }

        /** geetter & setter **/
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    name = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    id = value;
                else
                   ErrorMsg.WrongValueError(value);
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    phone = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    mail = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    department = value;
                else
                   ErrorMsg.WrongValueError(value);
            }
        }

        public string JoinDate
        {
            get
            {
                return JoinDate;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    joinDate = value;
                else
                   ErrorMsg.WrongValueError(value);
            }
        }

        public string Rank
        {
            get
            {
                return rank;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    rank = value;
                else
                    ErrorMsg.WrongValueError(value);
            }
        }
    }// class_Person
}// namespace_UnivManagementSyetem
