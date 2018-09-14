using System;
using System.Collections.Generic;
using System.Text;

namespace YTBapa.Services
{
    public  class Example
    {

        ///第三章
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

        //第四章
        #region 例子1（使用IndexOf()获取“@”的位置，使用Trim()去掉空格，使用ToLower()强制转换成小写）
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

        #region 上机1（使用了IndexOf获得“:”字符，使用Substring获得，地址协议类型）
        //上机1
        //string url;    //网络地址的统一资源标识符
        //string protocol; //协议
        //public void InputData()
        //{  
        //Console.WriteLine("请输入一个HTTPH或者FTP地址：");
        //url = Console.ReadLine();
        //protocol = GetProtocol(url);
        //Console.WriteLine("您输入的使用地址协议类型是：{0}","\n"+protocol);
        //}

        //private string GetProtocol(string url)
        //{
        //    int postition;
        //    string protocol;
        //    postition = url.IndexOf(":");


        //    if (postition>0)
        //    {
        //        protocol = url.Substring(0, postition);
        //    }
        //    else
        //    {
        //        protocol = "没找到";
        //    }

        //    return protocol;
        //} 
        #endregion

        #region 例子2（使用Split分割字符,使用Join将分割后的字符用新的分割符合并）
        /// <summary>
        /// 例子2
        /// </summary>
        //public void Segmentation()
        //{
        //    string ingputString;   //输入的字符
        //    string[] splitStrings; //分割后的字符串数组
        //    string joinString;     //连接后的新数组

        //    Console.WriteLine("请入一串字符，使用空格隔开：");
        //    ingputString = Console.ReadLine();

        //    splitStrings = ingputString.Split(' ');

        //    Console.WriteLine("\n分割后的字符：");
        //    foreach (var u in splitStrings)
        //    {
        //        Console.WriteLine(u);
        //    }

        //    joinString = string.Join("_", splitStrings);

        //    Console.WriteLine("\n分割后连接的字符：{0}",joinString);

        //} 
        #endregion

        #region 上机2（输入用户姓名的英文名，使用ToUpper强制把姓名的第一位转成大写，其余使用ToLower转换成小写）
        //上机2
        //string name;        //处理前姓名
        //string[] user_name; //分割姓名
        //string Formatting_Name; //处理后的姓名
        //public void Conversion()
        //{
        //    Console.WriteLine("请用英文名输入你的姓名，使用空格隔开：");
        //    name = Console.ReadLine();
        //    Formatting_Name= FormateName(name);
        //    Console.WriteLine("格式化处理后你的名字：{0}","\n"+Formatting_Name);


        //}
        //public string FormateName(string name)
        //{
        //    user_name = name.Split(new char[]{' '});
        //    for (int i = 0; i < user_name.Length; i++)
        //    {
        //        user_name[i] = user_name[i].Substring(0, 1).ToUpper() + user_name[i].Substring(1).ToLower();
        //    }

        //    name= string.Join("", user_name);
        //    return name;
        //} 
        #endregion

        #region 例子3（类型转换，隐式类型：小值转大值，显示类型转换：大值转小值）
        /// <summary>
        /// 例子3
        /// </summary>
        //public void TotalScore()
        //{
        //    //double score = 58.5;  //我的分数
        //    //int bonus = 2;  //加分
        //    //int sum;   //总分
        //    //sum = (int)score + bonus;
        //    //Console.WriteLine("愿分数为：{0}",score);
        //    //Console.WriteLine("加分后的总分为：{0}",sum);

        //    //使用ToString转换成字符串类型
        //    //int age = 18;
        //    //string myage = age.ToString();
        //    //Console.WriteLine(myage);

        //    double myDouble=85.34;  //原始值
        //    int myInt;   //转换后的整型
        //    float myFloat; //转换后的浮点型
        //    string myString; //转换后的字符串型


        //    Console.WriteLine("原始数值为 doble 类型：{0}", myDouble);
        //    //类型转换
        //    myInt = Convert.ToInt32(myDouble);
        //    myFloat = Convert.ToSingle(myDouble);
        //    myString = Convert.ToString(myDouble);

        //    //输出转换后
        //    Console.WriteLine("int\tfloat\tstring");
        //    Console.WriteLine("{0}\t{1}\t{2}",myInt,myFloat,myString);
        //} 
        #endregion
    }

}
