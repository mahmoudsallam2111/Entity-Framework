namespace EF_lab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_topic = new System.Windows.Forms.DataGridView();
            this.btn_srearch = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_topicName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.NumericUpDown();
            this.combo_topic = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_updatw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.D_G_VStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_G_VStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_topic
            // 
            this.dgv_topic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_topic.Location = new System.Drawing.Point(12, 237);
            this.dgv_topic.Name = "dgv_topic";
            this.dgv_topic.RowHeadersWidth = 51;
            this.dgv_topic.RowTemplate.Height = 29;
            this.dgv_topic.Size = new System.Drawing.Size(336, 201);
            this.dgv_topic.TabIndex = 0;
            this.dgv_topic.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_topic_RowHeaderMouseDoubleClick);
            // 
            // btn_srearch
            // 
            this.btn_srearch.Location = new System.Drawing.Point(12, 42);
            this.btn_srearch.Name = "btn_srearch";
            this.btn_srearch.Size = new System.Drawing.Size(132, 29);
            this.btn_srearch.TabIndex = 1;
            this.btn_srearch.Text = "Start Search";
            this.btn_srearch.UseVisualStyleBackColor = true;
            this.btn_srearch.Click += new System.EventHandler(this.btn_srearch_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(172, 42);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(155, 27);
            this.txt_input.TabIndex = 2;
            // 
            // txt_topicName
            // 
            this.txt_topicName.Location = new System.Drawing.Point(185, 112);
            this.txt_topicName.Name = "txt_topicName";
            this.txt_topicName.Size = new System.Drawing.Size(125, 27);
            this.txt_topicName.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(55, 175);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add topic";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Topic Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(382, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "topic_id";
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(504, 108);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(150, 27);
            this.input_id.TabIndex = 9;
            // 
            // combo_topic
            // 
            this.combo_topic.FormattingEnabled = true;
            this.combo_topic.Location = new System.Drawing.Point(606, 41);
            this.combo_topic.Name = "combo_topic";
            this.combo_topic.Size = new System.Drawing.Size(151, 28);
            this.combo_topic.TabIndex = 10;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(246, 175);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(137, 29);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete topic";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_updatw
            // 
            this.btn_updatw.Location = new System.Drawing.Point(504, 175);
            this.btn_updatw.Name = "btn_updatw";
            this.btn_updatw.Size = new System.Drawing.Size(94, 29);
            this.btn_updatw.TabIndex = 12;
            this.btn_updatw.Text = "Update topic";
            this.btn_updatw.UseVisualStyleBackColor = true;
            this.btn_updatw.Click += new System.EventHandler(this.btn_updatw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(479, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "select TO delete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(349, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 36);
            this.label4.TabIndex = 14;
            this.label4.Text = "ITI";
            // 
            // D_G_VStudent
            // 
            this.D_G_VStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.D_G_VStudent.Location = new System.Drawing.Point(404, 237);
            this.D_G_VStudent.Name = "D_G_VStudent";
            this.D_G_VStudent.RowHeadersWidth = 51;
            this.D_G_VStudent.RowTemplate.Height = 29;
            this.D_G_VStudent.Size = new System.Drawing.Size(384, 188);
            this.D_G_VStudent.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.D_G_VStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_updatw);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.combo_topic);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_topicName);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_srearch);
            this.Controls.Add(this.dgv_topic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D_G_VStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_topic;
        private Button btn_srearch;
        private TextBox txt_input;
        private TextBox txt_topicName;
        private Button btn_Add;
        private Label label1;
        private Label label2;
        private NumericUpDown input_id;
        private ComboBox combo_topic;
        private Button btn_delete;
        private Button btn_updatw;
        private Label label3;
        private Label label4;
        private DataGridView D_G_VStudent;
    }
}