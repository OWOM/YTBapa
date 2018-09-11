using System;
using System.Collections.Generic;
using System.Text;

namespace YTBapa.Services
{
    public class Bank
    {
        User user = new User();

        /// <summary>
        /// 注册
        /// </summary>
        public void Registered()
        {
            Console.WriteLine("===================欢迎使用自动银行注册服务==========================");
            Console.WriteLine("请输入用户名：");
            user.Name = Console.ReadLine();
            Console.WriteLine("请输入账号：");
            user.Account = Console.ReadLine();
            Console.WriteLine("请输入用户名密码：");
            user.Password = Console.ReadLine();
            Console.WriteLine("请输入用户名身份证号码：");
            user.IdentityNum = Console.ReadLine();
            Console.WriteLine("请输入用户存款金额：");
            user.Money = double.Parse(Console.ReadLine());
            user.Show();
        }

        /// <summary>
        /// 判断账号和密码是否有错
        /// </summary>
        /// <param name="account"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string Determine(string account, string pwd)
        {
            if (account != user.Account)
            {
                return "-1";
            }
            else if (pwd != user.Password)
            {
                return "-2";
            }
            return null;
        }


        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double DepositMoney(double money)
        {
            if (money > 0)
            {
                user.Money += money;
                return user.Money;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double MinusMoney(double money)
        {
            if (money > 0)
            {
                if (money <= user.Money)
                {
                    user.Money -= money;
                    return user.Money;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }

        }

        /// <summary>
        /// 输入存款账户密码
        /// </summary>
        public void Show1()
        {
            string account; //账号
            string pwd;     //密码
            double money; //取款金额

            Console.WriteLine("请输入账号：");
            account = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            pwd = Console.ReadLine();

            //判断账号和密码是否有误
            string account_user = Determine(account, pwd);
            if (account_user == "-1")
            {
                Console.WriteLine("账号输入错误！");
                return;
            }
            else if (account_user == "-2")
            {
                Console.WriteLine("密码输入有误！");
                return;
            }
            else
            {
                Console.WriteLine("请输入存款金额：");
                money = double.Parse(Console.ReadLine());
                double result = DepositMoney(money);
                if (result == -1)
                {
                    Console.WriteLine("存款失败！");
                }
                else
                {
                    Console.WriteLine("存款成功！当前余额：{0}", result);
                }
            }
        }

        /// <summary>
        /// 取款
        /// </summary>
        public void Show2()
        {
            string account; //账号
            string pwd;     //密码
            double money; //取款金额

            Console.WriteLine("请输入账号：");
            account = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            pwd = Console.ReadLine();

            //判断账号和密码是否有误
            string account_user =Determine(account, pwd);
            if (account_user == "-1")
            {
                Console.WriteLine("账号输入错误！");
                return;
            }
            else if (account_user == "-2")
            {
                Console.WriteLine("密码输入有误！");
                return;
            }
            else
            {
                Console.WriteLine("请输入取款金额：");
                money = double.Parse(Console.ReadLine());
                double result = MinusMoney(money);
                if (result == -1)
                {
                    Console.WriteLine("取款失败！");
                }
                else
                {
                    Console.WriteLine("取款成功！当前余额：{0}", result);
                }
            }
        }




        /// <summary>
        /// 选项
        /// </summary>
        public void Options()
        {
            do
            {
                Console.WriteLine("===================欢迎使用自动银行服务==========================");
                Console.WriteLine("1：存款 2：取款 5：退出");
                Console.WriteLine("=================================================================");
                string figure = Console.ReadLine();
                Console.WriteLine("     ");
                switch (figure)
                {
                    case "1":
                        Show1();
                        continue;
                    case "2":
                        Show2();
                        continue;
                    case "3":
                        continue;
                    case "4":
                        continue;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("输入无效！");
                        continue;
                }
                break;
            } while (true);
        }

    }
}

