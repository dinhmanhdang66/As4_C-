using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {   /* nhập hệ số của đa thức
             * ví dụ 2x mũ3 + 3x mũ2 - 6x mũ1 + 1x mũ0  
             * thì hệ số đa thức là 4
             */
            Console.WriteLine("Nhap he so da thuc ");
            int n = Convert.ToInt32(Console.ReadLine());

            // tạo 1 mảng để chứa các số 
            int[] arr = new int[n];

            // nhập từng hệ số của đa thức
            Console.WriteLine("Nhap tung so cua da thuc ");
            for(int i=0 ; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //
            Console.WriteLine("\n");
            /* Tính tổng các hệ số 
             * Nếu tổng các hệ số là 0 thì sẽ có 1 nghiệm là 1 
             * Phân tích để ra được nghiệm còn lại qua Horner
             */
            int sum =0 ; 
            for(int i=0; i<n; i++)
            {
                sum += arr[i]; 
            }
            // kiểm tra xem tổng các hệ số có bằng 0 hay là khác 0 
            if(sum == 0 )
            {
                // thực hiện biến đỗi các hệ số theo quy tắc nhân và cộng chéo hệ số 
                arr[0] = arr[0]; 
                for(int i=1; i<n; i++)
                {
                    arr[i] = (1 * arr[i - 1]) + arr[i];
                }

                Console.Write("Cac he so cua da thuc nghiem la : ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($" ({arr[i]}) "  );
                }
                //
                /*
             * 2xmũ3 + 3xmũ2 - 6xmũ1 + 1xmũ0 = (x-1) (2xmũ2 + 5xmũ1 - 1xmũ1 +0)  
             */
                Console.ReadLine();

            } else
            {
                Console.WriteLine("Ko co nghiem thu 2 ");
            }
            
        }

    }
}
