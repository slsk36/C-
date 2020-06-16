using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraConn2
{
    class DbManager
    {
        static DbManager instance;
        static string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=HR;Password=1234;"; //기본 접속정보

        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;

        public static DbManager getInstance()
        {
            if(instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }       //싱글톤

        public DbManager() //기본생성자
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        ~DbManager() //소멸자
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류:" + e.Message);
                return;
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Clone();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제오류: " + e.Message);
            }
        }
        public void createTable()
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
                
                Console.WriteLine("테이블 및 시퀀스 생성 성공\n\n\n");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 에러 번호: " + e.Number);
                Console.WriteLine("테이블 생성 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 생성 에러 메세지: " + e.Message);
            }

        }

        public void dropTable()
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
                Console.WriteLine("테이블 및 쿼리 삭제 완료\n\n\n");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삭제 에러 번호: " + e.Number);
                Console.WriteLine("테이블 삭제 에러 코드: " + e.ErrorCode.ToString());
                Console.WriteLine("테이블 삭제 에러 메세지: " + e.Message);
            }

        }

        public void insertDB(string name, string age, string addr)
        {
            string query = string.Format("insert into bigdata1 values (seq_id.nextval, '{0}','{1}','{2}')",
                name, age, addr);
            Console.WriteLine("데이터 추가 완료");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void showDB()
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
                    Console.WriteLine("번호: " + count); //데이터 고유의 번호, 순번이 아님
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

        public void updateDB(string newName, string oldName)
        {
            string query = string.Format("update bigdata1 set name='{0}' where name='{1}'",
                newName, oldName); //위에 매개변수로 넣어서 처리함
            Console.WriteLine("데이터 수정 완료");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void deleteDB(string name)
        {
            string query = string.Format("delete bigdata1 where name='{0}'", name); //이름정보를 찾아와서 삭제를 시키겠다
            Console.WriteLine("데이터 삭제 완료");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
    }
}
