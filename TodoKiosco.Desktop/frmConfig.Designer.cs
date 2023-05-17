
namespace TodoKiosco.Desktop
{
    partial class frmConfig
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTelefonica = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTelefonicaNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTelefonica = new System.Windows.Forms.DataGridView();
            this.tabPageRol = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxRolesNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageTelefonica.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonica)).BeginInit();
            this.tabPageRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTelefonica);
            this.tabControl1.Controls.Add(this.tabPageRol);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTelefonica
            // 
            this.tabPageTelefonica.Controls.Add(this.panel2);
            this.tabPageTelefonica.Controls.Add(this.panel1);
            this.tabPageTelefonica.Location = new System.Drawing.Point(4, 22);
            this.tabPageTelefonica.Name = "tabPageTelefonica";
            this.tabPageTelefonica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTelefonica.Size = new System.Drawing.Size(782, 262);
            this.tabPageTelefonica.TabIndex = 0;
            this.tabPageTelefonica.Text = "Telefonicas";
            this.tabPageTelefonica.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxTelefonicaNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(474, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 256);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTelefonicaNombre
            // 
            this.textBoxTelefonicaNombre.Location = new System.Drawing.Point(15, 42);
            this.textBoxTelefonicaNombre.Name = "textBoxTelefonicaNombre";
            this.textBoxTelefonicaNombre.Size = new System.Drawing.Size(250, 20);
            this.textBoxTelefonicaNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewTelefonica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 256);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewTelefonica
            // 
            this.dataGridViewTelefonica.AllowUserToAddRows = false;
            this.dataGridViewTelefonica.AllowUserToDeleteRows = false;
            this.dataGridViewTelefonica.AllowUserToOrderColumns = true;
            this.dataGridViewTelefonica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTelefonica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTelefonica.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTelefonica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefonica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dataGridViewTelefonica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTelefonica.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTelefonica.Name = "dataGridViewTelefonica";
            this.dataGridViewTelefonica.ReadOnly = true;
            this.dataGridViewTelefonica.Size = new System.Drawing.Size(414, 256);
            this.dataGridViewTelefonica.TabIndex = 0;
            this.dataGridViewTelefonica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTelefonica_CellContentClick);
            // 
            // tabPageRol
            // 
            this.tabPageRol.Controls.Add(this.panel4);
            this.tabPageRol.Controls.Add(this.panel3);
            this.tabPageRol.Location = new System.Drawing.Point(4, 22);
            this.tabPageRol.Name = "tabPageRol";
            this.tabPageRol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRol.Size = new System.Drawing.Size(633, 262);
            this.tabPageRol.TabIndex = 1;
            this.tabPageRol.Text = "Roles";
            this.tabPageRol.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(633, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.textBoxRolesNombre);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(325, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 256);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxRolesNombre
            // 
            this.textBoxRolesNombre.Location = new System.Drawing.Point(15, 42);
            this.textBoxRolesNombre.Name = "textBoxRolesNombre";
            this.textBoxRolesNombre.Size = new System.Drawing.Size(250, 20);
            this.textBoxRolesNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridViewRoles);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 256);
            this.panel4.TabIndex = 3;
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoles.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.Size = new System.Drawing.Size(316, 256);
            this.dataGridViewRoles.TabIndex = 0;
            // 
            // Editar
            // 
            this.Editar.Frozen = true;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::TodoKiosco.Desktop.Properties.Resources.edit;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 40;
            // 
            // Eliminar
            // 
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::TodoKiosco.Desktop.Properties.Resources.delete;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 49;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 310);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTelefonica.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonica)).EndInit();
            this.tabPageRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTelefonica;
        private System.Windows.Forms.TabPage tabPageRol;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTelefonicaNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewTelefonica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxRolesNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}