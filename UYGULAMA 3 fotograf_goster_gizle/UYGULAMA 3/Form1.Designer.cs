
namespace UYGULAMA_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_goster = new System.Windows.Forms.Button();
            this.button_gizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_goster
            // 
            this.button_goster.Location = new System.Drawing.Point(12, 254);
            this.button_goster.Name = "button_goster";
            this.button_goster.Size = new System.Drawing.Size(75, 23);
            this.button_goster.TabIndex = 1;
            this.button_goster.Text = "GÖSTER";
            this.button_goster.UseVisualStyleBackColor = true;
            this.button_goster.Click += new System.EventHandler(this.button_goster_Click);
            // 
            // button_gizle
            // 
            this.button_gizle.Location = new System.Drawing.Point(244, 254);
            this.button_gizle.Name = "button_gizle";
            this.button_gizle.Size = new System.Drawing.Size(75, 23);
            this.button_gizle.TabIndex = 2;
            this.button_gizle.Text = "GİZLE";
            this.button_gizle.UseVisualStyleBackColor = true;
            this.button_gizle.Click += new System.EventHandler(this.button_gizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_gizle);
            this.Controls.Add(this.button_goster);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_goster;
        private System.Windows.Forms.Button button_gizle;
    }
}

