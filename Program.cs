// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("chuong trinh tinh hoa don dien nuoc ");
// khai bao ham xu ly chuong trinh
void TinhHoaDonNuoc()
{
    Console.WriteLine("Nhap ho ten khach hang : ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Vui long chon loai khach hang");
    Console.WriteLine("Nhap so 1 neu ban la loai khach hang ho gia dinh, roi bam enter");
    Console.WriteLine("Nhap so 2 neu ban la loai khach hang co quan hanh chinh cong, roi bam enter");
    Console.WriteLine(" Nhap so 3 neu ban la loai khach hang don vi san xuat, roi bam enter");
    Console.WriteLine("Nhap so 4 neu ban la loai khach hang dich vu kinh doanh, roi bam enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // khach hang ho gia dinh
        // yeu cau so luong thanh vien trong gia dinh
        Console.WriteLine("Nhap so luong thanh vien trong gia dinh");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Nhap chi so dong nuoc cua thang truoc");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chi so dong nuoc cua thang nay");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            { 
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterNumberpeople = waterNumber / numberMember;
                double money = 0;

                if (waterNumberpeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberpeople > 10 && waterNumberpeople  <= 20) 
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberpeople > 20 && waterNumberpeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 *1.1;
                }
                Console.WriteLine("Tien nuoc cua gia dinh ban la : {0}", money);
            }
            else
            {
                Console.WriteLine("So nuoc thang truoc khong lon hon thang hien tai");
            }
        }
    }
    else if (typeCustomer == 2) 
    {
        // khach hang co quan hanh chinh cong
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang truoc");
        int waterLastMonth  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang hien tai");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("Tien nuoc co quan cua co quan hanh chinh cong la {0}", m);
        }
        else
        {
            Console.WriteLine("Chi so dong ho nuoc thang truoc khong lon hon thang hien tai");
        }
    }
    else if (typeCustomer == 3) 
    {
        // khach hang don vi san xuat
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang truoc");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang hien tai");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine("Tien nuoc cua don vi san xuat la {0}", m);
        }
        else
        {
            Console.WriteLine("Chi so dong ho nuoc cua thang truoc khong lon hon thang hien tai");
        }
    }
    else if (typeCustomer == 4) 
    {
        // khach hang kinh doanh 
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang truoc");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang hien tai");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 22068 * 1.1;
            Console.WriteLine("Tien nuoc cuar dich vu kinh doanh la {0}", m);
        }
        else
        {
            Console.WriteLine("Chi so dong ho noc cua thang truoc khong lon hon thang hien tai");
        }
    }
    else
    {
        Console.WriteLine("Vui long nhap dung the loai khach hang");
    }
}
// chay truong trinh
TinhHoaDonNuoc();