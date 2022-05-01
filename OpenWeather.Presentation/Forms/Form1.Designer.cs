namespace OpenWeather.Presentation.Forms
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTem = new System.Windows.Forms.Label();
            this.labelViento = new System.Windows.Forms.Label();
            this.labelPresion = new System.Windows.Forms.Label();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.labelCondicion = new System.Windows.Forms.Label();
            this.CityTexBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelCiudad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLatitud = new System.Windows.Forms.Label();
            this.labelLongitud = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelDt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(80, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(464, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Condicion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(464, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detalles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(262, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Velocidad del Viento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(191, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ciudad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(262, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Presión:";
            // 
            // labelTem
            // 
            this.labelTem.AutoSize = true;
            this.labelTem.BackColor = System.Drawing.Color.Transparent;
            this.labelTem.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTem.ForeColor = System.Drawing.Color.Snow;
            this.labelTem.Location = new System.Drawing.Point(132, 61);
            this.labelTem.Name = "labelTem";
            this.labelTem.Size = new System.Drawing.Size(88, 50);
            this.labelTem.TabIndex = 13;
            this.labelTem.Text = "N/A";
            // 
            // labelViento
            // 
            this.labelViento.AutoSize = true;
            this.labelViento.BackColor = System.Drawing.Color.Transparent;
            this.labelViento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelViento.Location = new System.Drawing.Point(382, 71);
            this.labelViento.Name = "labelViento";
            this.labelViento.Size = new System.Drawing.Size(29, 15);
            this.labelViento.TabIndex = 14;
            this.labelViento.Text = "N/A";
            // 
            // labelPresion
            // 
            this.labelPresion.AutoSize = true;
            this.labelPresion.BackColor = System.Drawing.Color.Transparent;
            this.labelPresion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPresion.Location = new System.Drawing.Point(314, 108);
            this.labelPresion.Name = "labelPresion";
            this.labelPresion.Size = new System.Drawing.Size(29, 15);
            this.labelPresion.TabIndex = 15;
            this.labelPresion.Text = "N/A";
            // 
            // labelDetalles
            // 
            this.labelDetalles.AutoSize = true;
            this.labelDetalles.BackColor = System.Drawing.Color.Transparent;
            this.labelDetalles.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDetalles.Location = new System.Drawing.Point(532, 108);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(29, 15);
            this.labelDetalles.TabIndex = 16;
            this.labelDetalles.Text = "N/A";
            // 
            // labelCondicion
            // 
            this.labelCondicion.AutoSize = true;
            this.labelCondicion.BackColor = System.Drawing.Color.Transparent;
            this.labelCondicion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCondicion.Location = new System.Drawing.Point(532, 71);
            this.labelCondicion.Name = "labelCondicion";
            this.labelCondicion.Size = new System.Drawing.Size(29, 15);
            this.labelCondicion.TabIndex = 17;
            this.labelCondicion.Text = "N/A";
            // 
            // CityTexBox
            // 
            this.CityTexBox.Location = new System.Drawing.Point(262, 12);
            this.CityTexBox.Name = "CityTexBox";
            this.CityTexBox.Size = new System.Drawing.Size(142, 23);
            this.CityTexBox.TabIndex = 18;
            this.CityTexBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityTexBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.BackColor = System.Drawing.Color.Transparent;
            this.labelCiudad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCiudad.Location = new System.Drawing.Point(84, 125);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(43, 15);
            this.labelCiudad.TabIndex = 19;
            this.labelCiudad.Text = "ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(262, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Latitud:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(464, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Longitud:";
            // 
            // labelLatitud
            // 
            this.labelLatitud.AutoSize = true;
            this.labelLatitud.BackColor = System.Drawing.Color.Transparent;
            this.labelLatitud.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelLatitud.Location = new System.Drawing.Point(315, 145);
            this.labelLatitud.Name = "labelLatitud";
            this.labelLatitud.Size = new System.Drawing.Size(29, 15);
            this.labelLatitud.TabIndex = 23;
            this.labelLatitud.Text = "N/A";
            // 
            // labelLongitud
            // 
            this.labelLongitud.AutoSize = true;
            this.labelLongitud.BackColor = System.Drawing.Color.Transparent;
            this.labelLongitud.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelLongitud.Location = new System.Drawing.Point(528, 145);
            this.labelLongitud.Name = "labelLongitud";
            this.labelLongitud.Size = new System.Drawing.Size(29, 15);
            this.labelLongitud.TabIndex = 24;
            this.labelLongitud.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(262, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "dt:";
            // 
            // labelDt
            // 
            this.labelDt.AutoSize = true;
            this.labelDt.BackColor = System.Drawing.Color.Transparent;
            this.labelDt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelDt.Location = new System.Drawing.Point(314, 181);
            this.labelDt.Name = "labelDt";
            this.labelDt.Size = new System.Drawing.Size(29, 15);
            this.labelDt.TabIndex = 26;
            this.labelDt.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OpenWeather.Presentation.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 261);
            this.Controls.Add(this.labelDt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelLongitud);
            this.Controls.Add(this.labelLatitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.CityTexBox);
            this.Controls.Add(this.labelCondicion);
            this.Controls.Add(this.labelDetalles);
            this.Controls.Add(this.labelPresion);
            this.Controls.Add(this.labelViento);
            this.Controls.Add(this.labelTem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::OpenWeather.Presentation.Properties.Resources.API;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTem;
        private System.Windows.Forms.Label labelViento;
        private System.Windows.Forms.Label labelPresion;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.Label labelCondicion;
        private System.Windows.Forms.TextBox CityTexBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelLongitud;
        private System.Windows.Forms.Label labelLatitud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDt;
        private System.Windows.Forms.Label label10;
    }
}
