namespace HotelApp
{
    partial class ReservationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reservationId = new System.Windows.Forms.TextBox();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.refreshImageBtn = new System.Windows.Forms.PictureBox();
            this.roomSearchBtn = new System.Windows.Forms.Button();
            this.reservationSearchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ReservationGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deleteRoomBtn = new System.Windows.Forms.Button();
            this.editRoomBtn = new System.Windows.Forms.Button();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.clientNameCombobox = new System.Windows.Forms.ComboBox();
            this.roomIdCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshImageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 165);
            this.panel1.TabIndex = 19;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(659, 126);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 20);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reservation  information";
            // 
            // reservationId
            // 
            this.reservationId.Location = new System.Drawing.Point(34, 228);
            this.reservationId.Name = "reservationId";
            this.reservationId.Size = new System.Drawing.Size(167, 20);
            this.reservationId.TabIndex = 20;
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(109, 445);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(200, 20);
            this.dateIn.TabIndex = 23;
            this.dateIn.ValueChanged += new System.EventHandler(this.dateIn_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Date In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date Out";
            // 
            // dateOut
            // 
            this.dateOut.Location = new System.Drawing.Point(109, 502);
            this.dateOut.Name = "dateOut";
            this.dateOut.Size = new System.Drawing.Size(200, 20);
            this.dateOut.TabIndex = 25;
            this.dateOut.ValueChanged += new System.EventHandler(this.dateOut_ValueChanged);
            // 
            // refreshImageBtn
            // 
            this.refreshImageBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshImageBtn.Image")));
            this.refreshImageBtn.Location = new System.Drawing.Point(663, 182);
            this.refreshImageBtn.Name = "refreshImageBtn";
            this.refreshImageBtn.Size = new System.Drawing.Size(24, 30);
            this.refreshImageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshImageBtn.TabIndex = 30;
            this.refreshImageBtn.TabStop = false;
            this.refreshImageBtn.Click += new System.EventHandler(this.refreshImageBtn_Click);
            // 
            // roomSearchBtn
            // 
            this.roomSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomSearchBtn.Location = new System.Drawing.Point(554, 182);
            this.roomSearchBtn.Name = "roomSearchBtn";
            this.roomSearchBtn.Size = new System.Drawing.Size(89, 30);
            this.roomSearchBtn.TabIndex = 29;
            this.roomSearchBtn.Text = "Search";
            this.roomSearchBtn.UseVisualStyleBackColor = true;
            this.roomSearchBtn.Click += new System.EventHandler(this.roomSearchBtn_Click);
            // 
            // reservationSearchbox
            // 
            this.reservationSearchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reservationSearchbox.DefaultText = "RoomSearch";
            this.reservationSearchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reservationSearchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reservationSearchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reservationSearchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reservationSearchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservationSearchbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reservationSearchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reservationSearchbox.Location = new System.Drawing.Point(370, 182);
            this.reservationSearchbox.Name = "reservationSearchbox";
            this.reservationSearchbox.PasswordChar = '\0';
            this.reservationSearchbox.PlaceholderText = "";
            this.reservationSearchbox.SelectedText = "";
            this.reservationSearchbox.Size = new System.Drawing.Size(161, 30);
            this.reservationSearchbox.TabIndex = 28;
            // 
            // ReservationGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReservationGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ReservationGridView.ColumnHeadersHeight = 24;
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReservationGridView.GridColor = System.Drawing.Color.Black;
            this.ReservationGridView.Location = new System.Drawing.Point(322, 228);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersVisible = false;
            this.ReservationGridView.Size = new System.Drawing.Size(478, 350);
            this.ReservationGridView.TabIndex = 27;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReservationGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.ReservationGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ReservationGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReservationGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReservationGridView.ThemeStyle.HeaderStyle.Height = 24;
            this.ReservationGridView.ThemeStyle.ReadOnly = false;
            this.ReservationGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReservationGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReservationGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ReservationGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReservationGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // deleteRoomBtn
            // 
            this.deleteRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoomBtn.Location = new System.Drawing.Point(109, 604);
            this.deleteRoomBtn.Name = "deleteRoomBtn";
            this.deleteRoomBtn.Size = new System.Drawing.Size(89, 52);
            this.deleteRoomBtn.TabIndex = 34;
            this.deleteRoomBtn.Text = "delete";
            this.deleteRoomBtn.UseVisualStyleBackColor = true;
            this.deleteRoomBtn.Click += new System.EventHandler(this.deleteRoomBtn_Click);
            // 
            // editRoomBtn
            // 
            this.editRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoomBtn.Location = new System.Drawing.Point(181, 546);
            this.editRoomBtn.Name = "editRoomBtn";
            this.editRoomBtn.Size = new System.Drawing.Size(89, 52);
            this.editRoomBtn.TabIndex = 33;
            this.editRoomBtn.Text = "EDIT";
            this.editRoomBtn.UseVisualStyleBackColor = true;
            this.editRoomBtn.Click += new System.EventHandler(this.editRoomBtn_Click);
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBtn.Location = new System.Drawing.Point(25, 546);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Size = new System.Drawing.Size(89, 52);
            this.addRoomBtn.TabIndex = 32;
            this.addRoomBtn.Text = "ADD";
            this.addRoomBtn.UseVisualStyleBackColor = true;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // clientNameCombobox
            // 
            this.clientNameCombobox.FormattingEnabled = true;
            this.clientNameCombobox.Location = new System.Drawing.Point(145, 282);
            this.clientNameCombobox.Name = "clientNameCombobox";
            this.clientNameCombobox.Size = new System.Drawing.Size(164, 21);
            this.clientNameCombobox.TabIndex = 35;
            // 
            // roomIdCombobox
            // 
            this.roomIdCombobox.FormattingEnabled = true;
            this.roomIdCombobox.Location = new System.Drawing.Point(145, 326);
            this.roomIdCombobox.Name = "roomIdCombobox";
            this.roomIdCombobox.Size = new System.Drawing.Size(164, 21);
            this.roomIdCombobox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Room";
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomIdCombobox);
            this.Controls.Add(this.clientNameCombobox);
            this.Controls.Add(this.deleteRoomBtn);
            this.Controls.Add(this.editRoomBtn);
            this.Controls.Add(this.addRoomBtn);
            this.Controls.Add(this.refreshImageBtn);
            this.Controls.Add(this.roomSearchBtn);
            this.Controls.Add(this.reservationSearchbox);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.reservationId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInfo";
            this.Load += new System.EventHandler(this.ReservationInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshImageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reservationId;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.PictureBox refreshImageBtn;
        private System.Windows.Forms.Button roomSearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox reservationSearchbox;
        private Guna.UI2.WinForms.Guna2DataGridView ReservationGridView;
        private System.Windows.Forms.Button deleteRoomBtn;
        private System.Windows.Forms.Button editRoomBtn;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.ComboBox clientNameCombobox;
        private System.Windows.Forms.ComboBox roomIdCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}