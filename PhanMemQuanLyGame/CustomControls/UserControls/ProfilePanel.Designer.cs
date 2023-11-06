namespace CustomControls.UserControls
{
    partial class ProfilePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.lblQT = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.PanelUpdateProfile = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgSinh = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.PanelChangePassword = new System.Windows.Forms.Panel();
            this.txtMKMoi2 = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.lblMK2 = new System.Windows.Forms.Label();
            this.lblMK1 = new System.Windows.Forms.Label();
            this.lblMKCu = new System.Windows.Forms.Label();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.BtnChangePass = new System.Windows.Forms.Button();
            this.BtnConfirmChangePass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboCountry = new CustomControls.Controls.CountryComboBox();
            this.txtEmail = new CustomControls.Controls.EmailTextBox();
            this.txtNgSinh = new CustomControls.Controls.DateTextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelUpdateProfile.SuspendLayout();
            this.PanelChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.BtnChangePass);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.lblQT);
            this.panel1.Controls.Add(this.lblTK);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(60, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1160, 178);
            this.panel1.TabIndex = 0;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(1062, 132);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQT.ForeColor = System.Drawing.Color.White;
            this.lblQT.Location = new System.Drawing.Point(177, 75);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(71, 19);
            this.lblQT.TabIndex = 2;
            this.lblQT.Text = "Quốc tịch";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.ForeColor = System.Drawing.Color.White;
            this.lblTK.Location = new System.Drawing.Point(176, 33);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(88, 25);
            this.lblTK.TabIndex = 1;
            this.lblTK.Text = "Tên TK";
            // 
            // PanelUpdateProfile
            // 
            this.PanelUpdateProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.PanelUpdateProfile.Controls.Add(this.cboCountry);
            this.PanelUpdateProfile.Controls.Add(this.txtEmail);
            this.PanelUpdateProfile.Controls.Add(this.txtNgSinh);
            this.PanelUpdateProfile.Controls.Add(this.lblEmail);
            this.PanelUpdateProfile.Controls.Add(this.lblNgSinh);
            this.PanelUpdateProfile.Controls.Add(this.txtHoten);
            this.PanelUpdateProfile.Controls.Add(this.txtCCCD);
            this.PanelUpdateProfile.Controls.Add(this.txtSDT);
            this.PanelUpdateProfile.Controls.Add(this.txtDC);
            this.PanelUpdateProfile.Controls.Add(this.lblQuocTich);
            this.PanelUpdateProfile.Controls.Add(this.lblDC);
            this.PanelUpdateProfile.Controls.Add(this.lblSDT);
            this.PanelUpdateProfile.Controls.Add(this.lblCCCD);
            this.PanelUpdateProfile.Controls.Add(this.lblHoten);
            this.PanelUpdateProfile.Location = new System.Drawing.Point(60, 230);
            this.PanelUpdateProfile.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.PanelUpdateProfile.Name = "PanelUpdateProfile";
            this.PanelUpdateProfile.Size = new System.Drawing.Size(766, 311);
            this.PanelUpdateProfile.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(460, 100);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 19);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email:";
            // 
            // lblNgSinh
            // 
            this.lblNgSinh.AutoSize = true;
            this.lblNgSinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgSinh.ForeColor = System.Drawing.Color.White;
            this.lblNgSinh.Location = new System.Drawing.Point(432, 50);
            this.lblNgSinh.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblNgSinh.Name = "lblNgSinh";
            this.lblNgSinh.Size = new System.Drawing.Size(80, 19);
            this.lblNgSinh.TabIndex = 35;
            this.lblNgSinh.Text = "Ngày Sinh:";
            // 
            // txtHoten
            // 
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(124, 51);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(258, 20);
            this.txtHoten.TabIndex = 1;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Enabled = false;
            this.txtCCCD.Location = new System.Drawing.Point(124, 101);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(258, 20);
            this.txtCCCD.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(124, 151);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(258, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtDC
            // 
            this.txtDC.Enabled = false;
            this.txtDC.Location = new System.Drawing.Point(124, 201);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(599, 20);
            this.txtDC.TabIndex = 4;
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.AutoSize = true;
            this.lblQuocTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuocTich.ForeColor = System.Drawing.Color.White;
            this.lblQuocTich.Location = new System.Drawing.Point(31, 250);
            this.lblQuocTich.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(80, 19);
            this.lblQuocTich.TabIndex = 29;
            this.lblQuocTich.Text = "Quốc Tịch:";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.ForeColor = System.Drawing.Color.White;
            this.lblDC.Location = new System.Drawing.Point(46, 200);
            this.lblDC.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(65, 19);
            this.lblDC.TabIndex = 28;
            this.lblDC.Text = "Địa Chỉ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.White;
            this.lblSDT.Location = new System.Drawing.Point(70, 150);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 19);
            this.lblSDT.TabIndex = 27;
            this.lblSDT.Text = "SDT:";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.ForeColor = System.Drawing.Color.White;
            this.lblCCCD.Location = new System.Drawing.Point(53, 100);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(58, 19);
            this.lblCCCD.TabIndex = 26;
            this.lblCCCD.Text = "CCCD:";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.ForeColor = System.Drawing.Color.White;
            this.lblHoten.Location = new System.Drawing.Point(50, 50);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(61, 19);
            this.lblHoten.TabIndex = 25;
            this.lblHoten.Text = "Họ Tên:";
            // 
            // PanelChangePassword
            // 
            this.PanelChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.PanelChangePassword.Controls.Add(this.BtnCancel);
            this.PanelChangePassword.Controls.Add(this.BtnConfirmChangePass);
            this.PanelChangePassword.Controls.Add(this.txtMKMoi2);
            this.PanelChangePassword.Controls.Add(this.txtMKMoi);
            this.PanelChangePassword.Controls.Add(this.txtMKCu);
            this.PanelChangePassword.Controls.Add(this.lblTenTK);
            this.PanelChangePassword.Controls.Add(this.lblMK2);
            this.PanelChangePassword.Controls.Add(this.lblMK1);
            this.PanelChangePassword.Controls.Add(this.lblMKCu);
            this.PanelChangePassword.Controls.Add(this.lblTenTaiKhoan);
            this.PanelChangePassword.Location = new System.Drawing.Point(871, 230);
            this.PanelChangePassword.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.PanelChangePassword.Name = "PanelChangePassword";
            this.PanelChangePassword.Size = new System.Drawing.Size(349, 344);
            this.PanelChangePassword.TabIndex = 2;
            // 
            // txtMKMoi2
            // 
            this.txtMKMoi2.Location = new System.Drawing.Point(164, 199);
            this.txtMKMoi2.Name = "txtMKMoi2";
            this.txtMKMoi2.Size = new System.Drawing.Size(169, 20);
            this.txtMKMoi2.TabIndex = 10;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(164, 149);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(169, 20);
            this.txtMKMoi.TabIndex = 9;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(164, 99);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(169, 20);
            this.txtMKCu.TabIndex = 8;
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.ForeColor = System.Drawing.Color.White;
            this.lblTenTK.Location = new System.Drawing.Point(160, 50);
            this.lblTenTK.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(86, 19);
            this.lblTenTK.TabIndex = 21;
            this.lblTenTK.Text = "tên tài khoản";
            // 
            // lblMK2
            // 
            this.lblMK2.AutoSize = true;
            this.lblMK2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK2.ForeColor = System.Drawing.Color.White;
            this.lblMK2.Location = new System.Drawing.Point(16, 198);
            this.lblMK2.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblMK2.Name = "lblMK2";
            this.lblMK2.Size = new System.Drawing.Size(140, 19);
            this.lblMK2.TabIndex = 20;
            this.lblMK2.Text = "Xác nhận mật khẩu:";
            // 
            // lblMK1
            // 
            this.lblMK1.AutoSize = true;
            this.lblMK1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK1.ForeColor = System.Drawing.Color.White;
            this.lblMK1.Location = new System.Drawing.Point(51, 150);
            this.lblMK1.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblMK1.Name = "lblMK1";
            this.lblMK1.Size = new System.Drawing.Size(105, 19);
            this.lblMK1.TabIndex = 19;
            this.lblMK1.Text = "Mật khẩu mới:";
            // 
            // lblMKCu
            // 
            this.lblMKCu.AutoSize = true;
            this.lblMKCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKCu.ForeColor = System.Drawing.Color.White;
            this.lblMKCu.Location = new System.Drawing.Point(61, 100);
            this.lblMKCu.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblMKCu.Name = "lblMKCu";
            this.lblMKCu.Size = new System.Drawing.Size(95, 19);
            this.lblMKCu.TabIndex = 18;
            this.lblMKCu.Text = "Mật khẩu cũ:";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(77, 50);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(50, 50, 10, 50);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(79, 19);
            this.lblTenTaiKhoan.TabIndex = 17;
            this.lblTenTaiKhoan.Text = "Tài khoản:";
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangePass.Location = new System.Drawing.Point(935, 132);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnChangePass.Size = new System.Drawing.Size(109, 23);
            this.BtnChangePass.TabIndex = 4;
            this.BtnChangePass.Text = "Đổi Mật Khẩu";
            this.BtnChangePass.UseVisualStyleBackColor = true;
            this.BtnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // BtnConfirmChangePass
            // 
            this.BtnConfirmChangePass.Location = new System.Drawing.Point(258, 288);
            this.BtnConfirmChangePass.Name = "BtnConfirmChangePass";
            this.BtnConfirmChangePass.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmChangePass.TabIndex = 5;
            this.BtnConfirmChangePass.Text = "Xác Nhận";
            this.BtnConfirmChangePass.UseVisualStyleBackColor = true;
            this.BtnConfirmChangePass.Click += new System.EventHandler(this.BtnConfirmChangePass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.Enabled = false;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo (Congo-Brazzaville)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia (Czech Republic)",
            "Democratic Republic of the Congo (Congo-Kinshasa)",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (formerly Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia (formerly Macedonia)",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine State",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe",
            "None",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo (Congo-Brazzaville)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia (Czech Republic)",
            "Democratic Republic of the Congo (Congo-Kinshasa)",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (formerly Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia (formerly Macedonia)",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine State",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe",
            "None",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo (Congo-Brazzaville)",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia (Czech Republic)",
            "Democratic Republic of the Congo (Congo-Kinshasa)",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (formerly Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia (formerly Macedonia)",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestine State",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States of America",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe",
            "None"});
            this.cboCountry.Location = new System.Drawing.Point(124, 251);
            this.cboCountry.MaxDropDownItems = 5;
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(140, 21);
            this.cboCountry.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(526, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNgSinh
            // 
            this.txtNgSinh.Enabled = false;
            this.txtNgSinh.Location = new System.Drawing.Point(526, 50);
            this.txtNgSinh.Mask = "00/00/0000";
            this.txtNgSinh.Name = "txtNgSinh";
            this.txtNgSinh.Size = new System.Drawing.Size(101, 20);
            this.txtNgSinh.TabIndex = 5;
            this.txtNgSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(164, 288);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 22;
            this.BtnCancel.Text = "Hủy";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ProfilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelChangePassword);
            this.Controls.Add(this.PanelUpdateProfile);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProfilePanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1280, 620);
            this.Load += new System.EventHandler(this.ProfilePanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelUpdateProfile.ResumeLayout(false);
            this.PanelUpdateProfile.PerformLayout();
            this.PanelChangePassword.ResumeLayout(false);
            this.PanelChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelUpdateProfile;
        private System.Windows.Forms.Panel PanelChangePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMKCu;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMKMoi2;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Label lblMK2;
        private System.Windows.Forms.Label lblMK1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgSinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDC;
        private Controls.DateTextBox txtNgSinh;
        private Controls.CountryComboBox cboCountry;
        private Controls.EmailTextBox txtEmail;
        private System.Windows.Forms.Button BtnChangePass;
        private System.Windows.Forms.Button BtnConfirmChangePass;
        private System.Windows.Forms.Button BtnCancel;
    }
}
