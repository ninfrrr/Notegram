using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ClassLibrary1
{
    public class Agenda
    {
        public int _id { get; set; }
        public string _judul { get; set; }
        public string _mataKuliah { get; set; }
        public string _tipe { get; set; }
        public string _keterangan { get; set; }
        public Reminder _reminder { get; set; }
        public string _deadLine { get; set; }



        static string myNgDBModel = ConfigurationManager.ConnectionStrings["NgDBModel"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myNgDBModel);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM ToDoList";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool Insert(Agenda c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myNgDBModel);

            try
            {
                string sql = "INSERT INTO ToDoList(_deadLine, _tipe, _judul, _mataKuliah, _keterangan) VALUES (@Status, @DueDate, @Type, @Task, @Course, @Description)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DueDate", c._deadLine);
                cmd.Parameters.AddWithValue("@Type", c._tipe);
                cmd.Parameters.AddWithValue("@Task", c._judul);
                cmd.Parameters.AddWithValue("@Course", c._mataKuliah);
                cmd.Parameters.AddWithValue("@Description", c._keterangan);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Edit(Agenda c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myNgDBModel);
            try
            {
                string sql = "UPDATE ToDoList SET _deadLine=@DueDate, _tipe=@Type, _judul=@Task, _mataKuliah=@Course, _keterangan=@Description WHERE _id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DueDate", c._deadLine);
                cmd.Parameters.AddWithValue("@Type", c._tipe);
                cmd.Parameters.AddWithValue("@Task", c._judul);
                cmd.Parameters.AddWithValue("@Course", c._mataKuliah);
                cmd.Parameters.AddWithValue("@Description", c._keterangan);
                cmd.Parameters.AddWithValue("@Id", c._id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete(Agenda c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myNgDBModel);
            try
            {
                string sql = "DELETE FROM ToDoList WHERE _id=@Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", c._id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
