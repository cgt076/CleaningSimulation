
namespace Cleaning_Simulation
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_list = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wafer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbox_ip = new System.Windows.Forms.ComboBox();
            this.tbox_port = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_AddLine = new System.Windows.Forms.Button();
            this.cbox_line = new System.Windows.Forms.ComboBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_spin = new System.Windows.Forms.Label();
            this.lb_drop = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lv_list
            // 
            this.lv_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Wafer,
            this.progress,
            this.time});
            this.lv_list.FullRowSelect = true;
            this.lv_list.HideSelection = false;
            this.lv_list.Location = new System.Drawing.Point(22, 78);
            this.lv_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_list.Name = "lv_list";
            this.lv_list.Size = new System.Drawing.Size(277, 303);
            this.lv_list.TabIndex = 0;
            this.lv_list.UseCompatibleStateImageBehavior = false;
            this.lv_list.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 44;
            // 
            // Wafer
            // 
            this.Wafer.Text = "Wafer 개수";
            this.Wafer.Width = 94;
            // 
            // progress
            // 
            this.progress.Text = "진행상태";
            // 
            // time
            // 
            this.time.Text = "진행 시간";
            this.time.Width = 84;
            // 
            // cbox_ip
            // 
            this.cbox_ip.FormattingEnabled = true;
            this.cbox_ip.Location = new System.Drawing.Point(22, 26);
            this.cbox_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_ip.Name = "cbox_ip";
            this.cbox_ip.Size = new System.Drawing.Size(277, 20);
            this.cbox_ip.TabIndex = 1;
            // 
            // tbox_port
            // 
            this.tbox_port.Location = new System.Drawing.Point(328, 25);
            this.tbox_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_port.Name = "tbox_port";
            this.tbox_port.Size = new System.Drawing.Size(126, 21);
            this.tbox_port.TabIndex = 2;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(476, 26);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(66, 20);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "설정";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // btn_AddLine
            // 
            this.btn_AddLine.Location = new System.Drawing.Point(22, 396);
            this.btn_AddLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddLine.Name = "btn_AddLine";
            this.btn_AddLine.Size = new System.Drawing.Size(66, 31);
            this.btn_AddLine.TabIndex = 6;
            this.btn_AddLine.Text = "라인추가";
            this.btn_AddLine.UseVisualStyleBackColor = true;
            this.btn_AddLine.Click += new System.EventHandler(this.btn_AddLine_Click);
            // 
            // cbox_line
            // 
            this.cbox_line.FormattingEnabled = true;
            this.cbox_line.Location = new System.Drawing.Point(328, 78);
            this.cbox_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbox_line.Name = "cbox_line";
            this.cbox_line.Size = new System.Drawing.Size(126, 20);
            this.cbox_line.TabIndex = 7;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(476, 78);
            this.btn_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(66, 20);
            this.btn_set.TabIndex = 8;
            this.btn_set.Text = "관리";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Spin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Drop :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "진행 상태";
            // 
            // lb_spin
            // 
            this.lb_spin.AutoSize = true;
            this.lb_spin.Location = new System.Drawing.Point(397, 319);
            this.lb_spin.Name = "lb_spin";
            this.lb_spin.Size = new System.Drawing.Size(11, 12);
            this.lb_spin.TabIndex = 14;
            this.lb_spin.Text = "0";
            // 
            // lb_drop
            // 
            this.lb_drop.AutoSize = true;
            this.lb_drop.Location = new System.Drawing.Point(396, 356);
            this.lb_drop.Name = "lb_drop";
            this.lb_drop.Size = new System.Drawing.Size(11, 12);
            this.lb_drop.TabIndex = 15;
            this.lb_drop.Text = "0";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(471, 399);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(33, 12);
            this.lb_time.TabIndex = 17;
            this.lb_time.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "경과 시간 :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(328, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 161);
            this.panel1.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_drop);
            this.Controls.Add(this.lb_spin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.cbox_line);
            this.Controls.Add(this.btn_AddLine);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tbox_port);
            this.Controls.Add(this.cbox_ip);
            this.Controls.Add(this.lv_list);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_list;
        private System.Windows.Forms.ComboBox cbox_ip;
        private System.Windows.Forms.TextBox tbox_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_AddLine;
        private System.Windows.Forms.ComboBox cbox_line;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_spin;
        private System.Windows.Forms.Label lb_drop;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Wafer;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

