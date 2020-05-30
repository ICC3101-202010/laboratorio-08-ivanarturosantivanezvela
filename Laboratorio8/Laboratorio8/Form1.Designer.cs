namespace Laboratorio8
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
            this.Panelinicio = new System.Windows.Forms.Panel();
            this.Panelcine = new System.Windows.Forms.Panel();
            this.Crearcinebtn = new System.Windows.Forms.Button();
            this.Numerodesalastxt = new System.Windows.Forms.TextBox();
            this.Horariocierretxt = new System.Windows.Forms.TextBox();
            this.Horarioiniciotxt = new System.Windows.Forms.TextBox();
            this.Identificadortxt = new System.Windows.Forms.TextBox();
            this.Nombredueñotxt = new System.Windows.Forms.TextBox();
            this.Numerodesalaslabel = new System.Windows.Forms.Label();
            this.Horariocierrecinelabel = new System.Windows.Forms.Label();
            this.Horarioiniciocinelabel = new System.Windows.Forms.Label();
            this.Identificadorlabelcine = new System.Windows.Forms.Label();
            this.Nombreduenolabel = new System.Windows.Forms.Label();
            this.Paneldeopciones = new System.Windows.Forms.Panel();
            this.Enviaropcionbtn = new System.Windows.Forms.Button();
            this.Labelcomboxopciones = new System.Windows.Forms.Label();
            this.Comboxopciones = new System.Windows.Forms.ComboBox();
            this.Agregarlocalbtn = new System.Windows.Forms.Button();
            this.Revisarlocalbtn = new System.Windows.Forms.Button();
            this.Verlocalesexistentesbtn = new System.Windows.Forms.Button();
            this.Panellocalrecreacional = new System.Windows.Forms.Panel();
            this.Horariocierrerecreacionaltxt = new System.Windows.Forms.TextBox();
            this.Horarioiniciorecreacionaltxt = new System.Windows.Forms.TextBox();
            this.Identificadorrecreacionaltxt = new System.Windows.Forms.TextBox();
            this.Nombreduenolocalrecreacionaltxt = new System.Windows.Forms.TextBox();
            this.Horariocierrerecreacional = new System.Windows.Forms.Label();
            this.Horarioiniciorecreacionallabel = new System.Windows.Forms.Label();
            this.Identificadorrecreacionallabel = new System.Windows.Forms.Label();
            this.Recreacionalnombreduenolabel = new System.Windows.Forms.Label();
            this.Crearlocalrecreacionalbtn = new System.Windows.Forms.Button();
            this.Panelinicio.SuspendLayout();
            this.Panelcine.SuspendLayout();
            this.Paneldeopciones.SuspendLayout();
            this.Panellocalrecreacional.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panelinicio
            // 
            this.Panelinicio.Controls.Add(this.Panelcine);
            this.Panelinicio.Controls.Add(this.Paneldeopciones);
            this.Panelinicio.Controls.Add(this.Agregarlocalbtn);
            this.Panelinicio.Controls.Add(this.Revisarlocalbtn);
            this.Panelinicio.Controls.Add(this.Verlocalesexistentesbtn);
            this.Panelinicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelinicio.Location = new System.Drawing.Point(0, 0);
            this.Panelinicio.Name = "Panelinicio";
            this.Panelinicio.Size = new System.Drawing.Size(800, 450);
            this.Panelinicio.TabIndex = 0;
            // 
            // Panelcine
            // 
            this.Panelcine.BackColor = System.Drawing.Color.Red;
            this.Panelcine.Controls.Add(this.Panellocalrecreacional);
            this.Panelcine.Controls.Add(this.Crearcinebtn);
            this.Panelcine.Controls.Add(this.Numerodesalastxt);
            this.Panelcine.Controls.Add(this.Horariocierretxt);
            this.Panelcine.Controls.Add(this.Horarioiniciotxt);
            this.Panelcine.Controls.Add(this.Identificadortxt);
            this.Panelcine.Controls.Add(this.Nombredueñotxt);
            this.Panelcine.Controls.Add(this.Numerodesalaslabel);
            this.Panelcine.Controls.Add(this.Horariocierrecinelabel);
            this.Panelcine.Controls.Add(this.Horarioiniciocinelabel);
            this.Panelcine.Controls.Add(this.Identificadorlabelcine);
            this.Panelcine.Controls.Add(this.Nombreduenolabel);
            this.Panelcine.Location = new System.Drawing.Point(0, 0);
            this.Panelcine.Name = "Panelcine";
            this.Panelcine.Size = new System.Drawing.Size(800, 450);
            this.Panelcine.TabIndex = 3;
            this.Panelcine.Visible = false;
            // 
            // Crearcinebtn
            // 
            this.Crearcinebtn.Location = new System.Drawing.Point(329, 224);
            this.Crearcinebtn.Name = "Crearcinebtn";
            this.Crearcinebtn.Size = new System.Drawing.Size(159, 37);
            this.Crearcinebtn.TabIndex = 10;
            this.Crearcinebtn.Text = "Crear Cine";
            this.Crearcinebtn.UseVisualStyleBackColor = true;
            this.Crearcinebtn.Click += new System.EventHandler(this.Crearcinebtn_Click);
            // 
            // Numerodesalastxt
            // 
            this.Numerodesalastxt.Location = new System.Drawing.Point(108, 132);
            this.Numerodesalastxt.Name = "Numerodesalastxt";
            this.Numerodesalastxt.Size = new System.Drawing.Size(299, 20);
            this.Numerodesalastxt.TabIndex = 9;
            // 
            // Horariocierretxt
            // 
            this.Horariocierretxt.Location = new System.Drawing.Point(108, 101);
            this.Horariocierretxt.Name = "Horariocierretxt";
            this.Horariocierretxt.Size = new System.Drawing.Size(299, 20);
            this.Horariocierretxt.TabIndex = 8;
            // 
            // Horarioiniciotxt
            // 
            this.Horarioiniciotxt.Location = new System.Drawing.Point(108, 71);
            this.Horarioiniciotxt.Name = "Horarioiniciotxt";
            this.Horarioiniciotxt.Size = new System.Drawing.Size(299, 20);
            this.Horarioiniciotxt.TabIndex = 7;
            // 
            // Identificadortxt
            // 
            this.Identificadortxt.Location = new System.Drawing.Point(108, 45);
            this.Identificadortxt.Name = "Identificadortxt";
            this.Identificadortxt.Size = new System.Drawing.Size(299, 20);
            this.Identificadortxt.TabIndex = 6;
            // 
            // Nombredueñotxt
            // 
            this.Nombredueñotxt.Location = new System.Drawing.Point(108, 19);
            this.Nombredueñotxt.Name = "Nombredueñotxt";
            this.Nombredueñotxt.Size = new System.Drawing.Size(299, 20);
            this.Nombredueñotxt.TabIndex = 5;
            // 
            // Numerodesalaslabel
            // 
            this.Numerodesalaslabel.AutoSize = true;
            this.Numerodesalaslabel.Location = new System.Drawing.Point(11, 132);
            this.Numerodesalaslabel.Name = "Numerodesalaslabel";
            this.Numerodesalaslabel.Size = new System.Drawing.Size(86, 13);
            this.Numerodesalaslabel.TabIndex = 4;
            this.Numerodesalaslabel.Text = "Numero de salas";
            // 
            // Horariocierrecinelabel
            // 
            this.Horariocierrecinelabel.AutoSize = true;
            this.Horariocierrecinelabel.Location = new System.Drawing.Point(11, 104);
            this.Horariocierrecinelabel.Name = "Horariocierrecinelabel";
            this.Horariocierrecinelabel.Size = new System.Drawing.Size(99, 13);
            this.Horariocierrecinelabel.TabIndex = 3;
            this.Horariocierrecinelabel.Text = "Horacio cierre cine:";
            // 
            // Horarioiniciocinelabel
            // 
            this.Horarioiniciocinelabel.AutoSize = true;
            this.Horarioiniciocinelabel.Location = new System.Drawing.Point(11, 74);
            this.Horarioiniciocinelabel.Name = "Horarioiniciocinelabel";
            this.Horarioiniciocinelabel.Size = new System.Drawing.Size(97, 13);
            this.Horarioiniciocinelabel.TabIndex = 2;
            this.Horarioiniciocinelabel.Text = "Horario inicio cine: ";
            // 
            // Identificadorlabelcine
            // 
            this.Identificadorlabelcine.AutoSize = true;
            this.Identificadorlabelcine.Location = new System.Drawing.Point(11, 48);
            this.Identificadorlabelcine.Name = "Identificadorlabelcine";
            this.Identificadorlabelcine.Size = new System.Drawing.Size(71, 13);
            this.Identificadorlabelcine.TabIndex = 1;
            this.Identificadorlabelcine.Text = "Identificador: ";
            // 
            // Nombreduenolabel
            // 
            this.Nombreduenolabel.AutoSize = true;
            this.Nombreduenolabel.Location = new System.Drawing.Point(11, 22);
            this.Nombreduenolabel.Name = "Nombreduenolabel";
            this.Nombreduenolabel.Size = new System.Drawing.Size(80, 13);
            this.Nombreduenolabel.TabIndex = 0;
            this.Nombreduenolabel.Text = "Nombre dueño:";
            // 
            // Paneldeopciones
            // 
            this.Paneldeopciones.BackColor = System.Drawing.Color.DarkGray;
            this.Paneldeopciones.Controls.Add(this.Enviaropcionbtn);
            this.Paneldeopciones.Controls.Add(this.Labelcomboxopciones);
            this.Paneldeopciones.Controls.Add(this.Comboxopciones);
            this.Paneldeopciones.Location = new System.Drawing.Point(114, 188);
            this.Paneldeopciones.Name = "Paneldeopciones";
            this.Paneldeopciones.Size = new System.Drawing.Size(550, 96);
            this.Paneldeopciones.TabIndex = 10;
            this.Paneldeopciones.Visible = false;
            // 
            // Enviaropcionbtn
            // 
            this.Enviaropcionbtn.Location = new System.Drawing.Point(229, 50);
            this.Enviaropcionbtn.Name = "Enviaropcionbtn";
            this.Enviaropcionbtn.Size = new System.Drawing.Size(114, 23);
            this.Enviaropcionbtn.TabIndex = 6;
            this.Enviaropcionbtn.Text = "Enviar ";
            this.Enviaropcionbtn.UseVisualStyleBackColor = true;
            this.Enviaropcionbtn.Click += new System.EventHandler(this.Enviaropcionbtn_Click);
            // 
            // Labelcomboxopciones
            // 
            this.Labelcomboxopciones.AutoSize = true;
            this.Labelcomboxopciones.Location = new System.Drawing.Point(94, 9);
            this.Labelcomboxopciones.Name = "Labelcomboxopciones";
            this.Labelcomboxopciones.Size = new System.Drawing.Size(172, 13);
            this.Labelcomboxopciones.TabIndex = 5;
            this.Labelcomboxopciones.Text = "Elija una de las opciones a agregar";
            // 
            // Comboxopciones
            // 
            this.Comboxopciones.FormattingEnabled = true;
            this.Comboxopciones.Items.AddRange(new object[] {
            "Cine",
            "Tienda",
            "Restaurant",
            "Recreacional"});
            this.Comboxopciones.Location = new System.Drawing.Point(283, 9);
            this.Comboxopciones.Name = "Comboxopciones";
            this.Comboxopciones.Size = new System.Drawing.Size(170, 21);
            this.Comboxopciones.TabIndex = 4;
            this.Comboxopciones.Text = "Opciones de local";
            // 
            // Agregarlocalbtn
            // 
            this.Agregarlocalbtn.Location = new System.Drawing.Point(104, 307);
            this.Agregarlocalbtn.Name = "Agregarlocalbtn";
            this.Agregarlocalbtn.Size = new System.Drawing.Size(89, 36);
            this.Agregarlocalbtn.TabIndex = 0;
            this.Agregarlocalbtn.Text = "Agregar local";
            this.Agregarlocalbtn.UseVisualStyleBackColor = true;
            this.Agregarlocalbtn.Click += new System.EventHandler(this.Agregarlocalbtn_Click);
            // 
            // Revisarlocalbtn
            // 
            this.Revisarlocalbtn.Location = new System.Drawing.Point(329, 307);
            this.Revisarlocalbtn.Name = "Revisarlocalbtn";
            this.Revisarlocalbtn.Size = new System.Drawing.Size(80, 36);
            this.Revisarlocalbtn.TabIndex = 1;
            this.Revisarlocalbtn.Text = "Revisar local";
            this.Revisarlocalbtn.UseVisualStyleBackColor = true;
            // 
            // Verlocalesexistentesbtn
            // 
            this.Verlocalesexistentesbtn.Location = new System.Drawing.Point(552, 307);
            this.Verlocalesexistentesbtn.Name = "Verlocalesexistentesbtn";
            this.Verlocalesexistentesbtn.Size = new System.Drawing.Size(112, 36);
            this.Verlocalesexistentesbtn.TabIndex = 2;
            this.Verlocalesexistentesbtn.Text = "Ver locales existentes";
            this.Verlocalesexistentesbtn.UseVisualStyleBackColor = true;
            // 
            // Panellocalrecreacional
            // 
            this.Panellocalrecreacional.BackColor = System.Drawing.Color.Aqua;
            this.Panellocalrecreacional.Controls.Add(this.Crearlocalrecreacionalbtn);
            this.Panellocalrecreacional.Controls.Add(this.Horariocierrerecreacionaltxt);
            this.Panellocalrecreacional.Controls.Add(this.Horarioiniciorecreacionaltxt);
            this.Panellocalrecreacional.Controls.Add(this.Identificadorrecreacionaltxt);
            this.Panellocalrecreacional.Controls.Add(this.Nombreduenolocalrecreacionaltxt);
            this.Panellocalrecreacional.Controls.Add(this.Horariocierrerecreacional);
            this.Panellocalrecreacional.Controls.Add(this.Horarioiniciorecreacionallabel);
            this.Panellocalrecreacional.Controls.Add(this.Identificadorrecreacionallabel);
            this.Panellocalrecreacional.Controls.Add(this.Recreacionalnombreduenolabel);
            this.Panellocalrecreacional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panellocalrecreacional.Location = new System.Drawing.Point(0, 0);
            this.Panellocalrecreacional.Name = "Panellocalrecreacional";
            this.Panellocalrecreacional.Size = new System.Drawing.Size(800, 450);
            this.Panellocalrecreacional.TabIndex = 11;
            // 
            // Horariocierrerecreacionaltxt
            // 
            this.Horariocierrerecreacionaltxt.Location = new System.Drawing.Point(189, 104);
            this.Horariocierrerecreacionaltxt.Name = "Horariocierrerecreacionaltxt";
            this.Horariocierrerecreacionaltxt.Size = new System.Drawing.Size(299, 20);
            this.Horariocierrerecreacionaltxt.TabIndex = 16;
            // 
            // Horarioiniciorecreacionaltxt
            // 
            this.Horarioiniciorecreacionaltxt.Location = new System.Drawing.Point(189, 75);
            this.Horarioiniciorecreacionaltxt.Name = "Horarioiniciorecreacionaltxt";
            this.Horarioiniciorecreacionaltxt.Size = new System.Drawing.Size(299, 20);
            this.Horarioiniciorecreacionaltxt.TabIndex = 15;
            // 
            // Identificadorrecreacionaltxt
            // 
            this.Identificadorrecreacionaltxt.Location = new System.Drawing.Point(189, 52);
            this.Identificadorrecreacionaltxt.Name = "Identificadorrecreacionaltxt";
            this.Identificadorrecreacionaltxt.Size = new System.Drawing.Size(299, 20);
            this.Identificadorrecreacionaltxt.TabIndex = 14;
            // 
            // Nombreduenolocalrecreacionaltxt
            // 
            this.Nombreduenolocalrecreacionaltxt.Location = new System.Drawing.Point(189, 26);
            this.Nombreduenolocalrecreacionaltxt.Name = "Nombreduenolocalrecreacionaltxt";
            this.Nombreduenolocalrecreacionaltxt.Size = new System.Drawing.Size(299, 20);
            this.Nombreduenolocalrecreacionaltxt.TabIndex = 13;
            // 
            // Horariocierrerecreacional
            // 
            this.Horariocierrerecreacional.AutoSize = true;
            this.Horariocierrerecreacional.Location = new System.Drawing.Point(22, 108);
            this.Horariocierrerecreacional.Name = "Horariocierrerecreacional";
            this.Horariocierrerecreacional.Size = new System.Drawing.Size(159, 13);
            this.Horariocierrerecreacional.TabIndex = 12;
            this.Horariocierrerecreacional.Text = "Horacio cierre local recreacional";
            // 
            // Horarioiniciorecreacionallabel
            // 
            this.Horarioiniciorecreacionallabel.AutoSize = true;
            this.Horarioiniciorecreacionallabel.Location = new System.Drawing.Point(22, 78);
            this.Horarioiniciorecreacionallabel.Name = "Horarioiniciorecreacionallabel";
            this.Horarioiniciorecreacionallabel.Size = new System.Drawing.Size(160, 13);
            this.Horarioiniciorecreacionallabel.TabIndex = 11;
            this.Horarioiniciorecreacionallabel.Text = "Horario inicio local recreacional: ";
            // 
            // Identificadorrecreacionallabel
            // 
            this.Identificadorrecreacionallabel.AutoSize = true;
            this.Identificadorrecreacionallabel.Location = new System.Drawing.Point(105, 55);
            this.Identificadorrecreacionallabel.Name = "Identificadorrecreacionallabel";
            this.Identificadorrecreacionallabel.Size = new System.Drawing.Size(71, 13);
            this.Identificadorrecreacionallabel.TabIndex = 10;
            this.Identificadorrecreacionallabel.Text = "Identificador: ";
            // 
            // Recreacionalnombreduenolabel
            // 
            this.Recreacionalnombreduenolabel.AutoSize = true;
            this.Recreacionalnombreduenolabel.Location = new System.Drawing.Point(105, 29);
            this.Recreacionalnombreduenolabel.Name = "Recreacionalnombreduenolabel";
            this.Recreacionalnombreduenolabel.Size = new System.Drawing.Size(80, 13);
            this.Recreacionalnombreduenolabel.TabIndex = 9;
            this.Recreacionalnombreduenolabel.Text = "Nombre dueño:";
            // 
            // Crearlocalrecreacionalbtn
            // 
            this.Crearlocalrecreacionalbtn.Location = new System.Drawing.Point(343, 197);
            this.Crearlocalrecreacionalbtn.Name = "Crearlocalrecreacionalbtn";
            this.Crearlocalrecreacionalbtn.Size = new System.Drawing.Size(110, 41);
            this.Crearlocalrecreacionalbtn.TabIndex = 17;
            this.Crearlocalrecreacionalbtn.Text = "Crear local Recreacional";
            this.Crearlocalrecreacionalbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panelinicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panelinicio.ResumeLayout(false);
            this.Panelcine.ResumeLayout(false);
            this.Panelcine.PerformLayout();
            this.Paneldeopciones.ResumeLayout(false);
            this.Paneldeopciones.PerformLayout();
            this.Panellocalrecreacional.ResumeLayout(false);
            this.Panellocalrecreacional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panelinicio;
        private System.Windows.Forms.Button Verlocalesexistentesbtn;
        private System.Windows.Forms.Button Revisarlocalbtn;
        private System.Windows.Forms.Button Agregarlocalbtn;
        private System.Windows.Forms.Panel Panelcine;
        private System.Windows.Forms.Label Nombreduenolabel;
        private System.Windows.Forms.Label Identificadorlabelcine;
        private System.Windows.Forms.Label Horariocierrecinelabel;
        private System.Windows.Forms.Label Horarioiniciocinelabel;
        private System.Windows.Forms.TextBox Horarioiniciotxt;
        private System.Windows.Forms.TextBox Identificadortxt;
        private System.Windows.Forms.TextBox Nombredueñotxt;
        private System.Windows.Forms.Label Numerodesalaslabel;
        private System.Windows.Forms.TextBox Numerodesalastxt;
        private System.Windows.Forms.TextBox Horariocierretxt;
        private System.Windows.Forms.ComboBox Comboxopciones;
        private System.Windows.Forms.Panel Paneldeopciones;
        private System.Windows.Forms.Label Labelcomboxopciones;
        private System.Windows.Forms.Button Enviaropcionbtn;
        private System.Windows.Forms.Button Crearcinebtn;
        private System.Windows.Forms.Panel Panellocalrecreacional;
        private System.Windows.Forms.Button Crearlocalrecreacionalbtn;
        private System.Windows.Forms.TextBox Horariocierrerecreacionaltxt;
        private System.Windows.Forms.TextBox Horarioiniciorecreacionaltxt;
        private System.Windows.Forms.TextBox Identificadorrecreacionaltxt;
        private System.Windows.Forms.TextBox Nombreduenolocalrecreacionaltxt;
        private System.Windows.Forms.Label Horariocierrerecreacional;
        private System.Windows.Forms.Label Horarioiniciorecreacionallabel;
        private System.Windows.Forms.Label Identificadorrecreacionallabel;
        private System.Windows.Forms.Label Recreacionalnombreduenolabel;
    }
}

