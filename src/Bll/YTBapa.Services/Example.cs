using System;
using System.Collections.Generic;
using System.Text;

namespace YTBapa.Services
{
    public  class Example
    {


        #region 例子1（使用值传递）
        /// <summary>
        /// 例子1 算出税后工资
        /// </summary>
        /// <param name="pay"></param>
        /// <param name="taxRate"></param>
        /// <returns></returns>
        //public float GetPay(int pay, float taxRate)
        //{
        //    float afterTax;

        //    if (pay <= 3500)
        //    {
        //        afterTax = pay;
        //    }
        //    else
        //    {
        //        afterTax = pay - (pay - 3500) * taxRate;
        //    }
        //    return afterTax;

        //}
        //public void Inputpay()
        //{

        //    int pay; //税前工资
        //    float taxRate = 0.1f;  //税利
        //    float afterTax;  //税后工资

        //    Console.WriteLine("请输入税前工资(元)：");
        //    pay = int.Parse(Console.ReadLine());
        //    afterTax = GetPay(pay, taxRate);
        //    Console.WriteLine("税前工资：{0}，税后工资：{1}", pay, afterTax);
        //} 
        #endregion

        #region 例子2（使用引用传递）
        //public void reference()
        //{
        //    int num1, num2;
        //    Console.WriteLine("请输入两个数字：");
        //    num1 = int.Parse(Console.ReadLine());
        //    num2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("转换前：{0}，{1}", num1, num2);
        //    Sawp(ref num1, ref num2);
        //    Console.WriteLine("转换后：{0}，{1}", num1, num2);

        //}
        /// <summary>
        /// 使用引用传递转换数字
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        //public void Sawp(ref int num1, ref int num2)
        //{

        //    num1 = num1 - num2;
        //    num2 = num1 + num2;
        //    num1 = num2 - num1;
        //} 
        #endregion

        #region 例子3（使用IndexOf()获取“@”的位置，使用Trim()去掉空格，使用ToLower()强制转换成小写）
        /// <summary>
        /// 检查邮箱地址格式
        /// 把邮箱地址的用户取出
        /// </summary>
        /// 

        //string email; //邮箱
        //string name;  //邮箱用户名
        //public void TestEmail()
        //{
        //    Console.WriteLine("请输入邮箱地址：");
        //    email = Console.ReadLine();
        //    Console.WriteLine("您输入的邮箱为地址：{0}", email);
        //    int position = email.IndexOf("@");

        //    if (position > 0)
        //    {
        //        name = email.Substring(0, position);
        //        Console.WriteLine("您的邮箱用户名为：{0}", name);
        //        Console.WriteLine(" ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("您输入的邮箱格式有误！");
        //    }

        //}
        ///// <summary>
        ///// 使用Equals判断
        ///// </summary>
        //public void GetUserName()
        //{
        //    string choice;
        //    do
        //    {
        //        TestEmail();
        //        Console.WriteLine("是否继续？(yes/no)");
        //        choice = Console.ReadLine();
        //        choice = choice.Trim().ToLower();
        //    } while (choice.Equals("yes"));
        //} 
        #endregion
    }

}
