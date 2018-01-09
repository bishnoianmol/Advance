namespace Planb.winforms.Forms
{
    partial class user
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.Oldertransaction = new System.Windows.Forms.Button();
            this.transaction = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Home = new System.Windows.Forms.Button();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.uctransaction1 = new Planb.winforms.Controls.uctransaction();
            this.panel2.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.Oldertransaction);
            this.panel2.Controls.Add(this.transaction);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(143, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 190);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 41);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Oldertransaction
            // 
            this.Oldertransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Oldertransaction.BackColor = System.Drawing.Color.White;
            this.Oldertransaction.FlatAppearance.BorderSize = 0;
            this.Oldertransaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.Oldertransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Oldertransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Oldertransaction.Location = new System.Drawing.Point(-1, 85);
            this.Oldertransaction.Name = "Oldertransaction";
            this.Oldertransaction.Size = new System.Drawing.Size(140, 41);
            this.Oldertransaction.TabIndex = 0;
            this.Oldertransaction.Text = "Older Transaction";
            this.Oldertransaction.UseVisualStyleBackColor = false;
            this.Oldertransaction.Click += new System.EventHandler(this.Oldertransaction_Click);
            // 
            // transaction
            // 
            this.transaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transaction.BackColor = System.Drawing.Color.White;
            this.transaction.FlatAppearance.BorderSize = 0;
            this.transaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.transaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaction.Location = new System.Drawing.Point(-1, 38);
            this.transaction.Name = "transaction";
            this.transaction.Size = new System.Drawing.Size(140, 41);
            this.transaction.TabIndex = 0;
            this.transaction.Text = "Transaction";
            this.transaction.UseVisualStyleBackColor = false;
            this.transaction.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.Home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Location = new System.Drawing.Point(1, 23);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(142, 41);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.uctransaction1);
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(1, 193);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(816, 307);
            this.Panel.TabIndex = 2;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // uctransaction1
            // 
            this.uctransaction1.Location = new System.Drawing.Point(115, 3);
            this.uctransaction1.Name = "uctransaction1";
            this.uctransaction1.Size = new System.Drawing.Size(587, 394);
            this.uctransaction1.TabIndex = 2;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 504);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.panel2);
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.user_Load);
            this.MouseHover += new System.EventHandler(this.user_MouseHover);
            this.panel2.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Oldertransaction;
        private System.Windows.Forms.Button transaction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Home;
        private MetroFramework.Controls.MetroPanel Panel;
        private Controls.uctransaction uctransaction1;
    }
}