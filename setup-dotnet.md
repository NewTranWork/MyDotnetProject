# Hướng dẫn Setup môi trường .NET trên Windows và Khởi tạo Project

## 1. Mục đích
Tài liệu này ghi chú lại các bước cài đặt môi trường .NET và cách khởi chạy một dự án .NET cơ bản.

## 2. Cài đặt môi trường .NET
**Bước 1:** Truy cập vào trang chủ [.NET Download](https://dotnet.microsoft.com/download).

![Trang chủ .NET Download](<Screenshot 2026-03-22 200726.png>)

**Bước 2:** Tải bộ cài đặt .NET SDK dành cho Windows (Bản x64).

![Tải bộ cài đặt](<Screenshot (18).png>)

**Bước 3:** Chạy file cài đặt.

![Cài đặt thành công](<Screenshot 2026-03-22 193039.png>)

**Bước 4:** Kiểm tra cài đặt thành công bằng cách mở Terminal và chạy lệnh:
` ` `bash
dotnet --version
` ` `

![Kiểm tra cài đặt](<Screenshot 2026-03-22 193130.png>)

*(Chèn hình ảnh chụp màn hình terminal của bạn vào đây bằng cú pháp: `![Mô tả ảnh](link_anh_hoac_du_ong_dan_anh)`)*


## 3. Khởi tạo Source Code (Init Project)

Mở Terminal, tạo một thư mục mới cho dự án và đi vào thư mục đó:

![tạo một thư mục mới](<Screenshot 2026-03-22 193505.png>)

Để tạo một dự án mới, chạy lệnh sau trong thư mục trống:
` ` `bash
dotnet new console
` ` `
Lệnh này sẽ tạo ra một ứng dụng Console cơ bản.

![Tạo Console](<Screenshot 2026-03-22 193604.png>)

## 4. Chạy thử dự án
Sử dụng lệnh sau để build và chạy ứng dụng:
` ` `bash
dotnet run
` ` `
Kết quả hiển thị trên màn hình sẽ là: `Hello, World!`

![Kết quả màn hình](<Screenshot 2026-03-22 193633.png>)

## 5. Put Code lên Github
Tạo 1 Repository trên Github cho Project

![Tạo 1 Repository](<Screenshot 2026-03-22 204300.png>)

Tiếp theo gõ git init để khởi tạo 1 git repository và thêm lệnh git commit -m "Add new project food" . Lệnh này dùng để note lại các thay đổi để dễ dàng theo dõi

![Tạo lệnh git init và git commit](<Screenshot 2026-03-22 205513.png>)

Kế tiếp gõ lệnh git branch -M main

Sau đó gõ thêm lệnh git remote add origin <link github của Repository tạo lúc đầu>

![Tạo lệnh git branch và git remote](<Screenshot 2026-03-22 205851.png>)

Cuối cùng gõ lệnh git push -u origin main để đưa code lên Github

![Đưa code lên Github](<Screenshot 2026-03-22 210408.png>)

Kết quả khi hoàn thành

![Kết quả](<Screenshot 2026-03-22 210908.png>)
