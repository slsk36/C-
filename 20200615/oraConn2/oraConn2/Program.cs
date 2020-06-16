using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraConn2
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbManager db = new DbManager();
            //db.dbConnect(); 아래 코드처럼 한줄요약가능

            //new DbManager().dbConnect(); 아래 코드와 같은 동작임

            DbManager.getInstance().dbConnect(); //싱글톤 디자인 패턴 위와 같은 코드

            while (true)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("오라클 DB관리 프로그램 v1.3");
                Console.WriteLine("------------------");
                Console.WriteLine("1. 테이블 생성 ");
                Console.WriteLine("2. 테이블 삭제 ");
                Console.WriteLine("3. 데이터 추가");
                Console.WriteLine("4. 데이터 보기");
                Console.WriteLine("5. 데이터 수정");
                Console.WriteLine("6. 데이터 삭제");
                Console.WriteLine("7. 오라클 DB해제 및 프로그램 종료");

                Console.WriteLine("------------------");
                Console.Write("메뉴 선택: ");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        DbManager.getInstance().createTable();
                        break;
                    case "2":
                        DbManager.getInstance().dropTable();
                        break;
                    case "3":
                        for (int i = 0; i < 100; i++)
                            DbManager.getInstance().insertDB();
                        break;
                    case "4":
                        DbManager.getInstance().showDB();
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        Environment.Exit(0); //종료
                        break;
                }
            }
        }
    }
}
