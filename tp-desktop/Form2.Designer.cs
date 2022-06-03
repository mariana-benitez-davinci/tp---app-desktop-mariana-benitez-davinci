namespace tp_desktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtraerAudio = new System.Windows.Forms.Button();
            this.btnRemoverAudio = new System.Windows.Forms.Button();
            this.btnCambiarResolucion = new System.Windows.Forms.Button();
            this.btnExtraerImagen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnMp4 = new System.Windows.Forms.RadioButton();
            this.rbtnWmv = new System.Windows.Forms.RadioButton();
            this.rbtnAvi = new System.Windows.Forms.RadioButton();
            this.rbtnMov = new System.Windows.Forms.RadioButton();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 32);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(233, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "   Seleccionar \r\narchivo de video\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExtraerAudio
            // 
            this.btnExtraerAudio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExtraerAudio.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.btnExtraerAudio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExtraerAudio.Location = new System.Drawing.Point(64, 354);
            this.btnExtraerAudio.Name = "btnExtraerAudio";
            this.btnExtraerAudio.Size = new System.Drawing.Size(188, 36);
            this.btnExtraerAudio.TabIndex = 3;
            this.btnExtraerAudio.Text = "Extraer audio";
            this.btnExtraerAudio.UseVisualStyleBackColor = false;
            this.btnExtraerAudio.Click += new System.EventHandler(this.btnExtraerAudio_Click);
            // 
            // btnRemoverAudio
            // 
            this.btnRemoverAudio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoverAudio.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.btnRemoverAudio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoverAudio.Location = new System.Drawing.Point(64, 479);
            this.btnRemoverAudio.Name = "btnRemoverAudio";
            this.btnRemoverAudio.Size = new System.Drawing.Size(188, 36);
            this.btnRemoverAudio.TabIndex = 4;
            this.btnRemoverAudio.Text = "Remover audio";
            this.btnRemoverAudio.UseVisualStyleBackColor = false;
            this.btnRemoverAudio.Click += new System.EventHandler(this.btnRemoverAudio_Click);
            // 
            // btnCambiarResolucion
            // 
            this.btnCambiarResolucion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCambiarResolucion.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.btnCambiarResolucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiarResolucion.Location = new System.Drawing.Point(64, 292);
            this.btnCambiarResolucion.Name = "btnCambiarResolucion";
            this.btnCambiarResolucion.Size = new System.Drawing.Size(188, 36);
            this.btnCambiarResolucion.TabIndex = 5;
            this.btnCambiarResolucion.Text = "Cambiar resolución";
            this.btnCambiarResolucion.UseVisualStyleBackColor = false;
            this.btnCambiarResolucion.Click += new System.EventHandler(this.btnCambiarResolucion_Click);
            // 
            // btnExtraerImagen
            // 
            this.btnExtraerImagen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExtraerImagen.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.btnExtraerImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExtraerImagen.Location = new System.Drawing.Point(64, 419);
            this.btnExtraerImagen.Name = "btnExtraerImagen";
            this.btnExtraerImagen.Size = new System.Drawing.Size(188, 39);
            this.btnExtraerImagen.TabIndex = 6;
            this.btnExtraerImagen.Text = "Extraer imagen";
            this.btnExtraerImagen.UseVisualStyleBackColor = false;
            this.btnExtraerImagen.Click += new System.EventHandler(this.btnExtraerImagen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 29);
            this.textBox1.TabIndex = 7;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExaminar.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.btnExaminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExaminar.Location = new System.Drawing.Point(636, 124);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(107, 38);
            this.btnExaminar.TabIndex = 8;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cambiar formato video";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbtnMp4
            // 
            this.rbtnMp4.AutoSize = true;
            this.rbtnMp4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtnMp4.BackgroundImage")));
            this.rbtnMp4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMp4.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbtnMp4.Location = new System.Drawing.Point(353, 208);
            this.rbtnMp4.Name = "rbtnMp4";
            this.rbtnMp4.Size = new System.Drawing.Size(62, 25);
            this.rbtnMp4.TabIndex = 10;
            this.rbtnMp4.TabStop = true;
            this.rbtnMp4.Text = "mp4";
            this.rbtnMp4.UseVisualStyleBackColor = true;
            // 
            // rbtnWmv
            // 
            this.rbtnWmv.AutoSize = true;
            this.rbtnWmv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtnWmv.BackgroundImage")));
            this.rbtnWmv.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnWmv.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbtnWmv.Location = new System.Drawing.Point(431, 208);
            this.rbtnWmv.Name = "rbtnWmv";
            this.rbtnWmv.Size = new System.Drawing.Size(65, 25);
            this.rbtnWmv.TabIndex = 11;
            this.rbtnWmv.TabStop = true;
            this.rbtnWmv.Text = "wmv";
            this.rbtnWmv.UseVisualStyleBackColor = true;
            // 
            // rbtnAvi
            // 
            this.rbtnAvi.AutoSize = true;
            this.rbtnAvi.BackgroundImage = global::tp_desktop.Properties.Resources.fondoConvertidor;
            this.rbtnAvi.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnAvi.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbtnAvi.Location = new System.Drawing.Point(353, 239);
            this.rbtnAvi.Name = "rbtnAvi";
            this.rbtnAvi.Size = new System.Drawing.Size(50, 25);
            this.rbtnAvi.TabIndex = 12;
            this.rbtnAvi.TabStop = true;
            this.rbtnAvi.Text = "avi";
            this.rbtnAvi.UseVisualStyleBackColor = true;
            // 
            // rbtnMov
            // 
            this.rbtnMov.AutoSize = true;
            this.rbtnMov.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbtnMov.BackgroundImage")));
            this.rbtnMov.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnMov.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbtnMov.Location = new System.Drawing.Point(431, 239);
            this.rbtnMov.Name = "rbtnMov";
            this.rbtnMov.Size = new System.Drawing.Size(62, 25);
            this.rbtnMov.TabIndex = 13;
            this.rbtnMov.TabStop = true;
            this.rbtnMov.Text = "mov";
            this.rbtnMov.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConvertir.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.btnConvertir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvertir.Location = new System.Drawing.Point(542, 215);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(126, 36);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tp_desktop.Properties.Resources.fondoConvertidor;
            this.ClientSize = new System.Drawing.Size(837, 590);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.rbtnMov);
            this.Controls.Add(this.rbtnAvi);
            this.Controls.Add(this.rbtnWmv);
            this.Controls.Add(this.rbtnMp4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExtraerImagen);
            this.Controls.Add(this.btnCambiarResolucion);
            this.Controls.Add(this.btnRemoverAudio);
            this.Controls.Add(this.btnExtraerAudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "Form2";
            this.Text = "Editor de video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtraerAudio;
        private System.Windows.Forms.Button btnRemoverAudio;
        private System.Windows.Forms.Button btnCambiarResolucion;
        private System.Windows.Forms.Button btnExtraerImagen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnMp4;
        private System.Windows.Forms.RadioButton rbtnWmv;
        private System.Windows.Forms.RadioButton rbtnAvi;
        private System.Windows.Forms.RadioButton rbtnMov;
        private System.Windows.Forms.Button btnConvertir;
    }
}