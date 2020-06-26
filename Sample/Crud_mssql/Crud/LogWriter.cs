using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    class LogWriter
    {
        public static void PrintLog(string Contents)
        {
            DirectoryInfo di = new DirectoryInfo("LogFolder");
            if(!di.Exists) //di 경로에 해당폴더가 없으면
            {
                di.Create(); //폴더생성
            }
            using (StreamWriter writer = new StreamWriter("LogFolder\\Log.txt", true))
            {
                writer.WriteLine(Contents); //컨텐츠를 받아와서 로그텍스트 파일에 콘텐츠를 쓴다.
            }
        }
    }
}
