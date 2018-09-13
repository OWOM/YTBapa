using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YTBapa.Services
{
    public class Bank
    {
        User user = new User();
        List<User> users = new List<User>();
        #region 注册
        /// <summary>
        /// 注册
        /// </summary>
        //public void registered()
        //{
        //    console.writeline("===================欢迎使用自动银行注册服务==========================");
        //    console.writeline("请输入用户名：");
        //    user.name = console.readline();
        //    console.writeline("请输入账号：");
        //    user.account = console.readline();
        //    console.writeline("请输入用户名密码：");
        //    user.password = console.readline();
        //    console.writeline("请输入用户名身份证号码：");
        //    user.identitynum = console.readline();
        //    console.writeline("请输入用户存款金额：");
        //    user.money = double.parse(console.readline());
        //    user.show();
        //} 
        #endregion

        /// <summary>
        /// 初始用户信息
        /// </summary>
        public void registered()
        {
            Console.WriteLine("初始化账户信息成功！");
            User u = new User();
            u.Name = "王丽丽";
            u.Account = "12345";
            u.Money = 10000;
            u.Password = "1234";
            u.IdentityNum = "12345678987652";
            users.Add(u);
            Console.WriteLine(" ");
            User u1 = new User();
            u1.Name = "张珊珊";
            u1.Account = "54321";
            u1.Money = 800;
            u1.Password = "1234";
            u1.IdentityNum = "12345678987652";
            users.Add(u1);
            Console.WriteLine("  ");
            var u2 = new User();
            u2.Name = "张慧慧";
            u2.Account = "98765";
            u2.Money = 1340;
            u2.Password = "1234";
            u2.IdentityNum = "12345678987652";
            users.Add(u2);

        }


        /// <summary>
        /// 判断账号密码
        /// </summary>
        /// <param name="account"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string Temporary(string account, string pwd)
        {
            var u = users.FirstOrDefault(c => c.Account == account);
            return u == null ? "-1" : (u.Password != pwd ? "-2" : "0");
        }
        /// <summary>
        /// 判断转出账号和转入账户是否同一个
        /// </summary>
        /// <param name="toAccount"></param>
        /// <param name="fromAccount"></param>
        /// <returns></returns>
        public string OutAccount(string toAccount, string account)
        {
            var u = users.FirstOrDefault(c => c.Account == account);
            var v = users.FirstOrDefault(c => c.Account == toAccount);
            return v == null ? "-1" : v == u ? "-2" : "0";
        }
        /// <summary>
        /// 转账
        /// </summary>
        /// <param name="fromAccount"></param>
        /// <param name="money"></param>
        /// <param name="toAccount"></param>
        /// <param name="fblance"></param>
        /// <returns></returns>
        public double Transfer(string account, double money, string toAccount, ref double fblance)
        {
            if (money <= 0) { return -1; }
            var u = users.FirstOrDefault(c => c.Account == account);
            var v = users.FirstOrDefault(c => c.Account == toAccount);
            if (u == null && v == null) { return 0; }
            v.Money = v.Money + money;
            fblance = u.Money - money;
            return v.Money;
        }
        /// <summary>
        /// 存款
        /// </summary>
        /// <param name="account"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public double MinusMoney(string account, double money)
        {
            if (money <= 0) { return -1; }
            var item = users.FirstOrDefault(c => c.Account == account);
            if (item == null) { return 0; }
            item.Money += money;
            return item.Money;
        }
        /// <summary>
        /// 取款
        /// </summary>
        /// <param name="account"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public double Determine(string account, double money)
        {
            var item = users.FirstOrDefault(c => c.Account == account);
            if (money <= 0 || money > item.Money) { return -1; }
            if (item == null) { return 0; }
            item.Money -= money;
            return item.Money;
        }
        /// <summary>
        /// 查询余额
        /// </summary>
        /// <param name="account"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public double Query(string account, double money)
        {
            var item = users.FirstOrDefault(c => c.Account == account);
            money = item.Money;
            return money;
        }


        ///// <summary>
        /// 存款
        /// </summary>
        public void Deposit()
        {
            string account; //账号
            string pwd;     //密码
            double money; //取款金额

            Console.WriteLine("请输入账号：");
            account = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            pwd = Console.ReadLine();

            //判断账号和密码是否有误
            string account_user = Temporary(account, pwd);
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
                double result = MinusMoney(account, money);
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
        public void Withdrawals()
        {
            string account; //账号
            string pwd;     //密码
            double money; //取款金额

            Console.WriteLine("请输入账号：");
            account = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            pwd = Console.ReadLine();

            //判断账号和密码是否有误
            string account_user = Temporary(account, pwd);
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
                double result = Determine(account, money);
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
        /// 转账
        /// </summary>
        public void Transfer()
        {
            string account;    //转出账号
            string pwd;        //转出密码
            string toAccount;      //转入账户
            double fblance = 0;        //转出账号余额
            double money;          //转入金额

            Console.WriteLine("请输入转出账号：");
            account = Console.ReadLine();
            Console.WriteLine("请输入转出密码：");
            pwd = Console.ReadLine();

            //判断账号和密码是否有误
            string from_user = Temporary(account, pwd);
            if (from_user == "-1")
            {
                Console.WriteLine("账号输入错误！");
                return;
            }
            else if (from_user == "-2")
            {
                Console.WriteLine("密码输入有误！");
                return;
            }
            Console.WriteLine("请输入转入账户：");
            toAccount = Console.ReadLine();
            string out_user = OutAccount(toAccount, account);
            if (out_user == "-1")
            {
                Console.WriteLine("账号不存在！");
                return;
            }
            else if (out_user == "-2")
            {
                Console.WriteLine("您不能向自己的用户转账！");
            }
            else
            {
                Console.WriteLine("请输入转入金额：");
                money = double.Parse(Console.ReadLine());
                double result = Transfer(account, money, toAccount, ref fblance);
                if (result == -1)
                {
                    Console.WriteLine("转账失败！");
                }
                else
                {
                    Console.WriteLine("转账成功！转出账号：{0},余额为：{1}，转入账户：{2}，金额为：{3}", account, fblance, toAccount, result);
                }
            }

        }

        /// <summary>
        /// 查询余额
        /// </summary>
        public void QueryBalance()
        {
            string account;    //账号
            string pwd;        //密码
            double money = 0;      //余额
            Console.WriteLine("请输入要查询账号：");
            account = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            pwd = Console.ReadLine();

            //判断账号和密码是否有误
            string from_user = Temporary(account, pwd);
            if (from_user == "-1")
            {
                Console.WriteLine("账号输入错误！");
                return;
            }
            else if (from_user == "-2")
            {
                Console.WriteLine("密码输入有误！");
                return;
            }
            else
            {
                double result = Query(account, money);
                Console.WriteLine("您的账户余额为：{0}元", result);
            }
        }
        /// <summary>
        /// 选项
        /// </summary>
        public void options()
        {
            do
            {
                Console.WriteLine("===================欢迎使用自动银行服务==========================");
                Console.WriteLine("1：存款 2：取款 3：转账 4：查询余额 5：退出");
                Console.WriteLine("=================================================================");
                string figure = Console.ReadLine();
                Console.WriteLine("     ");
                switch (figure)
                {
                    case "1":
                        Deposit();
                        continue;
                    case "2":
                        Withdrawals();
                        continue;
                    case "3":
                        Transfer();
                        continue;
                    case "4":
                        QueryBalance();
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


        /// <summary>
        /// 显示用户
        /// </summary>
        public void According()
        {
            foreach (User item in users)
            {
                Console.WriteLine("用户名：{0}，账户：{1}，存储金额：{2}，密码：{3}，身份证：{4}", item.Name, item.Account, item.Money, item.Password, item.IdentityNum);
                Console.WriteLine("  ");
            }
        }
    }
}
