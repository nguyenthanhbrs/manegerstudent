\# PHẦN MỀM QUẢN LÝ SINH VIÊN - STUDENT MANAGEMENT UI



\## 📌 THÔNG TIN BÀI NỘP

\- \*\*Môn học\*\*: Thiết kế Giao diện Windows Forms / Phát triển phần mềm

\- \*\*Họ và tên\*\*: Nguyễn Duy Thành

\- \*\*Mã số sinh viên (MSSV)\*\*: \[Nhập MSSV của bạn vào đây]

\- \*\*Lớp\*\*: \[Nhập tên lớp của bạn vào đây]



\---



\## 📝 MÔ TẢ PROJECT

Ứng dụng \*\*Student Management UI\*\* là phần mềm quản lý sinh viên được xây dựng trên nền tảng \*\*Windows Forms (.NET 8)\*\*. Giao diện được thiết kế khoa học, trực quan với các khu vực chính:

1\. \*\*Khu vực Thông tin sinh viên\*\*: Hỗ trợ nhập liệu các thuộc tính cơ bản (MSSV, Họ tên, Ngày sinh, Giới tính, Khoa, Lớp, Email, SĐT).

2\. \*\*Khu vực Chức năng\*\*: Các nút thao tác quản lý (Thêm, Sửa, Xóa, Làm mới).

3\. \*\*Khu vực Danh sách \& Tìm kiếm\*\*: Bảng DataGridView hiển thị danh sách sinh viên và thanh tìm kiếm/lọc theo khoa.



\---



\## 🛠️ CÁC CONTROL ĐÃ SỬ DỤNG

\- \*\*Panel\*\*: Tạo Header khung tiêu đề ứng dụng và nhóm nút RadioButton.

\- \*\*GroupBox\*\*: Phân chia trực quan khu vực nhập liệu và danh sách sinh viên.

\- \*\*Label\*\*: Hiển thị nhãn tên trường dữ liệu.

\- \*\*TextBox\*\*: Nhập dữ liệu dạng chuỗi (Mã sinh viên, Họ tên, Email, Số điện thoại, Từ khóa tìm kiếm).

\- \*\*DateTimePicker\*\*: Chọn ngày sinh định dạng `dd/MM/yyyy`.

\- \*\*RadioButton\*\*: Chọn giới tính (Nam / Nữ).

\- \*\*ComboBox\*\*: Danh sách chọn phân loại Khoa và Lớp học.

\- \*\*Button\*\*: Các nút thao tác chức năng (Thêm, Sửa, Xóa, Làm mới, Tìm kiếm).

\- \*\*DataGridView\*\*: Bảng hiển thị danh sách sinh viên tự động co giãn (`Fill`).



\---



\## 🌳 CẤU TRÚC GIT BRANCH

```text

main

├── feature-student-form

└── feature-student-grid

