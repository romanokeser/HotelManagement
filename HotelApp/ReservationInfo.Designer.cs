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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientNameTextbox = new System.Windows.Forms.TextBox();
            this.reservationId = new System.Windows.Forms.TextBox();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOut = new System.Windows.Forms.DateTimePicker();
            this.refreshImageBtn = new System.Windows.Forms.PictureBox();
            this.roomSearchBtn = new System.Windows.Forms.Button();
            this.reservationSearchbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deleteRoomBtn = new System.Windows.Forms.Button();
            this.editRoomBtn = new System.Windows.Forms.Button();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshImageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 165);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
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
            // clientNameTextbox
            // 
            this.clientNameTextbox.Location = new System.Drawing.Point(34, 273);
            this.clientNameTextbox.Name = "clientNameTextbox";
            this.clientNameTextbox.Size = new System.Drawing.Size(167, 20);
            this.clientNameTextbox.TabIndex = 21;
            // 
            // reservationId
            // 
            this.reservationId.Location = new System.Drawing.Point(34, 228);
            this.reservationId.Name = "reservationId";
            this.reservationId.Size = new System.Drawing.Size(167, 20);
            this.reservationId.TabIndex = 20;
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(34, 335);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(167, 20);
            this.roomNumber.TabIndex = 22;
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(109, 445);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(200, 20);
            this.dateIn.TabIndex = 23;
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
            // RoomGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.RoomGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RoomGridView.ColumnHeadersHeight = 24;
            this.RoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.RoomGridView.GridColor = System.Drawing.Color.Black;
            this.RoomGridView.Location = new System.Drawing.Point(322, 228);
            this.RoomGridView.Name = "RoomGridView";
            this.RoomGridView.RowHeadersVisible = false;
            this.RoomGridView.Size = new System.Drawing.Size(478, 350);
            this.RoomGridView.TabIndex = 27;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.RoomGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomGridView.ThemeStyle.HeaderStyle.Height = 24;
            this.RoomGridView.ThemeStyle.ReadOnly = false;
            this.RoomGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGridView.ThemeStyle.RowsStyle.Height = 22;
            this.RoomGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // 
            // ReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.deleteRoomBtn);
            this.Controls.Add(this.editRoomBtn);
            this.Controls.Add(this.addRoomBtn);
            this.Controls.Add(this.refreshImageBtn);
            this.Controls.Add(this.roomSearchBtn);
            this.Controls.Add(this.reservationSearchbox);
            this.Controls.Add(this.RoomGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateIn);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.clientNameTextbox);
            this.Controls.Add(this.reservationId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshImageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientNameTextbox;
        private System.Windows.Forms.TextBox reservationId;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateOut;
        private System.Windows.Forms.PictureBox refreshImageBtn;
        private System.Windows.Forms.Button roomSearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox reservationSearchbox;
        private Guna.UI2.WinForms.Guna2DataGridView RoomGridView;
        private System.Windows.Forms.Button deleteRoomBtn;
        private System.Windows.Forms.Button editRoomBtn;
        private System.Windows.Forms.Button addRoomBtn;
    }
}