namespace BotNumbers
{
    partial class BotGeneral
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotGeneral));
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_replay = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_x
            // 
            this.text_x.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.text_x.Enabled = false;
            this.text_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.text_x.Location = new System.Drawing.Point(26, 118);
            this.text_x.Multiline = true;
            this.text_x.Name = "text_x";
            this.text_x.Size = new System.Drawing.Size(261, 263);
            this.text_x.TabIndex = 0;
            // 
            // text_y
            // 
            this.text_y.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.text_y.Enabled = false;
            this.text_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_y.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.text_y.Location = new System.Drawing.Point(345, 118);
            this.text_y.Multiline = true;
            this.text_y.Name = "text_y";
            this.text_y.Size = new System.Drawing.Size(266, 263);
            this.text_y.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Navy;
            this.button_add.Location = new System.Drawing.Point(46, 409);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(137, 41);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "ADD COORDS";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_replay
            // 
            this.button_replay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_replay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_replay.ForeColor = System.Drawing.Color.Navy;
            this.button_replay.Location = new System.Drawing.Point(243, 387);
            this.button_replay.Name = "button_replay";
            this.button_replay.Size = new System.Drawing.Size(129, 63);
            this.button_replay.TabIndex = 3;
            this.button_replay.Text = "START CLICKING";
            this.button_replay.UseVisualStyleBackColor = false;
            this.button_replay.Click += new System.EventHandler(this.button_replay_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.Navy;
            this.button_reset.Location = new System.Drawing.Point(446, 409);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(134, 41);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X COORDINATES:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y COORDINATES:";
            // 
            // BotGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BotNumbers.Properties.Resources.bot;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(641, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_replay);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BotGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Game Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_replay;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

