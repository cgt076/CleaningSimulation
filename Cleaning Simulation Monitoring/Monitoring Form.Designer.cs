
namespace Cleaning_Simulation_Monitoring
{
    partial class Form1
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
            this.tbox_fa_port = new System.Windows.Forms.TextBox();
            this.btn_set_fa = new System.Windows.Forms.Button();
            this.btn_set_me = new System.Windows.Forms.Button();
            this.tbox_me_port = new System.Windows.Forms.TextBox();
            this.lv_list = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wafer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbar_HF = new System.Windows.Forms.TrackBar();
            this.tbar_SC1 = new System.Windows.Forms.TrackBar();
            this.tbar_SC2 = new System.Windows.Forms.TrackBar();
            this.tbar_spin = new System.Windows.Forms.TrackBar();
            this.tbar_drop = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_HF = new System.Windows.Forms.Button();
            this.btn_SC1 = new System.Windows.Forms.Button();
            this.btn_SC2 = new System.Windows.Forms.Button();
            this.pn_SC1 = new System.Windows.Forms.Panel();
            this.pn_SC2 = new System.Windows.Forms.Panel();
            this.pn_HF = new System.Windows.Forms.Panel();
            this.tbox_fa_ip = new System.Windows.Forms.TextBox();
            this.tbox_me_ip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_HF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_SC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_SC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_fa_port
            // 
            this.tbox_fa_port.Location = new System.Drawing.Point(383, 29);
            this.tbox_fa_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_fa_port.Name = "tbox_fa_port";
            this.tbox_fa_port.Size = new System.Drawing.Size(114, 21);
            this.tbox_fa_port.TabIndex = 3;
            // 
            // btn_set_fa
            // 
            this.btn_set_fa.Location = new System.Drawing.Point(518, 30);
            this.btn_set_fa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_set_fa.Name = "btn_set_fa";
            this.btn_set_fa.Size = new System.Drawing.Size(66, 18);
            this.btn_set_fa.TabIndex = 4;
            this.btn_set_fa.Text = "설정";
            this.btn_set_fa.UseVisualStyleBackColor = true;
            // 
            // btn_set_me
            // 
            this.btn_set_me.Location = new System.Drawing.Point(518, 66);
            this.btn_set_me.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_set_me.Name = "btn_set_me";
            this.btn_set_me.Size = new System.Drawing.Size(66, 18);
            this.btn_set_me.TabIndex = 7;
            this.btn_set_me.Text = "설정";
            this.btn_set_me.UseVisualStyleBackColor = true;
            // 
            // tbox_me_port
            // 
            this.tbox_me_port.Location = new System.Drawing.Point(383, 64);
            this.tbox_me_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_me_port.Name = "tbox_me_port";
            this.tbox_me_port.Size = new System.Drawing.Size(114, 21);
            this.tbox_me_port.TabIndex = 6;
            // 
            // lv_list
            // 
            this.lv_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Wafer,
            this.progress,
            this.time});
            this.lv_list.HideSelection = false;
            this.lv_list.Location = new System.Drawing.Point(30, 118);
            this.lv_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_list.Name = "lv_list";
            this.lv_list.Size = new System.Drawing.Size(262, 274);
            this.lv_list.TabIndex = 8;
            this.lv_list.UseCompatibleStateImageBehavior = false;
            this.lv_list.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 39;
            // 
            // Wafer
            // 
            this.Wafer.Text = "Wafer 개수";
            this.Wafer.Width = 94;
            // 
            // progress
            // 
            this.progress.Text = "진행상태";
            this.progress.Width = 72;
            // 
            // time
            // 
            this.time.Text = "진행 시간";
            this.time.Width = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Spin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "SC-2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "SC-1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "HF:";
            // 
            // tbar_HF
            // 
            this.tbar_HF.Location = new System.Drawing.Point(383, 198);
            this.tbar_HF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbar_HF.Name = "tbar_HF";
            this.tbar_HF.Size = new System.Drawing.Size(114, 45);
            this.tbar_HF.TabIndex = 18;
            // 
            // tbar_SC1
            // 
            this.tbar_SC1.Location = new System.Drawing.Point(383, 238);
            this.tbar_SC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbar_SC1.Name = "tbar_SC1";
            this.tbar_SC1.Size = new System.Drawing.Size(114, 45);
            this.tbar_SC1.TabIndex = 19;
            // 
            // tbar_SC2
            // 
            this.tbar_SC2.Location = new System.Drawing.Point(383, 278);
            this.tbar_SC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbar_SC2.Name = "tbar_SC2";
            this.tbar_SC2.Size = new System.Drawing.Size(114, 45);
            this.tbar_SC2.TabIndex = 20;
            // 
            // tbar_spin
            // 
            this.tbar_spin.Location = new System.Drawing.Point(383, 318);
            this.tbar_spin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbar_spin.Name = "tbar_spin";
            this.tbar_spin.Size = new System.Drawing.Size(114, 45);
            this.tbar_spin.TabIndex = 21;
            // 
            // tbar_drop
            // 
            this.tbar_drop.Location = new System.Drawing.Point(383, 358);
            this.tbar_drop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbar_drop.Name = "tbar_drop";
            this.tbar_drop.Size = new System.Drawing.Size(114, 45);
            this.tbar_drop.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "Drop:";
            // 
            // btn_HF
            // 
            this.btn_HF.Location = new System.Drawing.Point(518, 201);
            this.btn_HF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HF.Name = "btn_HF";
            this.btn_HF.Size = new System.Drawing.Size(66, 18);
            this.btn_HF.TabIndex = 25;
            this.btn_HF.Text = "설정";
            this.btn_HF.UseVisualStyleBackColor = true;
            // 
            // btn_SC1
            // 
            this.btn_SC1.Location = new System.Drawing.Point(518, 241);
            this.btn_SC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SC1.Name = "btn_SC1";
            this.btn_SC1.Size = new System.Drawing.Size(66, 18);
            this.btn_SC1.TabIndex = 26;
            this.btn_SC1.Text = "설정";
            this.btn_SC1.UseVisualStyleBackColor = true;
            // 
            // btn_SC2
            // 
            this.btn_SC2.Location = new System.Drawing.Point(518, 281);
            this.btn_SC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SC2.Name = "btn_SC2";
            this.btn_SC2.Size = new System.Drawing.Size(66, 18);
            this.btn_SC2.TabIndex = 27;
            this.btn_SC2.Text = "설정";
            this.btn_SC2.UseVisualStyleBackColor = true;
            // 
            // pn_SC1
            // 
            this.pn_SC1.Location = new System.Drawing.Point(416, 118);
            this.pn_SC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_SC1.Name = "pn_SC1";
            this.pn_SC1.Size = new System.Drawing.Size(66, 64);
            this.pn_SC1.TabIndex = 29;
            // 
            // pn_SC2
            // 
            this.pn_SC2.Location = new System.Drawing.Point(518, 118);
            this.pn_SC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_SC2.Name = "pn_SC2";
            this.pn_SC2.Size = new System.Drawing.Size(66, 64);
            this.pn_SC2.TabIndex = 30;
            // 
            // pn_HF
            // 
            this.pn_HF.Location = new System.Drawing.Point(315, 118);
            this.pn_HF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_HF.Name = "pn_HF";
            this.pn_HF.Size = new System.Drawing.Size(66, 64);
            this.pn_HF.TabIndex = 30;
            // 
            // tbox_fa_ip
            // 
            this.tbox_fa_ip.Location = new System.Drawing.Point(30, 29);
            this.tbox_fa_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_fa_ip.Name = "tbox_fa_ip";
            this.tbox_fa_ip.Size = new System.Drawing.Size(332, 21);
            this.tbox_fa_ip.TabIndex = 31;
            // 
            // tbox_me_ip
            // 
            this.tbox_me_ip.Location = new System.Drawing.Point(30, 64);
            this.tbox_me_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbox_me_ip.Name = "tbox_me_ip";
            this.tbox_me_ip.Size = new System.Drawing.Size(332, 21);
            this.tbox_me_ip.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 422);
            this.Controls.Add(this.tbox_me_ip);
            this.Controls.Add(this.tbox_fa_ip);
            this.Controls.Add(this.pn_HF);
            this.Controls.Add(this.pn_SC2);
            this.Controls.Add(this.pn_SC1);
            this.Controls.Add(this.btn_SC2);
            this.Controls.Add(this.btn_SC1);
            this.Controls.Add(this.btn_HF);
            this.Controls.Add(this.tbar_drop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbar_spin);
            this.Controls.Add(this.tbar_SC2);
            this.Controls.Add(this.tbar_SC1);
            this.Controls.Add(this.tbar_HF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_list);
            this.Controls.Add(this.btn_set_me);
            this.Controls.Add(this.tbox_me_port);
            this.Controls.Add(this.btn_set_fa);
            this.Controls.Add(this.tbox_fa_port);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbar_HF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_SC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_SC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_spin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbar_drop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbox_fa_port;
        private System.Windows.Forms.Button btn_set_fa;
        private System.Windows.Forms.Button btn_set_me;
        private System.Windows.Forms.TextBox tbox_me_port;
        private System.Windows.Forms.ListView lv_list;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Wafer;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbar_HF;
        private System.Windows.Forms.TrackBar tbar_SC1;
        private System.Windows.Forms.TrackBar tbar_SC2;
        private System.Windows.Forms.TrackBar tbar_spin;
        private System.Windows.Forms.TrackBar tbar_drop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_HF;
        private System.Windows.Forms.Button btn_SC1;
        private System.Windows.Forms.Button btn_SC2;
        private System.Windows.Forms.Panel pn_SC1;
        private System.Windows.Forms.Panel pn_SC2;
        private System.Windows.Forms.Panel pn_HF;
        private System.Windows.Forms.TextBox tbox_fa_ip;
        private System.Windows.Forms.TextBox tbox_me_ip;
    }
}

