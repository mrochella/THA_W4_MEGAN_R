namespace THA_WEEK4_MEGAN_R
{
    partial class MainWindowsForm
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
            this.butt_submit = new System.Windows.Forms.Button();
            this.butt_open = new System.Windows.Forms.Button();
            this.checkBox_true = new System.Windows.Forms.CheckBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_artist = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_artist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butt_submit
            // 
            this.butt_submit.Enabled = false;
            this.butt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_submit.Location = new System.Drawing.Point(304, 281);
            this.butt_submit.Name = "butt_submit";
            this.butt_submit.Size = new System.Drawing.Size(75, 23);
            this.butt_submit.TabIndex = 0;
            this.butt_submit.Text = "SUBMIT";
            this.butt_submit.UseVisualStyleBackColor = true;
            this.butt_submit.Click += new System.EventHandler(this.butt_submit_Click);
            // 
            // butt_open
            // 
            this.butt_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_open.Location = new System.Drawing.Point(260, 35);
            this.butt_open.Name = "butt_open";
            this.butt_open.Size = new System.Drawing.Size(172, 23);
            this.butt_open.TabIndex = 1;
            this.butt_open.Text = "OPEN NEXT FORM";
            this.butt_open.UseVisualStyleBackColor = true;
            this.butt_open.Click += new System.EventHandler(this.butt_open_Click);
            // 
            // checkBox_true
            // 
            this.checkBox_true.AutoSize = true;
            this.checkBox_true.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_true.Location = new System.Drawing.Point(198, 234);
            this.checkBox_true.Name = "checkBox_true";
            this.checkBox_true.Size = new System.Drawing.Size(321, 24);
            this.checkBox_true.TabIndex = 2;
            this.checkBox_true.Text = "All of the content I put above is true!";
            this.checkBox_true.UseVisualStyleBackColor = true;
            this.checkBox_true.CheckedChanged += new System.EventHandler(this.checkBox_true_CheckedChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(226, 106);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(59, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "NAME";
            // 
            // label_artist
            // 
            this.label_artist.AutoSize = true;
            this.label_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_artist.Location = new System.Drawing.Point(88, 151);
            this.label_artist.Name = "label_artist";
            this.label_artist.Size = new System.Drawing.Size(197, 20);
            this.label_artist.TabIndex = 5;
            this.label_artist.Text = "MY FAVORITE ARTIST";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(313, 108);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(172, 20);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_artist
            // 
            this.textBox_artist.Location = new System.Drawing.Point(313, 150);
            this.textBox_artist.Name = "textBox_artist";
            this.textBox_artist.Size = new System.Drawing.Size(172, 20);
            this.textBox_artist.TabIndex = 7;
            // 
            // MainWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_artist);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_artist);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.checkBox_true);
            this.Controls.Add(this.butt_open);
            this.Controls.Add(this.butt_submit);
            this.Name = "MainWindowsForm";
            this.Text = "Main Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_submit;
        private System.Windows.Forms.Button butt_open;
        private System.Windows.Forms.CheckBox checkBox_true;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_artist;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_artist;
    }
}

