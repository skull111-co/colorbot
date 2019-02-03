namespace COLORBOT
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
			this.combo_Color = new System.Windows.Forms.ComboBox();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.worldid = new System.Windows.Forms.TextBox();
			this.toolTip_worldid = new System.Windows.Forms.ToolTip(this.components);
			this.btnConnect = new System.Windows.Forms.Button();
			this.code = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// combo_Color
			// 
			this.combo_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo_Color.FormattingEnabled = true;
			this.combo_Color.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Cyan",
            "Blue",
            "Purple"});
			this.combo_Color.Location = new System.Drawing.Point(315, 13);
			this.combo_Color.Name = "combo_Color";
			this.combo_Color.Size = new System.Drawing.Size(145, 21);
			this.combo_Color.TabIndex = 0;
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(13, 13);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(203, 20);
			this.username.TabIndex = 1;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(13, 39);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(203, 20);
			this.password.TabIndex = 2;
			// 
			// worldid
			// 
			this.worldid.Location = new System.Drawing.Point(12, 65);
			this.worldid.Name = "worldid";
			this.worldid.Size = new System.Drawing.Size(203, 20);
			this.worldid.TabIndex = 3;
			// 
			// toolTip_worldid
			// 
			this.toolTip_worldid.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip_worldid.ToolTipTitle = "About World ID";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(12, 92);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(204, 46);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// code
			// 
			this.code.Location = new System.Drawing.Point(347, 118);
			this.code.Name = "code";
			this.code.Size = new System.Drawing.Size(112, 20);
			this.code.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(222, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(222, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(222, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "World ID (room id)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(309, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Code";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 150);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.code);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.worldid);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.combo_Color);
			this.Name = "Form1";
			this.Text = "COLORBOT";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox combo_Color;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox worldid;
		private System.Windows.Forms.ToolTip toolTip_worldid;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox code;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

