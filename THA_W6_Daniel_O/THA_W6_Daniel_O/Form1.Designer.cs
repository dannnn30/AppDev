namespace THA_W6_Daniel_O
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tebox_guess = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "WORDLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set How Much You Can Guess!!!\r\n";
            // 
            // tebox_guess
            // 
            this.tebox_guess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tebox_guess.Location = new System.Drawing.Point(182, 169);
            this.tebox_guess.Name = "tebox_guess";
            this.tebox_guess.Size = new System.Drawing.Size(100, 24);
            this.tebox_guess.TabIndex = 2;
            this.tebox_guess.TextChanged += new System.EventHandler(this.tebox_guess_TextChanged);
            this.tebox_guess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tebox_guess_KeyPress);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(188, 229);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(86, 33);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "play!!!!";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 305);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.tebox_guess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tebox_guess;
        private System.Windows.Forms.Button button_play;
    }
}

