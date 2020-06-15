using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraConn1
{
    class Program
    {
        static string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=HR;Password=1234;";

        static void dbConnect(OracleConnection conn)
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch(OracleException e)
            {
                Console.WriteLine("오라클 접속 오류:" + e.Message);
                return;
            }
        }

        static void dbClose(OracleConnection conn)
        {
            try
            {
                conn.Clone();
                Console.WriteLine("오라클 접속 해제");
            }
            catch(OracleException e)
            {
                Console.WriteLine("오라클 해제오류: " + e.Message);
            }
        }

        static void createTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {
                string query = "create table bigdata1 (" + "id number not null," + "name varchar(20) not null,"
                    + "age number not null," + "addr varchar(80) not null," + "constraint pk_bigdata1_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string query2 = "create sequence seq_id increment " +
                    "by 1 start with 1";
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 및 시퀀스 생성 성공");
            }catch(OracleException e)
            {
                Console.WriteLine("테이블 생성 에러 번호: " + e.Number);
                Console.WriteLine("테이블 생성 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 생성 에러 메세지: " + e.Message);
            }

        }

        static void dropTable(OracleConnection conn, OracleCommand cmd)
        {
            try
            {

                string query = "drop table bigdata1";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string query2 = "drop sequence seq_id";
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 및 쿼리 삭제 완료");
            } catch(OracleException e)
            {
                Console.WriteLine("테이블 삭제 에러 번호: " + e.Number);
                Console.WriteLine("테이블 삭제 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 삭제 에러 메세지: " + e.Message);
            }

        }

        static void insertDB(OracleConnection conn, OracleCommand cmd)
        {
            string name = "홍길동";
            int age = 300;
            string addr = "북한";
            string query = string.Format("insert into bigdata1 values (seq_id.nextval, '{0}','{1}','{2}')",
                name, age, addr);
            Console.WriteLine("데이터 추가 완료");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        static void showDB(OracleConnection conn, OracleCommand cmd)
        {
            int count = 1;
            
            string query = "select * from bigdata1 order by id desc";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();   //oracle 데이터를 읽기위해 객체 생성

            if (dr.HasRows) //오라클의 데이터가 행을 갖고 있으면
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("이름: " + dr["name"]);
                    Console.WriteLine("나이: " + dr["age"]);
                    Console.WriteLine("주소: " + dr["addr"]);
                    Console.WriteLine("====================");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 없습니다");
            }
            dr.Close();
        }
        
        static void updateDB(OracleConnection conn, OracleCommand cmd)
        {
            string query = string.Format("update bigdata1 set name='제임스' where name='홍길동'");
            Console.WriteLine("데이터 수정 완료");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        static void deleteDB(OracleConnection conn, OracleCommand cmd)
        {
            string query = string.Format("delete bigdata1 where name='제임스'");
            Console.WriteLine("데이터 삭제 완료");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        static void Main(string[] args)
        {
            OracleConnection conn = new OracleConnection(ORADB);
            OracleCommand cmd = new OracleCommand();

            dbConnect(conn); //db연결
            while (true)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("오라클 DB관리 프로그램 v1.0");
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
                //Console.WriteLine("------------------");

                switch (menu)
                {
                    case "1":
                        createTable(conn, cmd);// 테이블 생성
                        break;
                    case "2":
                        dropTable(conn, cmd); // 테이블 삭제
                        break;
                    case "3":
                        insertDB(conn, cmd);  // 데이터 추가
                        break;
                                              //ctrl + k +d 코드 자동정렬
                    case "4":
                        showDB(conn,cmd); //데이터 보기
                        break;
                    case "5":
                        updateDB(conn, cmd); //데이터 수정
                        break;
                    case "6":
                        deleteDB(conn, cmd); //데이터 삭제
                        break;
                    case "7":
                        dbClose(conn);       //db접속해제
                        Environment.Exit(0); //종료
                        break;
                }
            }
        }
    }
}
