namespace THA_W3_Daniel_O
{
    partial class MainForm
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
            this.btn_next = new System.Windows.Forms.Button();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_fav = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_fav = new System.Windows.Forms.TextBox();
            this.cb_valid = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(282, 253);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(178, 60);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Open Next Form";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(45, 53);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(80, 25);
            this.lab_name.TabIndex = 1;
            this.lab_name.Text = "Name: ";
            // 
            // lab_fav
            // 
            this.lab_fav.AutoSize = true;
            this.lab_fav.Location = new System.Drawing.Point(45, 87);
            this.lab_fav.Name = "lab_fav";
            this.lab_fav.Size = new System.Drawing.Size(183, 25);
            this.lab_fav.TabIndex = 2;
            this.lab_fav.Text = "My favorite artist: ";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(119, 46);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(240, 31);
            this.tb_name.TabIndex = 3;
            // 
            // tb_fav
            // 
            this.tb_fav.Location = new System.Drawing.Point(221, 81);
            this.tb_fav.Name = "tb_fav";
            this.tb_fav.Size = new System.Drawing.Size(138, 31);
            this.tb_fav.TabIndex = 4;
            // 
            // cb_valid
            // 
            this.cb_valid.AutoSize = true;
            this.cb_valid.Location = new System.Drawing.Point(50, 189);
            this.cb_valid.Name = "cb_valid";
            this.cb_valid.Size = new System.Drawing.Size(388, 29);
            this.cb_valid.TabIndex = 5;
            this.cb_valid.Text = "All of the content I put above is true!";
            this.cb_valid.UseVisualStyleBackColor = true;
            this.cb_valid.CheckedChanged += new System.EventHandler(this.cb_valid_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(72, 253);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(178, 60);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 681);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_valid);
            this.Controls.Add(this.tb_fav);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lab_fav);
            this.Controls.Add(this.lab_name);
            this.Controls.Add(this.btn_next);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_fav;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_fav;
        private System.Windows.Forms.CheckBox cb_valid;
        private System.Windows.Forms.Button btn_submit;
    }
}

