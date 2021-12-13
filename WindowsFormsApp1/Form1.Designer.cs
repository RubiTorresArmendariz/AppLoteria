namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBuenas = new System.Windows.Forms.Button();
            this.Cartas = new System.Windows.Forms.GroupBox();
            this.pbCarta = new System.Windows.Forms.PictureBox();
            this.Restan = new System.Windows.Forms.GroupBox();
            this.Historial = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Siguiente = new System.Windows.Forms.Button();
            this.Barajear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Cartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarta)).BeginInit();
            this.Historial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuenas
            // 
            this.btnBuenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuenas.Location = new System.Drawing.Point(644, 383);
            this.btnBuenas.Name = "btnBuenas";
            this.btnBuenas.Size = new System.Drawing.Size(432, 61);
            this.btnBuenas.TabIndex = 0;
            this.btnBuenas.Text = "BUENAAAAAAAAAAAAAAAS!!!!!!!!!!!!!!!";
            this.btnBuenas.UseVisualStyleBackColor = true;
            // 
            // Cartas
            // 
            this.Cartas.BackColor = System.Drawing.Color.Transparent;
            this.Cartas.Controls.Add(this.pbCarta);
            this.Cartas.Controls.Add(this.Restan);
            this.Cartas.Location = new System.Drawing.Point(841, 12);
            this.Cartas.Name = "Cartas";
            this.Cartas.Size = new System.Drawing.Size(235, 301);
            this.Cartas.TabIndex = 5;
            this.Cartas.TabStop = false;
            this.Cartas.Text = "Cartas";
            // 
            // pbCarta
            // 
            this.pbCarta.Location = new System.Drawing.Point(5, 25);
            this.pbCarta.Name = "pbCarta";
            this.pbCarta.Size = new System.Drawing.Size(230, 267);
            this.pbCarta.TabIndex = 7;
            this.pbCarta.TabStop = false;
            // 
            // Restan
            // 
            this.Restan.Location = new System.Drawing.Point(241, 122);
            this.Restan.Name = "Restan";
            this.Restan.Size = new System.Drawing.Size(229, 64);
            this.Restan.TabIndex = 6;
            this.Restan.TabStop = false;
            this.Restan.Text = "groupBox3";
            // 
            // Historial
            // 
            this.Historial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Historial.BackgroundImage")));
            this.Historial.Controls.Add(this.listView1);
            this.Historial.Location = new System.Drawing.Point(561, 532);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(1002, 175);
            this.Historial.TabIndex = 6;
            this.Historial.TabStop = false;
            this.Historial.Text = "Historial";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(950, 115);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Siguiente
            // 
            this.Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siguiente.Location = new System.Drawing.Point(1076, 204);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(235, 71);
            this.Siguiente.TabIndex = 7;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Barajear
            // 
            this.Barajear.BackColor = System.Drawing.Color.Black;
            this.Barajear.ForeColor = System.Drawing.Color.White;
            this.Barajear.Location = new System.Drawing.Point(647, 134);
            this.Barajear.Name = "Barajear";
            this.Barajear.Size = new System.Drawing.Size(172, 44);
            this.Barajear.TabIndex = 8;
            this.Barajear.Text = "INCIAR PARTIDA";
            this.Barajear.UseVisualStyleBackColor = false;
            this.Barajear.Click += new System.EventHandler(this.Barajear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1088, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 68);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restan";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 54);
            this.label1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(655, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1575, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Barajear);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.Cartas);
            this.Controls.Add(this.btnBuenas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Cartas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarta)).EndInit();
            this.Historial.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuenas;
        private System.Windows.Forms.GroupBox Cartas;
        private System.Windows.Forms.PictureBox pbCarta;
        private System.Windows.Forms.GroupBox Restan;
        private System.Windows.Forms.GroupBox Historial;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Button Barajear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}

