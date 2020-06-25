using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraWinform622
{
    class DbManger
    {
        static DbManger instance;
        static string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=hr;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;


        public static DbManger getInstance()
        {
            if (instance == null)
            {
                instance = new DbManger();
            }
            return instance;
        }

        public DbManger()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        ~DbManger()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!!!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " +
                    e.Message);
                return;
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제!!!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " +
                    e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string query = "create table bigdata1 (" +
                    "id number not null," +
                    "name varchar(20) not null," +
                    "age number not null," +
                    "addr varchar(80) not null," +
                    "constraint pk_bigdata1_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string query2 =
                    "create sequence seq_id increment " +
                    "by 1 start with 1";
                cmd.CommandText = query2;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 및 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 에러 번호: " +
                    e.Number);
                Console.WriteLine("테이블 생성 에러 코드: " +
                    e.ErrorCode.ToString());
                Console.WriteLine("테이블 생성 에러 메시지: " +
                    e.Message);
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
                Console.WriteLine("테이블 및 시퀀스 삭제 완료!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 에러 코드: " +
                    e.ErrorCode.ToString());
                Console.WriteLine("테이블 생성 에러 메시지: " +
                    e.Message);
            }
        }

        // 데이터 추가
        public void insertDB()
        {
            string name = "홍길동";
            int age = 300;
            string addr = "조선 한양 홍대감댁";
            string query = string.Format(
                "insert into bigdata1 values (" +
                "seq_id.nextval, '{0}','{1}','{2}')", name, age, addr);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        // 랜덤 데이터 추가
        public void insertDB(string name, int age, string addr)
        {
            string query = string.Format(
                "insert into bigdata1 values (" +
                "seq_id.nextval, '{0}','{1}','{2}')", name, age, addr);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void showDB()
        {
            int count = 1;
            cmd.Connection = conn;
            cmd.CommandText = "select * from bigdata1 order by id desc";
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("이름: " + dr["name"]);
                    Console.WriteLine("나이: " + dr["age"]);
                    Console.WriteLine("주소: " + dr["addr"]);
                    Console.WriteLine("-------------------");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 없습니다.");
            }
            dr.Close();
        }

        public void deleteDB(string name)
        {
            string query = string.Format(
                "delete from bigdata1 where name='{0}'", name);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void deleteAllDB()
        {
            string query = string.Format(
                "delete from bigdata1");
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void updateDB(string newName, string oldName)
        {
            string query = string.Format(
                "update bigdata1 set name='{0}' where name='{1}'",
                   newName, oldName);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
    }
}
