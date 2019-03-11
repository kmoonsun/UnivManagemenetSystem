using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivManagementSyetem
{
    class ErrorMsg
    {
        public static string WrongValueError(string comment)
        {
            if (comment == null)
                comment = "값 없음";

            Console.WriteLine("Error :: 잘못된 입력( " + comment +" )");
            return comment;
        }

        public static void NoneValue()
        {
            Console.WriteLine("Error :: 값이 존재하지 않습니다.");
        }
    }
}
