namespace Segundo_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.labelDPI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonPrimerMayuscula = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.button_Borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(234, 48);
            this.textBoxDPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(112, 26);
            this.textBoxDPI.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(234, 126);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(112, 26);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(234, 208);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(112, 26);
            this.textBoxApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "DPI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // dateTimePickerFechaNac
            // 
            this.dateTimePickerFechaNac.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePickerFechaNac.Location = new System.Drawing.Point(40, 306);
            this.dateTimePickerFechaNac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerFechaNac.Name = "dateTimePickerFechaNac";
            this.dateTimePickerFechaNac.Size = new System.Drawing.Size(291, 26);
            this.dateTimePickerFechaNac.TabIndex = 6;
            this.dateTimePickerFechaNac.ValueChanged += new System.EventHandler(this.dateTimePickerFechaNac_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(36, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha De Nacimiento";
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonIngreso.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngreso.Location = new System.Drawing.Point(502, 48);
            this.buttonIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(231, 40);
            this.buttonIngreso.TabIndex = 8;
            this.buttonIngreso.Text = "Ingresar Persona";
            this.buttonIngreso.UseVisualStyleBackColor = false;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // labelDPI
            // 
            this.labelDPI.AutoSize = true;
            this.labelDPI.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDPI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDPI.Location = new System.Drawing.Point(505, 235);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(87, 20);
            this.labelDPI.TabIndex = 9;
            this.labelDPI.Text = "label5";
            this.labelDPI.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombre.Location = new System.Drawing.Point(505, 279);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 20);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "label6";
            this.labelNombre.Visible = false;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelApellido.Location = new System.Drawing.Point(505, 331);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(87, 20);
            this.labelApellido.TabIndex = 11;
            this.labelApellido.Text = "label7";
            this.labelApellido.Visible = false;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(505, 385);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(87, 20);
            this.labelFechaNacimiento.TabIndex = 12;
            this.labelFechaNacimiento.Text = "label8";
            this.labelFechaNacimiento.Visible = false;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonMostrar.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.Location = new System.Drawing.Point(502, 113);
            this.buttonMostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(231, 39);
            this.buttonMostrar.TabIndex = 13;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonPrimerMayuscula
            // 
            this.buttonPrimerMayuscula.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPrimerMayuscula.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrimerMayuscula.Location = new System.Drawing.Point(502, 176);
            this.buttonPrimerMayuscula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrimerMayuscula.Name = "buttonPrimerMayuscula";
            this.buttonPrimerMayuscula.Size = new System.Drawing.Size(231, 38);
            this.buttonPrimerMayuscula.TabIndex = 14;
            this.buttonPrimerMayuscula.Text = "Primera Mayuscula";
            this.buttonPrimerMayuscula.UseVisualStyleBackColor = false;
            this.buttonPrimerMayuscula.Click += new System.EventHandler(this.buttonPrimerMayuscula_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ROG Fonts", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(504, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Edad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEdad.Location = new System.Drawing.Point(505, 457);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(87, 20);
            this.labelEdad.TabIndex = 16;
            this.labelEdad.Text = "label9";
            this.labelEdad.Visible = false;
            this.labelEdad.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_Borrar
            // 
            this.button_Borrar.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Borrar.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Borrar.Location = new System.Drawing.Point(40, 472);
            this.button_Borrar.Name = "button_Borrar";
            this.button_Borrar.Size = new System.Drawing.Size(306, 50);
            this.button_Borrar.TabIndex = 17;
            this.button_Borrar.Text = "BORRAR";
            this.button_Borrar.UseVisualStyleBackColor = false;
            this.button_Borrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(850, 562);
            this.Controls.Add(this.button_Borrar);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonPrimerMayuscula);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDPI);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFechaNac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDPI);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Control Personas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonPrimerMayuscula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Button button_Borrar;
    }
}

