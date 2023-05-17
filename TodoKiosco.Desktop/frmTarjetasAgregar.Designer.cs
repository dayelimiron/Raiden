
namespace TodoKiosco.Desktop
{
    partial class frmTarjetasAgregar
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBoxPrecio = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTeefonica = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxCosto = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxPrecio
            // 
            this.maskedTextBoxPrecio.Location = new System.Drawing.Point(104, 131);
            this.maskedTextBoxPrecio.Mask = "9.99";
            this.maskedTextBoxPrecio.Name = "maskedTextBoxPrecio";
            this.maskedTextBoxPrecio.Size = new System.Drawing.Size(157, 20);
            this.maskedTextBoxPrecio.TabIndex = 34;
            // 
            // comboBoxTeefonica
            // 
            this.comboBoxTeefonica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeefonica.FormattingEnabled = true;
            this.comboBoxTeefonica.Location = new System.Drawing.Point(104, 184);
            this.comboBoxTeefonica.Name = "comboBoxTeefonica";
            this.comboBoxTeefonica.Size = new System.Drawing.Size(157, 21);
            this.comboBoxTeefonica.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 37);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nueva tarjeta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Telefonica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Precio";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(102, 78);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(159, 20);
            this.textBoxId.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(102, 104);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(159, 20);
            this.textBoxNombre.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Costo";
            // 
            // maskedTextBoxCosto
            // 
            this.maskedTextBoxCosto.Location = new System.Drawing.Point(104, 158);
            this.maskedTextBoxCosto.Mask = "9.99";
            this.maskedTextBoxCosto.Name = "maskedTextBoxCosto";
            this.maskedTextBoxCosto.Size = new System.Drawing.Size(157, 20);
            this.maskedTextBoxCosto.TabIndex = 36;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTarjetasAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 291);
            this.Controls.Add(this.maskedTextBoxCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxPrecio);
            this.Controls.Add(this.comboBoxTeefonica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmTarjetasAgregar";
            this.Text = "frmTarjetasAgregar";
            this.Load += new System.EventHandler(this.frmTarjetasAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxTeefonica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCosto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}