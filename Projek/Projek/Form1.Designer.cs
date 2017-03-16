namespace Projek
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new ns1.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuMetroTextbox2 = new ns1.BunifuMetroTextbox();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuCheckbox1 = new ns1.BunifuCheckbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCheckbox2 = new ns1.BunifuCheckbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Login";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.MediumAquamarine;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Teal;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(29, 112);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(315, 44);
            this.bunifuMetroTextbox1.TabIndex = 1;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(37, 86);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(101, 22);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(37, 167);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(95, 22);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.MediumAquamarine;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Teal;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(29, 193);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(315, 44);
            this.bunifuMetroTextbox2.TabIndex = 3;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Login";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(226, 313);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(118, 42);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Login";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Teal;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.Teal;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(70, 255);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 6;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(96, 255);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 21);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Admin";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(244, 255);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(44, 21);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Kasir";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.Teal;
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = false;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.Teal;
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(218, 255);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 367);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuMetroTextbox2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCheckbox bunifuCheckbox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCheckbox bunifuCheckbox1;
    }
}

