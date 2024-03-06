namespace examen_practico_ra2_su_nombr3
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
            lbl_Matricula=new Label();
            lbl_Nombre=new Label();
            lbl_Direccion=new Label();
            lbl_Telefono=new Label();
            lbl_Email=new Label();
            txt_Matricula=new TextBox();
            txt_Nombre=new TextBox();
            txt_Direccion=new TextBox();
            txt_Telefono=new TextBox();
            txt_Email=new TextBox();
            txt_Maestro_Titular=new TextBox();
            lbl_Maestro_Titular=new Label();
            btn_Agregar=new Button();
            btn_Eliminar=new Button();
            btn_Limpiar=new Button();
            btn_Salir=new Button();
            btn_Guardar=new Button();
            btn_Nuevo=new Button();
            dgv_informacion=new DataGridView();
            matricula=new DataGridViewTextBoxColumn();
            nombre=new DataGridViewTextBoxColumn();
            direccion=new DataGridViewTextBoxColumn();
            telefono=new DataGridViewTextBoxColumn();
            genero=new DataGridViewTextBoxColumn();
            email=new DataGridViewTextBoxColumn();
            curso=new DataGridViewTextBoxColumn();
            seccion=new DataGridViewTextBoxColumn();
            area_tecnica=new DataGridViewTextBoxColumn();
            maestro_titular=new DataGridViewTextBoxColumn();
            cbo_Curso=new ComboBox();
            cbo_Seccion=new ComboBox();
            cbo_Area_Tecnica=new ComboBox();
            cbo_Genero=new ComboBox();
            dlg_guardar=new SaveFileDialog();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_informacion).BeginInit();
            SuspendLayout();
            // 
            // lbl_Matricula
            // 
            lbl_Matricula.AutoSize=true;
            lbl_Matricula.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Matricula.Location=new Point(81, 22);
            lbl_Matricula.Name="lbl_Matricula";
            lbl_Matricula.Size=new Size(75, 19);
            lbl_Matricula.TabIndex=0;
            lbl_Matricula.Text="Matricula";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize=true;
            lbl_Nombre.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location=new Point(81, 62);
            lbl_Nombre.Name="lbl_Nombre";
            lbl_Nombre.Size=new Size(63, 19);
            lbl_Nombre.TabIndex=1;
            lbl_Nombre.Text="Nombre";
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize=true;
            lbl_Direccion.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Direccion.Location=new Point(81, 107);
            lbl_Direccion.Name="lbl_Direccion";
            lbl_Direccion.Size=new Size(73, 19);
            lbl_Direccion.TabIndex=2;
            lbl_Direccion.Text="Direccion";
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize=true;
            lbl_Telefono.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Telefono.Location=new Point(81, 147);
            lbl_Telefono.Name="lbl_Telefono";
            lbl_Telefono.Size=new Size(67, 19);
            lbl_Telefono.TabIndex=3;
            lbl_Telefono.Text="Telefono";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize=true;
            lbl_Email.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.Location=new Point(81, 195);
            lbl_Email.Name="lbl_Email";
            lbl_Email.Size=new Size(47, 19);
            lbl_Email.TabIndex=5;
            lbl_Email.Text="Email";
            // 
            // txt_Matricula
            // 
            txt_Matricula.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Matricula.Location=new Point(186, 19);
            txt_Matricula.Name="txt_Matricula";
            txt_Matricula.Size=new Size(100, 26);
            txt_Matricula.TabIndex=9;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Nombre.Location=new Point(186, 62);
            txt_Nombre.Name="txt_Nombre";
            txt_Nombre.Size=new Size(100, 26);
            txt_Nombre.TabIndex=10;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Direccion.Location=new Point(186, 99);
            txt_Direccion.Name="txt_Direccion";
            txt_Direccion.Size=new Size(143, 26);
            txt_Direccion.TabIndex=11;
            // 
            // txt_Telefono
            // 
            txt_Telefono.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Telefono.Location=new Point(186, 147);
            txt_Telefono.Name="txt_Telefono";
            txt_Telefono.Size=new Size(100, 26);
            txt_Telefono.TabIndex=12;
            // 
            // txt_Email
            // 
            txt_Email.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Email.Location=new Point(186, 195);
            txt_Email.Name="txt_Email";
            txt_Email.Size=new Size(100, 26);
            txt_Email.TabIndex=14;
            // 
            // txt_Maestro_Titular
            // 
            txt_Maestro_Titular.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Maestro_Titular.Location=new Point(187, 243);
            txt_Maestro_Titular.Name="txt_Maestro_Titular";
            txt_Maestro_Titular.Size=new Size(100, 26);
            txt_Maestro_Titular.TabIndex=19;
            // 
            // lbl_Maestro_Titular
            // 
            lbl_Maestro_Titular.AutoSize=true;
            lbl_Maestro_Titular.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Maestro_Titular.Location=new Point(61, 250);
            lbl_Maestro_Titular.Name="lbl_Maestro_Titular";
            lbl_Maestro_Titular.Size=new Size(120, 19);
            lbl_Maestro_Titular.TabIndex=18;
            lbl_Maestro_Titular.Text="Maestro_Titular";
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor=SystemColors.InactiveCaption;
            btn_Agregar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.Location=new Point(356, 83);
            btn_Agregar.Name="btn_Agregar";
            btn_Agregar.Size=new Size(75, 31);
            btn_Agregar.TabIndex=20;
            btn_Agregar.Text="Agregar";
            btn_Agregar.UseVisualStyleBackColor=false;
            btn_Agregar.Click+=btn_Agregar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor=SystemColors.InactiveCaption;
            btn_Eliminar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.Location=new Point(356, 130);
            btn_Eliminar.Name="btn_Eliminar";
            btn_Eliminar.Size=new Size(75, 31);
            btn_Eliminar.TabIndex=21;
            btn_Eliminar.Text="Eliminar";
            btn_Eliminar.UseVisualStyleBackColor=false;
            btn_Eliminar.Click+=btn_Eliminar_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=SystemColors.InactiveCaption;
            btn_Limpiar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(356, 168);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(75, 31);
            btn_Limpiar.TabIndex=22;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=SystemColors.InactiveCaption;
            btn_Salir.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(356, 205);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(75, 31);
            btn_Salir.TabIndex=23;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor=SystemColors.InactiveCaption;
            btn_Guardar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Guardar.Location=new Point(356, 250);
            btn_Guardar.Name="btn_Guardar";
            btn_Guardar.Size=new Size(75, 31);
            btn_Guardar.TabIndex=24;
            btn_Guardar.Text="Guardar";
            btn_Guardar.UseVisualStyleBackColor=false;
            btn_Guardar.Click+=btn_Guardar_Click;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.BackColor=SystemColors.InactiveCaption;
            btn_Nuevo.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Nuevo.Location=new Point(356, 46);
            btn_Nuevo.Name="btn_Nuevo";
            btn_Nuevo.Size=new Size(75, 31);
            btn_Nuevo.TabIndex=25;
            btn_Nuevo.Text="Nuevo";
            btn_Nuevo.UseVisualStyleBackColor=false;
            btn_Nuevo.Click+=btn_Nuevo_Click;
            // 
            // dgv_informacion
            // 
            dgv_informacion.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_informacion.Columns.AddRange(new DataGridViewColumn[] { matricula, nombre, direccion, telefono, genero, email, curso, seccion, area_tecnica, maestro_titular });
            dgv_informacion.Location=new Point(14, 365);
            dgv_informacion.Name="dgv_informacion";
            dgv_informacion.RowTemplate.Height=25;
            dgv_informacion.Size=new Size(893, 150);
            dgv_informacion.TabIndex=26;
            // 
            // matricula
            // 
            matricula.HeaderText="Matricula";
            matricula.Name="matricula";
            // 
            // nombre
            // 
            nombre.HeaderText="Nombre";
            nombre.Name="nombre";
            // 
            // direccion
            // 
            direccion.HeaderText="Direccion";
            direccion.Name="direccion";
            direccion.Width=150;
            // 
            // telefono
            // 
            telefono.HeaderText="Telefono";
            telefono.Name="telefono";
            // 
            // genero
            // 
            genero.HeaderText="Genero";
            genero.Name="genero";
            // 
            // email
            // 
            email.HeaderText="Email";
            email.Name="email";
            // 
            // curso
            // 
            curso.HeaderText="Curso";
            curso.Name="curso";
            // 
            // seccion
            // 
            seccion.HeaderText="Seccion";
            seccion.Name="seccion";
            // 
            // area_tecnica
            // 
            area_tecnica.HeaderText="Area_Tecnica";
            area_tecnica.Name="area_tecnica";
            // 
            // maestro_titular
            // 
            maestro_titular.HeaderText="Maestro_Titular";
            maestro_titular.Name="maestro_titular";
            // 
            // cbo_Curso
            // 
            cbo_Curso.BackColor=Color.DarkSalmon;
            cbo_Curso.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbo_Curso.FormattingEnabled=true;
            cbo_Curso.Items.AddRange(new object[] { "3", "4", "5" });
            cbo_Curso.Location=new Point(764, 134);
            cbo_Curso.Name="cbo_Curso";
            cbo_Curso.Size=new Size(121, 27);
            cbo_Curso.TabIndex=27;
            // 
            // cbo_Seccion
            // 
            cbo_Seccion.BackColor=Color.DarkSalmon;
            cbo_Seccion.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbo_Seccion.FormattingEnabled=true;
            cbo_Seccion.Items.AddRange(new object[] { "D1", "D2", "D3" });
            cbo_Seccion.Location=new Point(626, 222);
            cbo_Seccion.Name="cbo_Seccion";
            cbo_Seccion.Size=new Size(121, 27);
            cbo_Seccion.TabIndex=28;
            // 
            // cbo_Area_Tecnica
            // 
            cbo_Area_Tecnica.BackColor=Color.DarkSalmon;
            cbo_Area_Tecnica.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbo_Area_Tecnica.FormattingEnabled=true;
            cbo_Area_Tecnica.Items.AddRange(new object[] { "Informatica", "Enfermeria", "Contabilidad" });
            cbo_Area_Tecnica.Location=new Point(626, 104);
            cbo_Area_Tecnica.Name="cbo_Area_Tecnica";
            cbo_Area_Tecnica.Size=new Size(121, 27);
            cbo_Area_Tecnica.TabIndex=29;
            // 
            // cbo_Genero
            // 
            cbo_Genero.BackColor=Color.DarkSalmon;
            cbo_Genero.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbo_Genero.FormattingEnabled=true;
            cbo_Genero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbo_Genero.Location=new Point(483, 133);
            cbo_Genero.Name="cbo_Genero";
            cbo_Genero.Size=new Size(121, 27);
            cbo_Genero.TabIndex=30;
          
            // 
            // dlg_guardar
            // 
    
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(637, 82);
            label1.Name="label1";
            label1.Size=new Size(101, 19);
            label1.TabIndex=31;
            label1.Text="Area_Tecnica";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location=new Point(508, 111);
            label2.Name="label2";
            label2.Size=new Size(59, 19);
            label2.TabIndex=32;
            label2.Text="Genero";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location=new Point(650, 200);
            label3.Name="label3";
            label3.Size=new Size(60, 19);
            label3.TabIndex=33;
            label3.Text="Seccion";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location=new Point(793, 112);
            label4.Name="label4";
            label4.Size=new Size(49, 19);
            label4.TabIndex=34;
            label4.Text="Curso";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(939, 482);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbo_Genero);
            Controls.Add(cbo_Area_Tecnica);
            Controls.Add(cbo_Seccion);
            Controls.Add(cbo_Curso);
            Controls.Add(dgv_informacion);
            Controls.Add(btn_Nuevo);
            Controls.Add(btn_Guardar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Agregar);
            Controls.Add(txt_Maestro_Titular);
            Controls.Add(lbl_Maestro_Titular);
            Controls.Add(txt_Email);
            Controls.Add(txt_Telefono);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Matricula);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Telefono);
            Controls.Add(lbl_Direccion);
            Controls.Add(lbl_Nombre);
            Controls.Add(lbl_Matricula);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_informacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Matricula;
        private Label lbl_Nombre;
        private Label lbl_Direccion;
        private Label lbl_Telefono;
        private Label lbl_Email;
        private Label lbl_Seccion;
        private TextBox txt_Matricula;
        private TextBox txt_Nombre;
        private TextBox txt_Direccion;
        private TextBox txt_Telefono;
        private TextBox txt_Email;
        private TextBox txt_Seccion;
        private TextBox txt_Maestro_Titular;
        private Label lbl_Maestro_Titular;
        private Button btn_Agregar;
        private Button btn_Eliminar;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Button btn_Guardar;
        private Button btn_Nuevo;
        private DataGridView dgv_informacion;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn genero;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn curso;
        private DataGridViewTextBoxColumn seccion;
        private DataGridViewTextBoxColumn area_tecnica;
        private DataGridViewTextBoxColumn maestro_titular;
        private ComboBox cbo_Curso;
        private ComboBox cbo_Seccion;
        private ComboBox cbo_Area_Tecnica;
        private ComboBox cbo_Genero;
        private SaveFileDialog dlg_guardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}