using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                nums.Enqueue(i);
            }
            //   (Queue) הסיבה שאני עושה טריי וקטאץ היא שאם 
            //יהיה ריק אז לא יהיה אפשר להשתמש במתודות למטה והתוכנה תקרוס 
            try
            {
                Console.WriteLine(nums.Dequeue());//Dequeue מחזיר את הערך הראשון שנכנס ומוחק אותו
                Console.WriteLine(nums.Peek());//כעת נוכל לראות שהערך הראשון נחמק והערך שהיה שני כעת הוא הראשון 

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
