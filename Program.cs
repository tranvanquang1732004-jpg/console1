// c# mở đầu 
// bai 1
                Console.WriteLine("Hello, World!");
                int tuoi = 15;
                double met = 1.20;
                double chieu_cao =0.45;
                double b = met + chieu_cao;
                char gioitinh ='A' ;
                Console.Write( "gioi tinh do la" +" " + gioitinh +" " +
                               "toui cua toi la " + tuoi +" " +
                               "tong so met la " + b +'\n' );
// bai 2 
                int namSinh = 2004;
                int namHienTai = DateTime.Now.Year; // Tự động lấy năm từ hệ thống máy tính
                int so_tuoi = namHienTai - namSinh;

                Console.WriteLine($"Tuoi hien tai cua ban la: {so_tuoi}" + '\n');
//bai 3
                string ten = "tran";
                string ten_dem = " van quang";
                Console.WriteLine(ten + ten_dem +'\n');
//bai 4
                string ten_san_pham = "chuoi"+" tao"+ " man";
                Console.WriteLine(ten_san_pham);
                string gia_san_pham = "24K" +"  60k" +"  12k";
                Console.WriteLine(gia_san_pham);
                int chuoi = 19;
                int tao = 23;
                int man = 30;
                Console.WriteLine("so luong ton kho la : " +"chuoi la" +" " + chuoi
                                  +" " +"tao la" +" " +tao +" "
                                  + "man la" + " " + man +'\n');
                Boolean san_pham_con_hang = chuoi + tao + man > 0;
                Console.WriteLine("cac san pham con hang la :" + san_pham_con_hang);
//bai 5
                //chu vi hinh vuong
                int c = 8;
                int c1 = 4;
                int c2 = c1 * c;
                Console.WriteLine("cach tinh chu vi hinh vuong la : " + c2);
                // dien tich hinh vuong
                int d = 8;
                int d1 = 8;
                int d2 = d1 * c;
                Console.WriteLine("cach tinh dien tich hinh vuong la : " + d2);
// bai 6
                //chu vi hinh chu nhat
                double ch = 14.5;
                double r = 6.2;
                double tong = (ch + r) * 2;
                Console.WriteLine("cach tinh chu vi hinh chu nhat la : " + tong);
                //dien tich hinh chu nhat
                double ch1 = 14.5;
                double r1 = 6.2;
                double tong1 = ch1 * r1;
                Console.WriteLine("cach tinh dien tich hinh chu nhat la : " + tong1);
// bai 7
                //chu vi cua hinh tron la
                const double PI = 3.14159;
                double r2 = 5.5;
                double tong2 = r2 *PI;
                Console.WriteLine("chu vi cua hinh tron la : " + tong2);
                //dien tich cua hinh tron la
                const double PI1 = 3.14159;
                double r23 = 5.5;
                double tong23 = r23 * 2 * PI1;
                Console.WriteLine("dien tich cua hinh tron la : " + tong23);
// bai 8
                double quangDuong = 105;
                double thoiGian = 2 ;
                double vantoc = quangDuong / thoiGian;
                Console.WriteLine("van toc cua xe la  : " + vantoc);
// bai 9
                double lượngUSD = 120.5;
                double tyGia = 25450 ;
                double tyGiaVN = tyGia  / lượngUSD ;
                Console.WriteLine("ty gia khi quy doi ra tien VN la " + tyGiaVN);
// bai 10
                int tongSoKeo = 32;
                int soHocSinh = 6;
                Console.WriteLine(" so keo nguyen và thay con du la : " + (tongSoKeo / soHocSinh));
// bai 11
                int tongSoNgay = 45 ;
                int tuan = tongSoNgay / 4 ;
                int ngayle = tongSoNgay / 2 ;
                Console.WriteLine("tong so tuan : " + tuan );
                Console.WriteLine("tong so ngay : " + ngayle );
// bai 12
                int tongGiay = 3665;
                int gio = tongGiay / 3600;
                int giayConLaiSauGio = tongGiay % 3600;
                int phut = giayConLaiSauGio / 60;
                int giay = giayConLaiSauGio % 60;
                Console.WriteLine("giayConLai : "  + gio);
                Console.WriteLine("phutconlai : " + phut);
                Console.WriteLine("giayconlai : " + giay);
//bai 13
                int diemTichLuy = 100 ;
                diemTichLuy += 50 ;
                diemTichLuy -= 30 ;
                diemTichLuy *= 2 ;
                Console.WriteLine("diemTichLuy : " + diemTichLuy);
// bai 14
                int a = 10;
                int b1 = a++;
                int c12 = ++a;
                Console.WriteLine("a : " + b1);
                Console.WriteLine("a : " + c12);
// bai 15
                double luongCoBan = 12000000;
                double heSoLuong = 1.5;
                double tongluong = luongCoBan * heSoLuong;
                double  baohiem = tongluong * 0.105;
                Console.WriteLine("baohiem : " + baohiem);
// BAI 16
                int n = 26;
                bool laSoChan = (n % 2 == 0); 
                Console.WriteLine($"So {n} là so chan: {laSoChan}");
// Bài 17
                double diemTrungBinh = 4.8;
                bool laDat = diemTrungBinh >= 5.0; 
                Console.WriteLine($"Voi diem {diemTrungBinh}, ket qua đat (>= 5.0): {laDat}");
// Bài 18
                int giaTri = 35;
                bool hopLe = giaTri is > 10 and < 50; 
                Console.WriteLine($"Gia tri {giaTri} nam trong khoang (10 < x < 50): {hopLe}");
// Bài 19
                bool troiMua = false;
                bool coTien = true;
                bool diChoi = !troiMua && coTien; 
                Console.WriteLine($"Troi mua: {troiMua}, Co tien: {coTien} -> Co the đi choi: {diChoi}");
// bai 20
                double chieuCao = 1.75; 
                double canNang = 78.5;  
                double bmi = canNang / (chieuCao * chieuCao);
                bool biThuaCan = bmi >= 25.0;
                Console.WriteLine($"Chieu cao: {chieuCao}m, Can nang: {canNang}kg");
                Console.WriteLine($"Chi so BMI: {bmi:F2}");
                Console.WriteLine($"Bi thua can (BMI >= 25.0): {biThuaCan}");