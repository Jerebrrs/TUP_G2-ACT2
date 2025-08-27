namespace Comisaria
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
            this.gbAdmComi = new System.Windows.Forms.GroupBox();
            this.btnListarInci = new System.Windows.Forms.Button();
            this.btnCrearComi = new System.Windows.Forms.Button();
            this.gbOperSobrAgente = new System.Windows.Forms.GroupBox();
            this.btnAsigGuardias = new System.Windows.Forms.Button();
            this.gbadmiGuardias = new System.Windows.Forms.GroupBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.domUpNroGuardia = new System.Windows.Forms.DomainUpDown();
            this.cbAgentes = new System.Windows.Forms.ComboBox();
            this.lbNroGuardia = new System.Windows.Forms.Label();
            this.lbDesde = new System.Windows.Forms.Label();
            this.doUpHInicio = new System.Windows.Forms.DomainUpDown();
            this.domUpHfin = new System.Windows.Forms.DomainUpDown();
            this.lbDuracion = new System.Windows.Forms.Label();
            this.doUpduacionMin = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPerNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbmotivo = new System.Windows.Forms.TextBox();
            this.btnRegIncide = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbAdmComi.SuspendLayout();
            this.gbOperSobrAgente.SuspendLayout();
            this.gbadmiGuardias.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdmComi
            // 
            this.gbAdmComi.Controls.Add(this.btnListarInci);
            this.gbAdmComi.Controls.Add(this.btnCrearComi);
            this.gbAdmComi.Location = new System.Drawing.Point(31, 3);
            this.gbAdmComi.Name = "gbAdmComi";
            this.gbAdmComi.Size = new System.Drawing.Size(502, 71);
            this.gbAdmComi.TabIndex = 1;
            this.gbAdmComi.TabStop = false;
            this.gbAdmComi.Text = "Administración Comisaria";
            // 
            // btnListarInci
            // 
            this.btnListarInci.Location = new System.Drawing.Point(391, 19);
            this.btnListarInci.Name = "btnListarInci";
            this.btnListarInci.Size = new System.Drawing.Size(80, 39);
            this.btnListarInci.TabIndex = 1;
            this.btnListarInci.Text = "Listar Incidentes";
            this.btnListarInci.UseVisualStyleBackColor = true;
            // 
            // btnCrearComi
            // 
            this.btnCrearComi.Location = new System.Drawing.Point(275, 19);
            this.btnCrearComi.Name = "btnCrearComi";
            this.btnCrearComi.Size = new System.Drawing.Size(80, 37);
            this.btnCrearComi.TabIndex = 0;
            this.btnCrearComi.Text = "Creación Comisaria";
            this.btnCrearComi.UseVisualStyleBackColor = true;
            this.btnCrearComi.Click += new System.EventHandler(this.btnCrearComi_Click);
            // 
            // gbOperSobrAgente
            // 
            this.gbOperSobrAgente.Controls.Add(this.groupBox1);
            this.gbOperSobrAgente.Controls.Add(this.cbAgentes);
            this.gbOperSobrAgente.Controls.Add(this.gbadmiGuardias);
            this.gbOperSobrAgente.Controls.Add(this.lbPlaca);
            this.gbOperSobrAgente.Location = new System.Drawing.Point(31, 80);
            this.gbOperSobrAgente.Name = "gbOperSobrAgente";
            this.gbOperSobrAgente.Size = new System.Drawing.Size(502, 409);
            this.gbOperSobrAgente.TabIndex = 2;
            this.gbOperSobrAgente.TabStop = false;
            this.gbOperSobrAgente.Text = "Operaciones sobre el agente";
            // 
            // btnAsigGuardias
            // 
            this.btnAsigGuardias.Location = new System.Drawing.Point(334, 42);
            this.btnAsigGuardias.Name = "btnAsigGuardias";
            this.btnAsigGuardias.Size = new System.Drawing.Size(89, 59);
            this.btnAsigGuardias.TabIndex = 0;
            this.btnAsigGuardias.Text = "Asignacion de Guardias";
            this.btnAsigGuardias.UseVisualStyleBackColor = true;
            this.btnAsigGuardias.Click += new System.EventHandler(this.btnAsigGuardias_Click);
            // 
            // gbadmiGuardias
            // 
            this.gbadmiGuardias.Controls.Add(this.doUpduacionMin);
            this.gbadmiGuardias.Controls.Add(this.lbDuracion);
            this.gbadmiGuardias.Controls.Add(this.domUpHfin);
            this.gbadmiGuardias.Controls.Add(this.doUpHInicio);
            this.gbadmiGuardias.Controls.Add(this.lbDesde);
            this.gbadmiGuardias.Controls.Add(this.lbNroGuardia);
            this.gbadmiGuardias.Controls.Add(this.domUpNroGuardia);
            this.gbadmiGuardias.Controls.Add(this.btnAsigGuardias);
            this.gbadmiGuardias.Location = new System.Drawing.Point(12, 61);
            this.gbadmiGuardias.Name = "gbadmiGuardias";
            this.gbadmiGuardias.Size = new System.Drawing.Size(459, 120);
            this.gbadmiGuardias.TabIndex = 1;
            this.gbadmiGuardias.TabStop = false;
            this.gbadmiGuardias.Text = "Administracion De Guardias";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(19, 21);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(71, 13);
            this.lbPlaca.TabIndex = 1;
            this.lbPlaca.Text = "Placa Agente";
            this.lbPlaca.Click += new System.EventHandler(this.lbPlaca_Click);
            // 
            // domUpNroGuardia
            // 
            this.domUpNroGuardia.Location = new System.Drawing.Point(93, 32);
            this.domUpNroGuardia.Name = "domUpNroGuardia";
            this.domUpNroGuardia.Size = new System.Drawing.Size(68, 20);
            this.domUpNroGuardia.TabIndex = 2;
            // 
            // cbAgentes
            // 
            this.cbAgentes.FormattingEnabled = true;
            this.cbAgentes.Location = new System.Drawing.Point(96, 21);
            this.cbAgentes.Name = "cbAgentes";
            this.cbAgentes.Size = new System.Drawing.Size(121, 21);
            this.cbAgentes.TabIndex = 3;
            this.cbAgentes.SelectedIndexChanged += new System.EventHandler(this.cbAgentes_SelectedIndexChanged);
            // 
            // lbNroGuardia
            // 
            this.lbNroGuardia.AutoSize = true;
            this.lbNroGuardia.Location = new System.Drawing.Point(7, 34);
            this.lbNroGuardia.Name = "lbNroGuardia";
            this.lbNroGuardia.Size = new System.Drawing.Size(67, 13);
            this.lbNroGuardia.TabIndex = 4;
            this.lbNroGuardia.Text = "Nro Guardia:";
            // 
            // lbDesde
            // 
            this.lbDesde.AutoSize = true;
            this.lbDesde.Location = new System.Drawing.Point(34, 65);
            this.lbDesde.Name = "lbDesde";
            this.lbDesde.Size = new System.Drawing.Size(44, 13);
            this.lbDesde.TabIndex = 5;
            this.lbDesde.Text = "Desde: ";
            this.lbDesde.Click += new System.EventHandler(this.lbDesde_Click);
            // 
            // doUpHInicio
            // 
            this.doUpHInicio.Location = new System.Drawing.Point(93, 63);
            this.doUpHInicio.Name = "doUpHInicio";
            this.doUpHInicio.Size = new System.Drawing.Size(49, 20);
            this.doUpHInicio.TabIndex = 6;
            // 
            // domUpHfin
            // 
            this.domUpHfin.Location = new System.Drawing.Point(160, 63);
            this.domUpHfin.Name = "domUpHfin";
            this.domUpHfin.Size = new System.Drawing.Size(45, 20);
            this.domUpHfin.TabIndex = 7;
            // 
            // lbDuracion
            // 
            this.lbDuracion.AutoSize = true;
            this.lbDuracion.Location = new System.Drawing.Point(6, 99);
            this.lbDuracion.Name = "lbDuracion";
            this.lbDuracion.Size = new System.Drawing.Size(81, 13);
            this.lbDuracion.TabIndex = 8;
            this.lbDuracion.Text = "Duracion En M:";
            // 
            // doUpduacionMin
            // 
            this.doUpduacionMin.Location = new System.Drawing.Point(93, 92);
            this.doUpduacionMin.Name = "doUpduacionMin";
            this.doUpduacionMin.Size = new System.Drawing.Size(68, 20);
            this.doUpduacionMin.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegIncide);
            this.groupBox1.Controls.Add(this.tbmotivo);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbPerNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion sobre el agente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Incidente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Persona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motivo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbPerNombre
            // 
            this.tbPerNombre.Location = new System.Drawing.Point(71, 81);
            this.tbPerNombre.Name = "tbPerNombre";
            this.tbPerNombre.Size = new System.Drawing.Size(100, 20);
            this.tbPerNombre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dni:";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(226, 84);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 6;
            // 
            // tbmotivo
            // 
            this.tbmotivo.Location = new System.Drawing.Point(71, 110);
            this.tbmotivo.Multiline = true;
            this.tbmotivo.Name = "tbmotivo";
            this.tbmotivo.Size = new System.Drawing.Size(255, 56);
            this.tbmotivo.TabIndex = 7;
            // 
            // btnRegIncide
            // 
            this.btnRegIncide.Location = new System.Drawing.Point(348, 124);
            this.btnRegIncide.Name = "btnRegIncide";
            this.btnRegIncide.Size = new System.Drawing.Size(94, 42);
            this.btnRegIncide.TabIndex = 8;
            this.btnRegIncide.Text = "Registrar Incidentes";
            this.btnRegIncide.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(217, 495);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 526);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbOperSobrAgente);
            this.Controls.Add(this.gbAdmComi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAdmComi.ResumeLayout(false);
            this.gbOperSobrAgente.ResumeLayout(false);
            this.gbOperSobrAgente.PerformLayout();
            this.gbadmiGuardias.ResumeLayout(false);
            this.gbadmiGuardias.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAdmComi;
        private System.Windows.Forms.Button btnListarInci;
        private System.Windows.Forms.Button btnCrearComi;
        private System.Windows.Forms.GroupBox gbOperSobrAgente;
        private System.Windows.Forms.Button btnAsigGuardias;
        private System.Windows.Forms.GroupBox gbadmiGuardias;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.DomainUpDown domUpNroGuardia;
        private System.Windows.Forms.ComboBox cbAgentes;
        private System.Windows.Forms.Label lbNroGuardia;
        private System.Windows.Forms.Label lbDesde;
        private System.Windows.Forms.DomainUpDown doUpduacionMin;
        private System.Windows.Forms.Label lbDuracion;
        private System.Windows.Forms.DomainUpDown domUpHfin;
        private System.Windows.Forms.DomainUpDown doUpHInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegIncide;
        private System.Windows.Forms.TextBox tbmotivo;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPerNombre;
        private System.Windows.Forms.Button btnCerrar;
    }
}

