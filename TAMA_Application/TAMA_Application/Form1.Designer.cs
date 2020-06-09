namespace TAMA_Application
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PiCamButton = new System.Windows.Forms.Button();
            this.SensorDataButton = new System.Windows.Forms.Button();
            this.MapButton = new System.Windows.Forms.Button();
            this.MapPictureBox = new System.Windows.Forms.PictureBox();
            this.MapPanel = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendLocationButton = new System.Windows.Forms.Button();
            this.SensorPanel = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SicaklikLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SicaklikMaxLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SicaklikMinLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SaveMapButton = new System.Windows.Forms.Button();
            this.StreamPanel = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).BeginInit();
            this.MapPanel.SuspendLayout();
            this.SensorPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.PiCamButton);
            this.groupBox1.Controls.Add(this.SensorDataButton);
            this.groupBox1.Controls.Add(this.MapButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // PiCamButton
            // 
            this.PiCamButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PiCamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PiCamButton.ForeColor = System.Drawing.Color.Crimson;
            this.PiCamButton.Image = ((System.Drawing.Image)(resources.GetObject("PiCamButton.Image")));
            this.PiCamButton.Location = new System.Drawing.Point(17, 264);
            this.PiCamButton.Name = "PiCamButton";
            this.PiCamButton.Size = new System.Drawing.Size(120, 107);
            this.PiCamButton.TabIndex = 4;
            this.PiCamButton.UseVisualStyleBackColor = false;
            this.PiCamButton.Click += new System.EventHandler(this.PiCamButton_Click);
            // 
            // SensorDataButton
            // 
            this.SensorDataButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SensorDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SensorDataButton.ForeColor = System.Drawing.Color.Crimson;
            this.SensorDataButton.Location = new System.Drawing.Point(17, 141);
            this.SensorDataButton.Name = "SensorDataButton";
            this.SensorDataButton.Size = new System.Drawing.Size(120, 107);
            this.SensorDataButton.TabIndex = 3;
            this.SensorDataButton.Text = "Sensör Verileri";
            this.SensorDataButton.UseVisualStyleBackColor = false;
            this.SensorDataButton.Click += new System.EventHandler(this.SensorDataButton_Click);
            // 
            // MapButton
            // 
            this.MapButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MapButton.ForeColor = System.Drawing.Color.Crimson;
            this.MapButton.Image = ((System.Drawing.Image)(resources.GetObject("MapButton.Image")));
            this.MapButton.Location = new System.Drawing.Point(17, 19);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(120, 107);
            this.MapButton.TabIndex = 2;
            this.MapButton.Text = "2D Harita";
            this.MapButton.UseVisualStyleBackColor = false;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // MapPictureBox
            // 
            this.MapPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MapPictureBox.Location = new System.Drawing.Point(0, 7);
            this.MapPictureBox.Name = "MapPictureBox";
            this.MapPictureBox.Size = new System.Drawing.Size(773, 364);
            this.MapPictureBox.TabIndex = 2;
            this.MapPictureBox.TabStop = false;
            // 
            // MapPanel
            // 
            this.MapPanel.Controls.Add(this.SaveMapButton);
            this.MapPanel.Controls.Add(this.MapPictureBox);
            this.MapPanel.Controls.Add(this.label3);
            this.MapPanel.Controls.Add(this.SendLocationButton);
            this.MapPanel.Controls.Add(this.label2);
            this.MapPanel.Controls.Add(this.label4);
            this.MapPanel.Controls.Add(this.textBox2);
            this.MapPanel.Controls.Add(this.textBox1);
            this.MapPanel.Controls.Add(this.label1);
            this.MapPanel.Location = new System.Drawing.Point(180, 31);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(845, 599);
            this.MapPanel.TabIndex = 3;
            this.MapPanel.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(52, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 29);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Z:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(52, 451);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 29);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(364, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X ekseni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(779, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Z ekseni";
            // 
            // SendLocationButton
            // 
            this.SendLocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendLocationButton.Location = new System.Drawing.Point(16, 486);
            this.SendLocationButton.Name = "SendLocationButton";
            this.SendLocationButton.Size = new System.Drawing.Size(120, 38);
            this.SendLocationButton.TabIndex = 10;
            this.SendLocationButton.Text = "Konum Gönder";
            this.SendLocationButton.UseVisualStyleBackColor = true;
            this.SendLocationButton.Click += new System.EventHandler(this.SendLocationButton_Click);
            // 
            // SensorPanel
            // 
            this.SensorPanel.Controls.Add(this.groupBox3);
            this.SensorPanel.Controls.Add(this.groupBox2);
            this.SensorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SensorPanel.Location = new System.Drawing.Point(179, 31);
            this.SensorPanel.Name = "SensorPanel";
            this.SensorPanel.Size = new System.Drawing.Size(785, 401);
            this.SensorPanel.TabIndex = 4;
            this.SensorPanel.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anlık:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.SicaklikMinLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SicaklikMaxLabel);
            this.groupBox2.Controls.Add(this.SicaklikLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(7, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 163);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sıcaklık Verileri";
            // 
            // SicaklikLabel
            // 
            this.SicaklikLabel.AutoSize = true;
            this.SicaklikLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SicaklikLabel.Location = new System.Drawing.Point(117, 41);
            this.SicaklikLabel.Name = "SicaklikLabel";
            this.SicaklikLabel.Size = new System.Drawing.Size(30, 24);
            this.SicaklikLabel.TabIndex = 12;
            this.SicaklikLabel.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(117, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "00";
            // 
            // SicaklikMaxLabel
            // 
            this.SicaklikMaxLabel.AutoSize = true;
            this.SicaklikMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SicaklikMaxLabel.Location = new System.Drawing.Point(6, 83);
            this.SicaklikMaxLabel.Name = "SicaklikMaxLabel";
            this.SicaklikMaxLabel.Size = new System.Drawing.Size(105, 24);
            this.SicaklikMaxLabel.TabIndex = 13;
            this.SicaklikMaxLabel.Text = "En Yüksek:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(117, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "00";
            // 
            // SicaklikMinLabel
            // 
            this.SicaklikMinLabel.AutoSize = true;
            this.SicaklikMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SicaklikMinLabel.Location = new System.Drawing.Point(6, 124);
            this.SicaklikMinLabel.Name = "SicaklikMinLabel";
            this.SicaklikMinLabel.Size = new System.Drawing.Size(97, 24);
            this.SicaklikMinLabel.TabIndex = 15;
            this.SicaklikMinLabel.Text = "En Düşük:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(7, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 163);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sıcaklık Verileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(117, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "En Düşük:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(117, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "En Yüksek:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(117, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 11;
            this.label13.Text = "Anlık:";
            // 
            // SaveMapButton
            // 
            this.SaveMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveMapButton.Location = new System.Drawing.Point(16, 530);
            this.SaveMapButton.Name = "SaveMapButton";
            this.SaveMapButton.Size = new System.Drawing.Size(120, 38);
            this.SaveMapButton.TabIndex = 11;
            this.SaveMapButton.Text = "3D Harita Al";
            this.SaveMapButton.UseVisualStyleBackColor = true;
            this.SaveMapButton.Click += new System.EventHandler(this.SaveMapButton_Click);
            // 
            // StreamPanel
            // 
            this.StreamPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StreamPanel.Location = new System.Drawing.Point(180, 38);
            this.StreamPanel.Name = "StreamPanel";
            this.StreamPanel.Size = new System.Drawing.Size(798, 394);
            this.StreamPanel.TabIndex = 12;
            this.StreamPanel.TabStop = false;
            this.StreamPanel.Text = "Rasberry Cam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 754);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SensorPanel);
            this.Controls.Add(this.StreamPanel);
            this.Controls.Add(this.MapPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).EndInit();
            this.MapPanel.ResumeLayout(false);
            this.MapPanel.PerformLayout();
            this.SensorPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MapButton;
        private System.Windows.Forms.Button PiCamButton;
        private System.Windows.Forms.Button SensorDataButton;
        private System.Windows.Forms.PictureBox MapPictureBox;
        private System.Windows.Forms.GroupBox MapPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendLocationButton;
        private System.Windows.Forms.GroupBox SensorPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label SicaklikMinLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SicaklikMaxLabel;
        private System.Windows.Forms.Label SicaklikLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveMapButton;
        private System.Windows.Forms.GroupBox StreamPanel;
    }
}

