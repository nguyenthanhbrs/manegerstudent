#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmStudent : Form
    {
        // 1. Header
        private Panel pnlHeader;
        private Label lblHeaderTitle, lblHeaderSub;

        // 2. Khu vực nhập liệu thông tin sinh viên
        private GroupBox grpStudentInfo;
        private Label lblStudentId, lblFullName, lblBirthDate, lblGender, lblFaculty, lblClass, lblEmail, lblPhone;
        private TextBox txtStudentId, txtFullName, txtEmail, txtPhone;
        private DateTimePicker dtpBirthDate;
        private RadioButton rdoMale, rdoFemale;
        private Panel pnlGender;
        private ComboBox cboFaculty, cboClass;

        // 3. Khu vực nút chức năng
        private Panel pnlActions;
        private Button btnAdd, btnEdit, btnDelete, btnRefresh;

        // 4. Khu vực Danh sách sinh viên (DataGridView & Tìm kiếm)
        private GroupBox grpDataArea;
        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cboFilterFaculty;
        private Button btnSearch;
        private DataGridView dgvStudents;

        public frmStudent()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            Font fontTitle = new Font("Segoe UI", 13, FontStyle.Bold);
            Font fontBold = new Font("Segoe UI", 9.0f, FontStyle.Bold);
            Font fontRegular = new Font("Segoe UI", 9.0f, FontStyle.Regular);

            Color colorPrimary = Color.FromArgb(24, 43, 73);
            Color colorBg = Color.FromArgb(245, 247, 250);

            // Cấu hình Form
            this.Name = "frmStudent";
            this.Text = "Hệ Thống Quản Lý Sinh Viên - Student Management System";
            this.Size = new Size(1080, 660);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = colorBg;

            // Header
            pnlHeader = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = colorPrimary };
            lblHeaderTitle = new Label { Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN", Font = fontTitle, ForeColor = Color.White, Location = new Point(20, 12), AutoSize = true };
            lblHeaderSub = new Label { Text = "Chương trình quản lý danh sách & thông tin sinh viên", Font = new Font("Segoe UI", 8.5f, FontStyle.Italic), ForeColor = Color.FromArgb(200, 210, 225), Location = new Point(22, 36), AutoSize = true };
            pnlHeader.Controls.AddRange(new Control[] { lblHeaderTitle, lblHeaderSub });

            // KHU VỰC NHẬP LIỆU (Feature: Form)
            grpStudentInfo = new GroupBox
            {
                Text = "📝 THÔNG TIN SINH VIÊN",
                Font = fontBold,
                ForeColor = colorPrimary,
                Location = new Point(20, 75),
                Size = new Size(350, 420),
                BackColor = Color.White
            };

            int lblX = 15, inputX = 120, inputW = 210;
            int startY = 32, spacing = 47;

            lblStudentId = new Label { Text = "Mã sinh viên (*):", Location = new Point(lblX, startY), Font = fontRegular, AutoSize = true };
            txtStudentId = new TextBox { Location = new Point(inputX, startY - 3), Size = new Size(inputW, 23), Font = fontRegular };

            lblFullName = new Label { Text = "Họ và tên (*):", Location = new Point(lblX, startY + spacing), Font = fontRegular, AutoSize = true };
            txtFullName = new TextBox { Location = new Point(inputX, startY + spacing - 3), Size = new Size(inputW, 23), Font = fontRegular };

            lblBirthDate = new Label { Text = "Ngày sinh:", Location = new Point(lblX, startY + spacing * 2), Font = fontRegular, AutoSize = true };
            dtpBirthDate = new DateTimePicker { Location = new Point(inputX, startY + spacing * 2 - 3), Size = new Size(inputW, 23), Format = DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Font = fontRegular };

            lblGender = new Label { Text = "Giới tính:", Location = new Point(lblX, startY + spacing * 3), Font = fontRegular, AutoSize = true };
            pnlGender = new Panel { Location = new Point(inputX, startY + spacing * 3 - 5), Size = new Size(inputW, 25) };
            rdoMale = new RadioButton { Text = "Nam", Location = new Point(0, 2), AutoSize = true, Checked = true, Font = fontRegular };
            rdoFemale = new RadioButton { Text = "Nữ", Location = new Point(70, 2), AutoSize = true, Font = fontRegular };
            pnlGender.Controls.AddRange(new Control[] { rdoMale, rdoFemale });

            lblFaculty = new Label { Text = "Khoa:", Location = new Point(lblX, startY + spacing * 4), Font = fontRegular, AutoSize = true };
            cboFaculty = new ComboBox { Location = new Point(inputX, startY + spacing * 4 - 3), Size = new Size(inputW, 23), DropDownStyle = ComboBoxStyle.DropDownList, Font = fontRegular };
            cboFaculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Điện - Điện tử", "Kinh tế", "Ngoại ngữ" });
            cboFaculty.SelectedIndex = 0;

            lblClass = new Label { Text = "Lớp học:", Location = new Point(lblX, startY + spacing * 5), Font = fontRegular, AutoSize = true };
            cboClass = new ComboBox { Location = new Point(inputX, startY + spacing * 5 - 3), Size = new Size(inputW, 23), DropDownStyle = ComboBoxStyle.DropDownList, Font = fontRegular };
            cboClass.Items.AddRange(new object[] { "CNTT01", "CNTT02", "DTTT01", "KTM01" });
            cboClass.SelectedIndex = 0;

            lblEmail = new Label { Text = "Email:", Location = new Point(lblX, startY + spacing * 6), Font = fontRegular, AutoSize = true };
            txtEmail = new TextBox { Location = new Point(inputX, startY + spacing * 6 - 3), Size = new Size(inputW, 23), Font = fontRegular };

            lblPhone = new Label { Text = "Số điện thoại:", Location = new Point(lblX, startY + spacing * 7), Font = fontRegular, AutoSize = true };
            txtPhone = new TextBox { Location = new Point(inputX, startY + spacing * 7 - 3), Size = new Size(inputW, 23), Font = fontRegular };

            grpStudentInfo.Controls.AddRange(new Control[] {
                lblStudentId, txtStudentId, lblFullName, txtFullName,
                lblBirthDate, dtpBirthDate, lblGender, pnlGender,
                lblFaculty, cboFaculty, lblClass, cboClass,
                lblEmail, txtEmail, lblPhone, txtPhone
            });

            // Nút thao tác
            pnlActions = new Panel { Location = new Point(20, 505), Size = new Size(350, 45) };
            btnAdd = new Button { Text = "Thêm", Location = new Point(0, 5), Size = new Size(80, 32), Font = fontBold, BackColor = Color.FromArgb(40, 167, 69), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnEdit = new Button { Text = "Sửa", Location = new Point(88, 5), Size = new Size(80, 32), Font = fontBold, BackColor = Color.FromArgb(255, 193, 7), ForeColor = Color.Black, FlatStyle = FlatStyle.Flat };
            btnDelete = new Button { Text = "Xóa", Location = new Point(176, 5), Size = new Size(80, 32), Font = fontBold, BackColor = Color.FromArgb(220, 53, 69), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnRefresh = new Button { Text = "Làm mới", Location = new Point(264, 5), Size = new Size(86, 32), Font = fontBold, BackColor = Color.FromArgb(23, 162, 184), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };

            foreach (Button btn in new Button[] { btnAdd, btnEdit, btnDelete, btnRefresh }) btn.FlatAppearance.BorderSize = 0;
            pnlActions.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete, btnRefresh });

            // KHU VỰC DATAGRIDVIEW (Feature: Grid)
            grpDataArea = new GroupBox
            {
                Text = "📊 DANH SÁCH SINH VIÊN",
                Font = fontBold,
                ForeColor = colorPrimary,
                Location = new Point(385, 75),
                Size = new Size(665, 475),
                BackColor = Color.White
            };

            lblSearch = new Label { Text = "Tìm kiếm:", Location = new Point(15, 30), Font = fontRegular, AutoSize = true };
            txtSearch = new TextBox { Location = new Point(80, 26), Size = new Size(200, 23), Font = fontRegular };

            cboFilterFaculty = new ComboBox { Location = new Point(290, 26), Size = new Size(160, 23), DropDownStyle = ComboBoxStyle.DropDownList, Font = fontRegular };
            cboFilterFaculty.Items.AddRange(new object[] { "-- Tất cả khoa --", "Công nghệ thông tin", "Điện - Điện tử", "Kinh tế", "Ngoại ngữ" });
            cboFilterFaculty.SelectedIndex = 0;

            btnSearch = new Button { Text = "Tìm", Location = new Point(460, 24), Size = new Size(80, 27), Font = fontBold, BackColor = colorPrimary, ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnSearch.FlatAppearance.BorderSize = 0;

            dgvStudents = new DataGridView
            {
                Location = new Point(15, 65),
                Size = new Size(635, 395),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AllowUserToAddRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                Font = fontRegular,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                RowHeadersVisible = false
            };

            dgvStudents.Columns.Add("colId", "MSSV");
            dgvStudents.Columns.Add("colName", "Họ tên");
            dgvStudents.Columns.Add("colBirth", "Ngày sinh");
            dgvStudents.Columns.Add("colGender", "Giới tính");
            dgvStudents.Columns.Add("colFaculty", "Khoa");
            dgvStudents.Columns.Add("colClass", "Lớp");
            dgvStudents.Columns.Add("colPhone", "SĐT");
            dgvStudents.Columns.Add("colEmail", "Email");

            dgvStudents.Rows.Add("SV001", "Nguyễn Văn A", "15/05/2003", "Nam", "Công nghệ thông tin", "CNTT01", "0901234567", "nguyenvana@gmail.com");
            dgvStudents.Rows.Add("SV002", "Trần Thị B", "20/10/2003", "Nữ", "Kinh tế", "KTM01", "0912345678", "tranthib@gmail.com");

            grpDataArea.Controls.AddRange(new Control[] { lblSearch, txtSearch, cboFilterFaculty, btnSearch, dgvStudents });

            this.Controls.AddRange(new Control[] { pnlHeader, grpStudentInfo, pnlActions, grpDataArea });
        }
    }
}