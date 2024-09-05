using System;

namespace Vietttt  {
    class rido    {
        static void Main(string[] args)  {
            new rido().BT1();
            new rido().BT2();
            new rido().BT3();
            new rido().BT4();
            new rido().BT5();
            new rido().BT6();
        }
    // Baitap1:
        void BT1()   {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            while(n<=0) {
                Console.WriteLine("Moi nhap lai!!!");
                n = int.Parse(Console.ReadLine());
            }
            int[] arr = new int[n];
            int sum = 0;
            Console.WriteLine("Nhap gia tri tung phan tu: ");
            for(int i=0; i<n; i++)  {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("tong la: ");
            for(int i=0; i<n; i++)    {
                 sum = sum + arr[i];
            }
                Console.WriteLine($"{sum}");
        }
// Baitap2:
        void BT2() {
                Console.Write("Nhap vao mot chuoi: ");
                string input = Console.ReadLine();
                int count =0;
                for(int i=0; i < input.Length ; i++) {
                    char c =input[i];
                    if(char.IsLetterOrDigit(c))
                    {
                        count++;
                    }
                }
                Console.WriteLine("So luong ki tu: "+count);
        }
// Baitap3:
         void BT3() {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            while(n<=0) {
                Console.WriteLine("Moi nhap lai!!!");
                n = int.Parse(Console.ReadLine());
            }
            int[] arr = new int[n];
            int sum = 0;
            Console.WriteLine("Nhap gia tri tung phan tu: ");
            for(int i=0; i<n; i++)  {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            for(int i=0; i<n; i++)  {
                if(max < arr[i])   max = arr[i];
            }
            Console.WriteLine("So lon nhat la: " + max);
        }
// Baitap4:
         void BT4()   {
            Console.Write("Nhap vao mot chuoi: ");
            string input = Console.ReadLine();
            string reverse = "";
            for(int i= input.Length - 1; i >=0 ; i--)   {
                reverse += input[i];
            }
            Console.WriteLine("Chuoi sau khi doi la: " + reverse);
        }
// Baitap5:
         void BT5()   {
            Console.Write("Nhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());
            while(n<=0) {
                Console.WriteLine("Moi nhap lai!!!");
                n = int.Parse(Console.ReadLine());
            }
            int[] arr = new int[n];
            Console.WriteLine("Nhap gia tri tung phan tu: ");
            for(int i=0; i<n; i++)  {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            bool isPalindrome = true;
            for(int i=0; i<n/2; i++)    {
                if(arr[i]!= arr[n-i-1])
                    isPalindrome = false;
                    break;
            }
            if(isPalindrome)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Ko la mang doi xung");
        }
//Baitap6 
         void BT6()   {
            Console.Write("Nhập vào một chuỗi: ");
            string chuoi = Console.ReadLine();

            Console.Write("Nhập vào ký tự cần đếm: ");
            char kyTuCanDem = Console.ReadLine()[0];

            int dem = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == kyTuCanDem)
                {
                    dem++;
                }
            }
            Console.WriteLine("Ký tự '{0}' xuất hiện {1} lần trong chuỗi.", kyTuCanDem, dem);
        }
    }
    
}
