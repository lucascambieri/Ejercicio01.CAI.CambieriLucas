namespace Ejercicio01.CAI.CambieriLucas
{
    partial class Ejercicio01
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
            AceptarButton = new Button();
            CancelarButton = new Button();
            DniTextBox = new TextBox();
            NombreTextBox = new TextBox();
            ApellidoTextBox = new TextBox();
            DniLabel = new Label();
            NombreLabel = new Label();
            ApellidoLabel = new Label();
            FechaNacimientoDateTime = new DateTimePicker();
            FechaLabel = new Label();
            SuspendLayout();
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(427, 136);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(100, 27);
            AceptarButton.TabIndex = 0;
            AceptarButton.Text = "ACEPTAR";
            AceptarButton.UseVisualStyleBackColor = true;
            AceptarButton.Click += AceptarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(568, 136);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(100, 28);
            CancelarButton.TabIndex = 1;
            CancelarButton.Text = "CANCELAR";
            CancelarButton.UseVisualStyleBackColor = true;
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(38, 64);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(100, 23);
            DniTextBox.TabIndex = 2;
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(185, 64);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(100, 23);
            NombreTextBox.TabIndex = 3;
            // 
            // ApellidoTextBox
            // 
            ApellidoTextBox.Location = new Point(328, 64);
            ApellidoTextBox.Name = "ApellidoTextBox";
            ApellidoTextBox.Size = new Size(100, 23);
            ApellidoTextBox.TabIndex = 4;
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Location = new Point(38, 30);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(27, 15);
            DniLabel.TabIndex = 5;
            DniLabel.Text = "DNI";
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(185, 30);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(51, 15);
            NombreLabel.TabIndex = 6;
            NombreLabel.Text = "Nombre";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Location = new Point(328, 30);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(51, 15);
            ApellidoLabel.TabIndex = 7;
            ApellidoLabel.Text = "Apellido";
            // 
            // FechaNacimientoDateTime
            // 
            FechaNacimientoDateTime.Format = DateTimePickerFormat.Short;
            FechaNacimientoDateTime.Location = new Point(468, 64);
            FechaNacimientoDateTime.Name = "FechaNacimientoDateTime";
            FechaNacimientoDateTime.Size = new Size(200, 23);
            FechaNacimientoDateTime.TabIndex = 8;
            FechaNacimientoDateTime.Value = new DateTime(2023, 9, 25, 22, 40, 4, 0);
            FechaNacimientoDateTime.ValueChanged += FechaNacimientoDateTime_ValueChanged;
            // 
            // FechaLabel
            // 
            FechaLabel.AutoSize = true;
            FechaLabel.Location = new Point(468, 30);
            FechaLabel.Name = "FechaLabel";
            FechaLabel.Size = new Size(117, 15);
            FechaLabel.TabIndex = 9;
            FechaLabel.Text = "Fecha de nacimiento";
            // 
            // Ejercicio01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 209);
            Controls.Add(FechaLabel);
            Controls.Add(FechaNacimientoDateTime);
            Controls.Add(ApellidoLabel);
            Controls.Add(NombreLabel);
            Controls.Add(DniLabel);
            Controls.Add(ApellidoTextBox);
            Controls.Add(NombreTextBox);
            Controls.Add(DniTextBox);
            Controls.Add(CancelarButton);
            Controls.Add(AceptarButton);
            Name = "Ejercicio01";
            Text = "Ejercicio 01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AceptarButton;
        private Button CancelarButton;
        private TextBox DniTextBox;
        private TextBox NombreTextBox;
        private TextBox ApellidoTextBox;
        private Label DniLabel;
        private Label NombreLabel;
        private Label ApellidoLabel;
        private DateTimePicker FechaNacimientoDateTime;
        private Label FechaLabel;
    }
}