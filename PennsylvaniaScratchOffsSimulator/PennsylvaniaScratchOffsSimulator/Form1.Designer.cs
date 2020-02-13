namespace PennsylvaniaScratchOffsSimulator
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
            this.cb_List = new System.Windows.Forms.ComboBox();
            this.rtb_Stats = new System.Windows.Forms.RichTextBox();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.tb_Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_WinLoss = new System.Windows.Forms.Label();
            this.tb_WinLoss = new System.Windows.Forms.TextBox();
            this.tb_TicketsBought = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Github = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_List
            // 
            this.cb_List.FormattingEnabled = true;
            this.cb_List.Items.AddRange(new object[] {
            "5X THE MONEY",
            "Oh, What Fun",
            "$3 Million Limited"});
            this.cb_List.Location = new System.Drawing.Point(29, 51);
            this.cb_List.Name = "cb_List";
            this.cb_List.Size = new System.Drawing.Size(185, 21);
            this.cb_List.TabIndex = 0;
            this.cb_List.SelectedIndexChanged += new System.EventHandler(this.cb_List_SelectedIndexChanged);
            // 
            // rtb_Stats
            // 
            this.rtb_Stats.Location = new System.Drawing.Point(29, 88);
            this.rtb_Stats.Name = "rtb_Stats";
            this.rtb_Stats.Size = new System.Drawing.Size(185, 248);
            this.rtb_Stats.TabIndex = 1;
            this.rtb_Stats.Text = "";
            this.rtb_Stats.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_Stats_LinkClicked);
            // 
            // btn_Buy
            // 
            this.btn_Buy.Location = new System.Drawing.Point(260, 353);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(109, 23);
            this.btn_Buy.TabIndex = 2;
            this.btn_Buy.Text = "Buy Ticket";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // rtb_Output
            // 
            this.rtb_Output.Location = new System.Drawing.Point(220, 51);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.Size = new System.Drawing.Size(185, 285);
            this.rtb_Output.TabIndex = 3;
            this.rtb_Output.Text = "";
            this.rtb_Output.TextChanged += new System.EventHandler(this.rtb_Output_TextChanged);
            // 
            // tb_Balance
            // 
            this.tb_Balance.BackColor = System.Drawing.Color.LightGreen;
            this.tb_Balance.Location = new System.Drawing.Point(503, 51);
            this.tb_Balance.Name = "tb_Balance";
            this.tb_Balance.Size = new System.Drawing.Size(96, 20);
            this.tb_Balance.TabIndex = 4;
            this.tb_Balance.Text = "$500";
            this.tb_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Balance:";
            // 
            // lb_WinLoss
            // 
            this.lb_WinLoss.AutoSize = true;
            this.lb_WinLoss.Location = new System.Drawing.Point(411, 88);
            this.lb_WinLoss.Name = "lb_WinLoss";
            this.lb_WinLoss.Size = new System.Drawing.Size(59, 13);
            this.lb_WinLoss.TabIndex = 7;
            this.lb_WinLoss.Text = "Total Loss:";
            // 
            // tb_WinLoss
            // 
            this.tb_WinLoss.BackColor = System.Drawing.SystemColors.Window;
            this.tb_WinLoss.Location = new System.Drawing.Point(503, 88);
            this.tb_WinLoss.Name = "tb_WinLoss";
            this.tb_WinLoss.Size = new System.Drawing.Size(96, 20);
            this.tb_WinLoss.TabIndex = 8;
            this.tb_WinLoss.Text = "$0";
            this.tb_WinLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_TicketsBought
            // 
            this.tb_TicketsBought.Location = new System.Drawing.Point(503, 125);
            this.tb_TicketsBought.Name = "tb_TicketsBought";
            this.tb_TicketsBought.Size = new System.Drawing.Size(96, 20);
            this.tb_TicketsBought.TabIndex = 9;
            this.tb_TicketsBought.Text = "0";
            this.tb_TicketsBought.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tickets Bought:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_About,
            this.menu_Help,
            this.menu_Github});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_About
            // 
            this.menu_About.Name = "menu_About";
            this.menu_About.Size = new System.Drawing.Size(52, 20);
            this.menu_About.Text = "About";
            this.menu_About.Click += new System.EventHandler(this.menu_About_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(44, 20);
            this.menu_Help.Text = "Help";
            this.menu_Help.Click += new System.EventHandler(this.menu_Help_Click);
            // 
            // menu_Github
            // 
            this.menu_Github.Name = "menu_Github";
            this.menu_Github.Size = new System.Drawing.Size(57, 20);
            this.menu_Github.Text = "GitHub";
            this.menu_Github.Click += new System.EventHandler(this.menu_Github_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_TicketsBought);
            this.Controls.Add(this.tb_WinLoss);
            this.Controls.Add(this.lb_WinLoss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Balance);
            this.Controls.Add(this.rtb_Output);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.rtb_Stats);
            this.Controls.Add(this.cb_List);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pennsylvania Scratch Offs Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_List;
        private System.Windows.Forms.RichTextBox rtb_Stats;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.TextBox tb_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_WinLoss;
        private System.Windows.Forms.TextBox tb_WinLoss;
        private System.Windows.Forms.TextBox tb_TicketsBought;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_About;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripMenuItem menu_Github;
    }
}

