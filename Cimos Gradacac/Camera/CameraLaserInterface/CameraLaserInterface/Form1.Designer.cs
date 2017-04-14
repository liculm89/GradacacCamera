namespace CameraLaserInterface
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
            this.xCord = new System.Windows.Forms.TextBox();
            this.yCord = new System.Windows.Forms.TextBox();
            this.dmCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delbtn = new System.Windows.Forms.Button();
            this.promjerTxt = new System.Windows.Forms.TextBox();
            this.kutText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calc_coordinates = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xCord
            // 
            this.xCord.Location = new System.Drawing.Point(144, 32);
            this.xCord.Margin = new System.Windows.Forms.Padding(4);
            this.xCord.Name = "xCord";
            this.xCord.Size = new System.Drawing.Size(132, 22);
            this.xCord.TabIndex = 0;
            // 
            // yCord
            // 
            this.yCord.Location = new System.Drawing.Point(144, 65);
            this.yCord.Margin = new System.Windows.Forms.Padding(4);
            this.yCord.Name = "yCord";
            this.yCord.Size = new System.Drawing.Size(132, 22);
            this.yCord.TabIndex = 1;
            // 
            // dmCode
            // 
            this.dmCode.Location = new System.Drawing.Point(144, 99);
            this.dmCode.Margin = new System.Windows.Forms.Padding(4);
            this.dmCode.Name = "dmCode";
            this.dmCode.Size = new System.Drawing.Size(132, 22);
            this.dmCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "X koordinata";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y koordinata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datamatrix kod";
            // 
            // genFile
            // 
            this.genFile.Location = new System.Drawing.Point(56, 136);
            this.genFile.Name = "genFile";
            this.genFile.Size = new System.Drawing.Size(220, 37);
            this.genFile.TabIndex = 6;
            this.genFile.Text = "Generiraj file";
            this.genFile.UseVisualStyleBackColor = true;
            this.genFile.Click += new System.EventHandler(this.genFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calc_coordinates);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.kutText);
            this.groupBox1.Controls.Add(this.promjerTxt);
            this.groupBox1.Controls.Add(this.delbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.genFile);
            this.groupBox1.Controls.Add(this.xCord);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.yCord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dmCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 296);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Položaj centra DM koda";
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(56, 180);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(220, 37);
            this.delbtn.TabIndex = 7;
            this.delbtn.Text = "Izbriši file";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // promjerTxt
            // 
            this.promjerTxt.Location = new System.Drawing.Point(361, 32);
            this.promjerTxt.Name = "promjerTxt";
            this.promjerTxt.Size = new System.Drawing.Size(100, 22);
            this.promjerTxt.TabIndex = 8;
            // 
            // kutText
            // 
            this.kutText.Location = new System.Drawing.Point(361, 65);
            this.kutText.Name = "kutText";
            this.kutText.Size = new System.Drawing.Size(100, 22);
            this.kutText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Promjer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kut";
            // 
            // calc_coordinates
            // 
            this.calc_coordinates.Location = new System.Drawing.Point(303, 97);
            this.calc_coordinates.Name = "calc_coordinates";
            this.calc_coordinates.Size = new System.Drawing.Size(158, 39);
            this.calc_coordinates.TabIndex = 12;
            this.calc_coordinates.Text = "Izračun koordinata";
            this.calc_coordinates.UseVisualStyleBackColor = true;
            this.calc_coordinates.Click += new System.EventHandler(this.calc_coordinates_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 320);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox xCord;
        private System.Windows.Forms.TextBox yCord;
        private System.Windows.Forms.TextBox dmCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button genFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button calc_coordinates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kutText;
        private System.Windows.Forms.TextBox promjerTxt;
    }
}

