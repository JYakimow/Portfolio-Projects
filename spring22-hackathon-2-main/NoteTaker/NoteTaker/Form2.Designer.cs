
namespace NoteTaker
{
    partial class Form2
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
            this.store = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.noteBody = new System.Windows.Forms.TextBox();
            this.noteTitle = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // store
            // 
            this.store.Location = new System.Drawing.Point(86, 316);
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(75, 23);
            this.store.TabIndex = 0;
            this.store.Text = "store";
            this.store.UseVisualStyleBackColor = true;
            this.store.Click += new System.EventHandler(this.button1_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(86, 274);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 1;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // noteBody
            // 
            this.noteBody.Location = new System.Drawing.Point(189, 149);
            this.noteBody.Name = "noteBody";
            this.noteBody.Size = new System.Drawing.Size(152, 20);
            this.noteBody.TabIndex = 2;
            this.noteBody.Text = "body";
            // 
            // noteTitle
            // 
            this.noteTitle.Location = new System.Drawing.Point(161, 54);
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.Size = new System.Drawing.Size(254, 20);
            this.noteTitle.TabIndex = 3;
            this.noteTitle.Text = "title";
            this.noteTitle.TextChanged += new System.EventHandler(this.noteTitle_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(572, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.noteTitle);
            this.Controls.Add(this.noteBody);
            this.Controls.Add(this.load);
            this.Controls.Add(this.store);
            this.Name = "Form1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button store;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox noteBody;
        private System.Windows.Forms.TextBox noteTitle;
        private System.Windows.Forms.ListBox listBox1;
    }
}

