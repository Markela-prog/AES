namespace AES
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioECB = new System.Windows.Forms.RadioButton();
            this.radioCBC = new System.Windows.Forms.RadioButton();
            this.radioCFB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.modeSelected = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnDecryptFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(694, 468);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(94, 29);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "Copy result";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Result:";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(62, 140);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(215, 27);
            this.keyInput.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Key:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 373);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(776, 89);
            this.result.TabIndex = 13;
            this.result.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(594, 135);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(94, 29);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(694, 135);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(94, 29);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(12, 40);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(776, 89);
            this.textInput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text:";
            // 
            // radioECB
            // 
            this.radioECB.AutoSize = true;
            this.radioECB.Location = new System.Drawing.Point(89, 204);
            this.radioECB.Name = "radioECB";
            this.radioECB.Size = new System.Drawing.Size(56, 24);
            this.radioECB.TabIndex = 18;
            this.radioECB.TabStop = true;
            this.radioECB.Text = "ECB";
            this.radioECB.UseVisualStyleBackColor = true;
            this.radioECB.CheckedChanged += new System.EventHandler(this.radioECB_CheckedChanged);
            // 
            // radioCBC
            // 
            this.radioCBC.AutoSize = true;
            this.radioCBC.Location = new System.Drawing.Point(89, 234);
            this.radioCBC.Name = "radioCBC";
            this.radioCBC.Size = new System.Drawing.Size(57, 24);
            this.radioCBC.TabIndex = 19;
            this.radioCBC.TabStop = true;
            this.radioCBC.Text = "CBC";
            this.radioCBC.UseVisualStyleBackColor = true;
            this.radioCBC.CheckedChanged += new System.EventHandler(this.radioCBC_CheckedChanged);
            // 
            // radioCFB
            // 
            this.radioCFB.AutoSize = true;
            this.radioCFB.Location = new System.Drawing.Point(89, 264);
            this.radioCFB.Name = "radioCFB";
            this.radioCFB.Size = new System.Drawing.Size(55, 24);
            this.radioCFB.TabIndex = 20;
            this.radioCFB.TabStop = true;
            this.radioCFB.Text = "CFB";
            this.radioCFB.UseVisualStyleBackColor = true;
            this.radioCFB.CheckedChanged += new System.EventHandler(this.radioCFB_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Modes:";
            // 
            // modeSelected
            // 
            this.modeSelected.AutoSize = true;
            this.modeSelected.Location = new System.Drawing.Point(12, 305);
            this.modeSelected.Name = "modeSelected";
            this.modeSelected.Size = new System.Drawing.Size(48, 20);
            this.modeSelected.TabIndex = 22;
            this.modeSelected.Text = "mode";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(594, 170);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(194, 29);
            this.btnSaveToFile.TabIndex = 23;
            this.btnSaveToFile.Text = "Encrypt and save in file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnDecryptFromFile
            // 
            this.btnDecryptFromFile.Location = new System.Drawing.Point(594, 205);
            this.btnDecryptFromFile.Name = "btnDecryptFromFile";
            this.btnDecryptFromFile.Size = new System.Drawing.Size(194, 29);
            this.btnDecryptFromFile.TabIndex = 24;
            this.btnDecryptFromFile.Text = "Decrypt from file";
            this.btnDecryptFromFile.UseVisualStyleBackColor = true;
            this.btnDecryptFromFile.Click += new System.EventHandler(this.btnDecryptFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnDecryptFromFile);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.modeSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioCFB);
            this.Controls.Add(this.radioCBC);
            this.Controls.Add(this.radioECB);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCopy;
        private Label label3;
        private TextBox keyInput;
        private Label label2;
        private RichTextBox result;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox textInput;
        private Label label1;
        private RadioButton radioECB;
        private RadioButton radioCBC;
        private RadioButton radioCFB;
        private Label label4;
        private Label modeSelected;
        private Button btnSaveToFile;
        private Button btnDecryptFromFile;
    }
}