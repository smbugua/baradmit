namespace PubIn.reports
{
    partial class ticketreports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.eventname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ticketgridview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Filter);
            this.panel1.Controls.Add(this.eventname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 512);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter.ForeColor = System.Drawing.Color.White;
            this.Filter.Location = new System.Drawing.Point(17, 168);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(156, 57);
            this.Filter.TabIndex = 5;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // eventname
            // 
            this.eventname.FormattingEnabled = true;
            this.eventname.Location = new System.Drawing.Point(17, 98);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(278, 31);
            this.eventname.TabIndex = 3;
            this.eventname.SelectedIndexChanged += new System.EventHandler(this.eventname_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ticketgridview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(367, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 512);
            this.panel2.TabIndex = 1;
            // 
            // ticketgridview
            // 
            this.ticketgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ticketgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketgridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketgridview.Location = new System.Drawing.Point(0, 0);
            this.ticketgridview.Name = "ticketgridview";
            this.ticketgridview.RowTemplate.Height = 24;
            this.ticketgridview.Size = new System.Drawing.Size(977, 512);
            this.ticketgridview.TabIndex = 0;
            this.ticketgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ticketreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ticketreports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TICKET REPORTS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ticketreports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox eventname;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.DataGridView ticketgridview;
        private System.Windows.Forms.Button button1;
    }
}