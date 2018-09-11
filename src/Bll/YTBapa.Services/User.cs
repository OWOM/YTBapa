using System;
using System.Collections.Generic;
using System.Text;

namespace YTBapa.Services
{
    /// <summary>
    /// 用户类
    /// </summary>
   public class User
    {
        //上机练习3
        //姓名
        private string user_name;
        //密码
        private string user_password;
        //身份证
        private string user_identityNum;
        //存储金额
        private double user_money;
        //账户
        private string user_account;

        public string Name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        public string Password
        {
            get { return user_password; }
            set { user_password = value; }
        }
        public string IdentityNum
        {
            get { return user_identityNum; }
            set { user_identityNum = value; }
        }
        public Double Money
        {
            get { return user_money; }
            set { user_money = value; }
        }
        public string Account
        {
            get { return user_account; }
            set { user_account = value; }
        }

        public void Show()
        {
            Console.WriteLine("用户名：{0}，账户：{1}，存储金额：{2}，密码：{3}，身份证：{4}", Name, Account, Money, Password, IdentityNum);
            Console.WriteLine(" ");
        }
        
    }
}
