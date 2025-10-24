namespace ProgramOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateNow = new Label();
            CinemaName = new Label();
            groupBox = new GroupBox();
            CinemaScreen = new Label();
            pictureBox1 = new PictureBox();
            BuyTicket = new Button();
            NickNameBox = new TextBox();
            PasswordBox = new TextBox();
            trackBar = new TrackBar();
            CountTickets = new Label();
            SignIn = new Button();
            Registration = new Button();
            TitlePanel = new Label();
            Panel = new Panel();
            Balance = new Label();
            NickName = new Label();
            TextBalance = new Label();
            TextNickname = new Label();
            StatusPurchased = new Label();
            PriceTicket = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // dateNow
            // 
            dateNow.AutoSize = true;
            dateNow.Location = new Point(12, 103);
            dateNow.Name = "dateNow";
            dateNow.Size = new Size(32, 15);
            dateNow.TabIndex = 0;
            dateNow.Text = "Дата";
            // 
            // CinemaName
            // 
            CinemaName.AutoSize = true;
            CinemaName.Location = new Point(12, 127);
            CinemaName.Name = "CinemaName";
            CinemaName.Size = new Size(106, 15);
            CinemaName.TabIndex = 1;
            CinemaName.Text = "Название фильма";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(CinemaScreen);
            groupBox.Controls.Add(pictureBox1);
            groupBox.Location = new Point(12, 145);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(776, 242);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Кинозал 1";
            // 
            // CinemaScreen
            // 
            CinemaScreen.AutoSize = true;
            CinemaScreen.BackColor = Color.Transparent;
            CinemaScreen.ForeColor = Color.Black;
            CinemaScreen.Location = new Point(323, 22);
            CinemaScreen.Name = "CinemaScreen";
            CinemaScreen.Size = new Size(113, 15);
            CinemaScreen.TabIndex = 1;
            CinemaScreen.Text = "ЭКРАН КИНОЗАЛА";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSlateGray;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(764, 15);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BuyTicket
            // 
            BuyTicket.BackColor = Color.Lime;
            BuyTicket.BackgroundImageLayout = ImageLayout.Center;
            BuyTicket.FlatAppearance.BorderSize = 0;
            BuyTicket.FlatStyle = FlatStyle.Flat;
            BuyTicket.Location = new Point(486, 403);
            BuyTicket.Name = "BuyTicket";
            BuyTicket.Size = new Size(128, 37);
            BuyTicket.TabIndex = 3;
            BuyTicket.Text = "Купить";
            BuyTicket.UseVisualStyleBackColor = false;
            BuyTicket.Click += BuyTicket_Click;
            // 
            // NickNameBox
            // 
            NickNameBox.Location = new Point(611, 12);
            NickNameBox.Name = "NickNameBox";
            NickNameBox.Size = new Size(177, 23);
            NickNameBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(611, 48);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(177, 23);
            PasswordBox.TabIndex = 5;
            // 
            // trackBar
            // 
            trackBar.Location = new Point(173, 409);
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(104, 45);
            trackBar.TabIndex = 0;
            trackBar.Value = 5;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // CountTickets
            // 
            CountTickets.AutoSize = true;
            CountTickets.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountTickets.Location = new Point(12, 409);
            CountTickets.Name = "CountTickets";
            CountTickets.Size = new Size(155, 21);
            CountTickets.TabIndex = 6;
            CountTickets.Text = "Количество билетов";
            // 
            // SignIn
            // 
            SignIn.BackColor = SystemColors.ControlDark;
            SignIn.FlatAppearance.BorderSize = 0;
            SignIn.FlatStyle = FlatStyle.Flat;
            SignIn.Location = new Point(476, 12);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(108, 23);
            SignIn.TabIndex = 7;
            SignIn.Text = "Войти";
            SignIn.UseVisualStyleBackColor = false;
            SignIn.Click += SignIn_Click;
            // 
            // Registration
            // 
            Registration.BackColor = SystemColors.ControlDark;
            Registration.FlatAppearance.BorderSize = 0;
            Registration.FlatStyle = FlatStyle.Flat;
            Registration.Location = new Point(476, 48);
            Registration.Name = "Registration";
            Registration.Size = new Size(108, 23);
            Registration.TabIndex = 8;
            Registration.Text = "Регистрация";
            Registration.UseVisualStyleBackColor = false;
            Registration.Click += Registration_Click;
            // 
            // TitlePanel
            // 
            TitlePanel.AutoSize = true;
            TitlePanel.Location = new Point(3, 7);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(59, 15);
            TitlePanel.TabIndex = 9;
            TitlePanel.Text = "Профиль";
            TitlePanel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.ActiveCaption;
            Panel.Controls.Add(Balance);
            Panel.Controls.Add(NickName);
            Panel.Controls.Add(TextBalance);
            Panel.Controls.Add(TextNickname);
            Panel.Controls.Add(TitlePanel);
            Panel.Location = new Point(12, 12);
            Panel.Name = "Panel";
            Panel.Size = new Size(200, 71);
            Panel.TabIndex = 10;
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.Location = new Point(101, 50);
            Balance.Name = "Balance";
            Balance.Size = new Size(27, 15);
            Balance.TabIndex = 13;
            Balance.Text = "null";
            // 
            // NickName
            // 
            NickName.AutoSize = true;
            NickName.Location = new Point(101, 27);
            NickName.Name = "NickName";
            NickName.Size = new Size(27, 15);
            NickName.TabIndex = 12;
            NickName.Text = "null";
            // 
            // TextBalance
            // 
            TextBalance.AutoSize = true;
            TextBalance.Location = new Point(6, 50);
            TextBalance.Name = "TextBalance";
            TextBalance.Size = new Size(76, 15);
            TextBalance.TabIndex = 11;
            TextBalance.Text = "Ваш баланс:";
            // 
            // TextNickname
            // 
            TextNickname.AutoSize = true;
            TextNickname.Location = new Point(6, 27);
            TextNickname.Name = "TextNickname";
            TextNickname.Size = new Size(89, 15);
            TextNickname.TabIndex = 10;
            TextNickname.Text = "Ваш никнейм: ";
            // 
            // StatusPurchased
            // 
            StatusPurchased.AutoSize = true;
            StatusPurchased.Location = new Point(620, 412);
            StatusPurchased.Name = "StatusPurchased";
            StatusPurchased.Size = new Size(38, 15);
            StatusPurchased.TabIndex = 11;
            StatusPurchased.Text = "label1";
            // 
            // PriceTicket
            // 
            PriceTicket.AutoSize = true;
            PriceTicket.Location = new Point(283, 414);
            PriceTicket.Name = "PriceTicket";
            PriceTicket.Size = new Size(27, 15);
            PriceTicket.TabIndex = 12;
            PriceTicket.Text = "null";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PriceTicket);
            Controls.Add(StatusPurchased);
            Controls.Add(Panel);
            Controls.Add(Registration);
            Controls.Add(SignIn);
            Controls.Add(CountTickets);
            Controls.Add(trackBar);
            Controls.Add(PasswordBox);
            Controls.Add(NickNameBox);
            Controls.Add(BuyTicket);
            Controls.Add(groupBox);
            Controls.Add(CinemaName);
            Controls.Add(dateNow);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateNow;
        private Label CinemaName;
        private GroupBox groupBox;
        private Button BuyTicket;
        private TextBox NickNameBox;
        private TextBox PasswordBox;
        private TrackBar trackBar;
        private Label CountTickets;
        private PictureBox pictureBox1;
        private Label CinemaScreen;
        private Button SignIn;
        private Button Registration;
        private Label TitlePanel;
        private Panel Panel;
        private Label TextBalance;
        private Label TextNickname;
        private Label StatusPurchased;
        private Label NickName;
        private Label Balance;
        private Label PriceTicket;
    }
}
