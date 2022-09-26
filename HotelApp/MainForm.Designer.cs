namespace HotelApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.staffBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.roomsBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.reservationBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staffBtn
            // 
            this.staffBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.staffBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.staffBtn.Image = ((System.Drawing.Image)(resources.GetObject("staffBtn.Image")));
            this.staffBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.staffBtn.ImageRotate = 0F;
            this.staffBtn.Location = new System.Drawing.Point(634, 96);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.staffBtn.Size = new System.Drawing.Size(131, 115);
            this.staffBtn.TabIndex = 1;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clients";
            // 
            // clientBtn
            // 
            this.clientBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.clientBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.clientBtn.Image = ((System.Drawing.Image)(resources.GetObject("clientBtn.Image")));
            this.clientBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.clientBtn.ImageRotate = 0F;
            this.clientBtn.Location = new System.Drawing.Point(37, 96);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.clientBtn.Size = new System.Drawing.Size(131, 115);
            this.clientBtn.TabIndex = 3;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rooms";
            // 
            // roomsBtn
            // 
            this.roomsBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.roomsBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.roomsBtn.Image = ((System.Drawing.Image)(resources.GetObject("roomsBtn.Image")));
            this.roomsBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.roomsBtn.ImageRotate = 0F;
            this.roomsBtn.Location = new System.Drawing.Point(37, 323);
            this.roomsBtn.Name = "roomsBtn";
            this.roomsBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.roomsBtn.Size = new System.Drawing.Size(147, 115);
            this.roomsBtn.TabIndex = 5;
            this.roomsBtn.Click += new System.EventHandler(this.roomsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reservation";
            // 
            // reservationBtn
            // 
            this.reservationBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.reservationBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.reservationBtn.Image = ((System.Drawing.Image)(resources.GetObject("reservationBtn.Image")));
            this.reservationBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.reservationBtn.ImageRotate = 0F;
            this.reservationBtn.Location = new System.Drawing.Point(622, 301);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.reservationBtn.Size = new System.Drawing.Size(131, 115);
            this.reservationBtn.TabIndex = 7;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.logoutBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.logoutBtn.ImageRotate = 0F;
            this.logoutBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.logoutBtn.Location = new System.Drawing.Point(377, 386);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.logoutBtn.Size = new System.Drawing.Size(35, 30);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reservationBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roomsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton staffBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton clientBtn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ImageButton roomsBtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton reservationBtn;
        private Guna.UI2.WinForms.Guna2ImageButton logoutBtn;
        private System.Windows.Forms.Label label1;
    }
}