namespace KPZLAB5
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
            this.btnWooden = new System.Windows.Forms.Button();
            this.btnBrick = new System.Windows.Forms.Button();
            this.btnModern = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.propertyGridOriginal = new System.Windows.Forms.PropertyGrid();
            this.flowLayoutPanelClones = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWooden
            // 
            this.btnWooden.Location = new System.Drawing.Point(802, 151);
            this.btnWooden.Name = "btnWooden";
            this.btnWooden.Size = new System.Drawing.Size(121, 23);
            this.btnWooden.TabIndex = 0;
            this.btnWooden.Text = "Дерев\'яний будинок";
            this.btnWooden.UseVisualStyleBackColor = true;
            this.btnWooden.Click += new System.EventHandler(this.btnWooden_Click);
            // 
            // btnBrick
            // 
            this.btnBrick.Location = new System.Drawing.Point(802, 215);
            this.btnBrick.Name = "btnBrick";
            this.btnBrick.Size = new System.Drawing.Size(121, 23);
            this.btnBrick.TabIndex = 1;
            this.btnBrick.Text = "Цегляний будинок";
            this.btnBrick.UseVisualStyleBackColor = true;
            this.btnBrick.Click += new System.EventHandler(this.btnBrick_Click);
            // 
            // btnModern
            // 
            this.btnModern.Location = new System.Drawing.Point(802, 279);
            this.btnModern.Name = "btnModern";
            this.btnModern.Size = new System.Drawing.Size(121, 23);
            this.btnModern.TabIndex = 2;
            this.btnModern.Text = "Сучасний будинок";
            this.btnModern.UseVisualStyleBackColor = true;
            this.btnModern.Click += new System.EventHandler(this.btnModern_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(135, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(802, 352);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(121, 23);
            this.btnClone.TabIndex = 5;
            this.btnClone.Text = "Клонувати";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // propertyGridOriginal
            // 
            this.propertyGridOriginal.HelpVisible = false;
            this.propertyGridOriginal.Location = new System.Drawing.Point(402, 151);
            this.propertyGridOriginal.Name = "propertyGridOriginal";
            this.propertyGridOriginal.Size = new System.Drawing.Size(318, 170);
            this.propertyGridOriginal.TabIndex = 6;
            // 
            // flowLayoutPanelClones
            // 
            this.flowLayoutPanelClones.AutoScroll = true;
            this.flowLayoutPanelClones.Location = new System.Drawing.Point(241, 385);
            this.flowLayoutPanelClones.Name = "flowLayoutPanelClones";
            this.flowLayoutPanelClones.Size = new System.Drawing.Size(1120, 280);
            this.flowLayoutPanelClones.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 677);
            this.Controls.Add(this.flowLayoutPanelClones);
            this.Controls.Add(this.propertyGridOriginal);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModern);
            this.Controls.Add(this.btnBrick);
            this.Controls.Add(this.btnWooden);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWooden;
        private System.Windows.Forms.Button btnBrick;
        private System.Windows.Forms.Button btnModern;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.PropertyGrid propertyGridOriginal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelClones;
    }
}

