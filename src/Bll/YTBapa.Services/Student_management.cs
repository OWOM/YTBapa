using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTBapa.Services;


namespace YTBapa.Services
{
  public class Student_management
    {
        string name;  //用户名
        /// <summary>
        /// 判断用户密码是否有误
        /// </summary>
        public void Query_one()
        {
            //登陆账号
            Console.WriteLine("请输入用户名：");
            name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwo = Console.ReadLine();
            string sql = string.Format("Select StudentName,LoginPwe from Student Where StudentName='{0}' and LoginPwe='{1}'", name, pwo);
            try
            {
                var reader = DBOperation.ExecuteReader(sql);
                if (reader.HasRows != true)
                {
                    Console.WriteLine("登陆失败！用户名或密码有误！");
                }
                else
                {
                    Console.WriteLine("登陆成功！欢迎：{0}\n\n欢迎使用学生管理系统", name);
                    reader.Close();
                    Choose_one();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
            finally
            {
                DBOperation.CloseConnection();
                //Console.WriteLine("数据库关闭成功！");
            }
        }
        /// <summary>
        /// 选项
        /// </summary>
        public void Choose_one()
        {
            do
            {
                Console.WriteLine("======================请选择操作键======================");
                Console.WriteLine("1、统计学生人数");
                Console.WriteLine("2、查看学生名单");
                Console.WriteLine("3、按学号查询学生姓名");
                Console.WriteLine("4、按姓名查询学生信息");
                Console.WriteLine("5、修改学生出生日期");
                Console.WriteLine("6、删除学生记录");
                Console.WriteLine("7、新增年级记录");
                Console.WriteLine("0、退出");
                Console.WriteLine("=========================================================");
                int Digital = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                switch (Digital)
                {
                    case 1:
                        Query_two();
                        continue;
                    case 2:
                        Query_three();
                        continue;
                    case 3:
                        Query_four();
                        continue;
                    case 4:
                        Query_five();
                        continue;
                    case 5:
                        Modify_one();
                        continue;
                    case 6:
                        Delete_one();
                        continue;
                    case 7:
                        New_one();
                        continue;
                    case 0:
                        Console.WriteLine("退出成功！欢迎下次使用：{0}", name);
                        break;

                    default:
                        Console.WriteLine("您输入的数字无效！");
                        continue;
                }
                break;
            } while (true);
        }
        /// <summary>
        /// 统计学生人数
        /// </summary>
        public void Query_two()
        {
            string sql = "Select COUNT(StudentName) from Student";
            try
            {
                var iRed = DBOperation.ExecuteScalar(sql);
                if (iRed > 0)
                {
                    Console.WriteLine("学生人数为：{0}名", iRed);
                }
                else
                {
                    Console.WriteLine("获取失败！");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
        }

        /// <summary>
        /// 查询学生信息
        /// </summary>
        public void Query_three()
        {
            string sql = "Select StudentNo,StudentName from Student";
            Console.WriteLine("====================================================");
            Console.WriteLine("学号\t\t\t姓名");
            Console.WriteLine("====================================================");
            try
            {
                var reader = DBOperation.ExecuteReader(sql);
                StringBuilder buil = new StringBuilder();
                while (reader.Read())
                {
                    buil.AppendFormat("{0}\t\t{1}", reader["StudentNo"], reader["StudentName"]);
                    Console.WriteLine(buil);
                    buil.Length = 0;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
            finally
            {
                DBOperation.CloseConnection();
                //Console.WriteLine("数据库关闭成功！");
            }
        }

        /// <summary>
        /// 按学号查询学生姓名
        /// </summary>
        public void Query_four()
        {
            Console.WriteLine("请输入要查询的学生学号：");
            string Student_id = Console.ReadLine();
            string sql = string.Format("Select StudentName from Student Where StudentNo Like '%{0}'", Student_id);
            try
            {
                var reader = DBOperation.ExecuteReader(sql);
                StringBuilder buil = new StringBuilder();
                while (reader.Read())
                {
                    buil.AppendFormat("学号是：{0}的学生姓名为：{1}", Student_id, reader["StudentName"]);
                    Console.WriteLine(buil);
                    buil.Length = 0;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
            finally
            {
                DBOperation.CloseConnection();
                //Console.WriteLine("数据库关闭成功！");
            }
        }
        /// <summary>
        /// 根据学生姓名查询学生信息
        /// </summary>
        public void Query_five()
        {

            Console.WriteLine("请输入要查询的学生姓名：");
            string Student_Name = Console.ReadLine();
            string sql = string.Format("Select StudentNo,StudentName,Sex,GradeId,Phone,Address,BornDate,Email from Student Where StudentName Like '{0}%'", Student_Name);
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("学号\t\t姓名\t性别\t年级\t联系电话\t地址\t\t出生日期\t\t邮箱");
            Console.WriteLine("================================================================================================================");
            try
            {
                var reader = DBOperation.ExecuteReader(sql);
                StringBuilder buil = new StringBuilder();
                while (reader.Read())
                {
                    buil.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", reader["StudentNo"], reader["StudentName"], reader["Sex"], reader["GradeId"], reader["Phone"], reader["Address"], reader["BornDate"], reader["Email"]);
                    Console.WriteLine(buil);
                    buil.Length = 0;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
            finally
            {
                DBOperation.CloseConnection();
                //Console.WriteLine("数据库关闭成功！");
            }
        }
        /// <summary>
        /// 根据学生学号修改学生出生日期
        /// </summary>
        public void Modify_one()
        {
            Console.WriteLine("请输入要修改的学生学号：");
            string Student_Id = Console.ReadLine();
            Console.WriteLine("请输入修改日期（使用‘-’隔开）：");
            string Data_Birth = Console.ReadLine();
            string sql = string.Format("Update Student set BornDate='{0}' Where StudentNo='{1}'", Data_Birth, Student_Id);
            try
            {
                var modify = DBOperation.ExecuteNonQuery(sql);
                if (modify > 0)
                {
                    Console.WriteLine("修改成功！");
                }
                else
                {
                    Console.WriteLine("修改失败！请查看输入的学生学号或修改日期是否有误！");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
        }
        /// <summary>
        /// 根据学号删除学生信息
        /// </summary>
        public void Delete_one()
        {
            Console.WriteLine("请输入要修改的学生学号：");
            string Student_Id = Console.ReadLine();
            Console.WriteLine("确定要删除此学生信息？（yes/no）");
            string judge = Console.ReadLine();
            string sql = string.Format("Delete from Student Where StudentNo='{0}'", Student_Id);
            try
            {
                var delete = DBOperation.ExecuteNonQuery(sql);
                if (judge == "yes")
                {
                    if (delete > 0)
                    {
                        Console.WriteLine("删除成功!");
                    }
                    else
                    {
                        Console.WriteLine("删除失败！请查看输入的学生学号是否有误！");
                    }
                }
                else
                {
                    Console.WriteLine("您取消了修改！");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
        }
        /// <summary>
        /// 新增年级
        /// </summary>
        public void New_one()
        {
            Console.WriteLine("请输入待插入的年级名称：");
            string Grade_Name = Console.ReadLine();
            string sql = string.Format("Insert Grade Values('{0}')", Grade_Name);
            try
            {
                var New = DBOperation.ExecuteNonQuery(sql);
                if (New > 0)
                {
                    Console.WriteLine("插入成功！");
                }
                else
                {
                    Console.WriteLine("插入失败！");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("出现异常：{0}", ex.Message);
            }
        }
    }
}
