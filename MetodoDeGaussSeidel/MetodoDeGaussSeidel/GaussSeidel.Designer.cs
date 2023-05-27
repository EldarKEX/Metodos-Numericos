
namespace MetodoDeGaussSeidel
{
    partial class GaussSeidel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.btnCalc = new CustomControls.RJControls.RJButton();
            this.lbValV = new System.Windows.Forms.Label();
            this.tbValueV = new CustomControls.RJControls.RJTextBox();
            this.lbEcV = new System.Windows.Forms.Label();
            this.tbEcuV = new CustomControls.RJControls.RJTextBox();
            this.lbValU = new System.Windows.Forms.Label();
            this.tbValueU = new CustomControls.RJControls.RJTextBox();
            this.lbValZ = new System.Windows.Forms.Label();
            this.tbValueZ = new CustomControls.RJControls.RJTextBox();
            this.lbEcU = new System.Windows.Forms.Label();
            this.tbEcuU = new CustomControls.RJControls.RJTextBox();
            this.lbEcZ = new System.Windows.Forms.Label();
            this.tbEcuZ = new CustomControls.RJControls.RJTextBox();
            this.lbValY = new System.Windows.Forms.Label();
            this.tbValueY = new CustomControls.RJControls.RJTextBox();
            this.lbValX = new System.Windows.Forms.Label();
            this.tbValueX = new CustomControls.RJControls.RJTextBox();
            this.lbEcY = new System.Windows.Forms.Label();
            this.tbEcuY = new CustomControls.RJControls.RJTextBox();
            this.lbEcX = new System.Windows.Forms.Label();
            this.tbEcuX = new CustomControls.RJControls.RJTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEstimado = new CustomControls.RJControls.RJTextBox();
            this.cbNumEcuac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 122);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Controls.Add(this.lbValV);
            this.groupBox2.Controls.Add(this.tbValueV);
            this.groupBox2.Controls.Add(this.lbEcV);
            this.groupBox2.Controls.Add(this.tbEcuV);
            this.groupBox2.Controls.Add(this.lbValU);
            this.groupBox2.Controls.Add(this.tbValueU);
            this.groupBox2.Controls.Add(this.lbValZ);
            this.groupBox2.Controls.Add(this.tbValueZ);
            this.groupBox2.Controls.Add(this.lbEcU);
            this.groupBox2.Controls.Add(this.tbEcuU);
            this.groupBox2.Controls.Add(this.lbEcZ);
            this.groupBox2.Controls.Add(this.tbEcuZ);
            this.groupBox2.Controls.Add(this.lbValY);
            this.groupBox2.Controls.Add(this.tbValueY);
            this.groupBox2.Controls.Add(this.lbValX);
            this.groupBox2.Controls.Add(this.tbValueX);
            this.groupBox2.Controls.Add(this.lbEcY);
            this.groupBox2.Controls.Add(this.tbEcuY);
            this.groupBox2.Controls.Add(this.lbEcX);
            this.groupBox2.Controls.Add(this.tbEcuX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(282, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ecuaciones";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(792, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 29);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Limpiar";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnCalc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnCalc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCalc.BorderRadius = 0;
            this.btnCalc.BorderSize = 0;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Location = new System.Drawing.Point(656, 75);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(118, 29);
            this.btnCalc.TabIndex = 22;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.TextColor = System.Drawing.Color.White;
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbValV
            // 
            this.lbValV.AutoSize = true;
            this.lbValV.Location = new System.Drawing.Point(807, 30);
            this.lbValV.Name = "lbValV";
            this.lbValV.Size = new System.Drawing.Size(28, 15);
            this.lbValV.TabIndex = 21;
            this.lbValV.Text = "V =  ";
            // 
            // tbValueV
            // 
            this.tbValueV.BackColor = System.Drawing.SystemColors.Window;
            this.tbValueV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbValueV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbValueV.BorderRadius = 0;
            this.tbValueV.BorderSize = 2;
            this.tbValueV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValueV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbValueV.Location = new System.Drawing.Point(841, 23);
            this.tbValueV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbValueV.Multiline = false;
            this.tbValueV.Name = "tbValueV";
            this.tbValueV.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbValueV.PasswordChar = false;
            this.tbValueV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbValueV.PlaceholderText = "";
            this.tbValueV.Size = new System.Drawing.Size(70, 33);
            this.tbValueV.TabIndex = 20;
            this.tbValueV.Texts = "";
            this.tbValueV.UnderlinedStyle = false;
            // 
            // lbEcV
            // 
            this.lbEcV.AutoSize = true;
            this.lbEcV.Location = new System.Drawing.Point(622, 30);
            this.lbEcV.Name = "lbEcV";
            this.lbEcV.Size = new System.Drawing.Size(28, 15);
            this.lbEcV.TabIndex = 17;
            this.lbEcV.Text = "V =  ";
            // 
            // tbEcuV
            // 
            this.tbEcuV.BackColor = System.Drawing.SystemColors.Window;
            this.tbEcuV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbEcuV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEcuV.BorderRadius = 0;
            this.tbEcuV.BorderSize = 2;
            this.tbEcuV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEcuV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEcuV.Location = new System.Drawing.Point(656, 23);
            this.tbEcuV.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEcuV.Multiline = false;
            this.tbEcuV.Name = "tbEcuV";
            this.tbEcuV.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbEcuV.PasswordChar = false;
            this.tbEcuV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEcuV.PlaceholderText = "";
            this.tbEcuV.Size = new System.Drawing.Size(145, 33);
            this.tbEcuV.TabIndex = 16;
            this.tbEcuV.Texts = "";
            this.tbEcuV.UnderlinedStyle = false;
            // 
            // lbValU
            // 
            this.lbValU.AutoSize = true;
            this.lbValU.Location = new System.Drawing.Point(498, 75);
            this.lbValU.Name = "lbValU";
            this.lbValU.Size = new System.Drawing.Size(29, 15);
            this.lbValU.TabIndex = 15;
            this.lbValU.Text = "U =  ";
            // 
            // tbValueU
            // 
            this.tbValueU.BackColor = System.Drawing.SystemColors.Window;
            this.tbValueU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbValueU.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbValueU.BorderRadius = 0;
            this.tbValueU.BorderSize = 2;
            this.tbValueU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValueU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbValueU.Location = new System.Drawing.Point(532, 68);
            this.tbValueU.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbValueU.Multiline = false;
            this.tbValueU.Name = "tbValueU";
            this.tbValueU.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbValueU.PasswordChar = false;
            this.tbValueU.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbValueU.PlaceholderText = "";
            this.tbValueU.Size = new System.Drawing.Size(70, 33);
            this.tbValueU.TabIndex = 14;
            this.tbValueU.Texts = "4";
            this.tbValueU.UnderlinedStyle = false;
            // 
            // lbValZ
            // 
            this.lbValZ.AutoSize = true;
            this.lbValZ.Location = new System.Drawing.Point(498, 30);
            this.lbValZ.Name = "lbValZ";
            this.lbValZ.Size = new System.Drawing.Size(27, 15);
            this.lbValZ.TabIndex = 13;
            this.lbValZ.Text = "Z =  ";
            // 
            // tbValueZ
            // 
            this.tbValueZ.BackColor = System.Drawing.SystemColors.Window;
            this.tbValueZ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbValueZ.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbValueZ.BorderRadius = 0;
            this.tbValueZ.BorderSize = 2;
            this.tbValueZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValueZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbValueZ.Location = new System.Drawing.Point(532, 23);
            this.tbValueZ.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbValueZ.Multiline = false;
            this.tbValueZ.Name = "tbValueZ";
            this.tbValueZ.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbValueZ.PasswordChar = false;
            this.tbValueZ.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbValueZ.PlaceholderText = "";
            this.tbValueZ.Size = new System.Drawing.Size(70, 33);
            this.tbValueZ.TabIndex = 12;
            this.tbValueZ.Texts = "3";
            this.tbValueZ.UnderlinedStyle = false;
            // 
            // lbEcU
            // 
            this.lbEcU.AutoSize = true;
            this.lbEcU.Location = new System.Drawing.Point(313, 75);
            this.lbEcU.Name = "lbEcU";
            this.lbEcU.Size = new System.Drawing.Size(29, 15);
            this.lbEcU.TabIndex = 11;
            this.lbEcU.Text = "U =  ";
            // 
            // tbEcuU
            // 
            this.tbEcuU.BackColor = System.Drawing.SystemColors.Window;
            this.tbEcuU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbEcuU.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEcuU.BorderRadius = 0;
            this.tbEcuU.BorderSize = 2;
            this.tbEcuU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEcuU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEcuU.Location = new System.Drawing.Point(346, 68);
            this.tbEcuU.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEcuU.Multiline = false;
            this.tbEcuU.Name = "tbEcuU";
            this.tbEcuU.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbEcuU.PasswordChar = false;
            this.tbEcuU.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEcuU.PlaceholderText = "";
            this.tbEcuU.Size = new System.Drawing.Size(145, 33);
            this.tbEcuU.TabIndex = 10;
            this.tbEcuU.Texts = "(47-1x-2y-3z)/20";
            this.tbEcuU.UnderlinedStyle = false;
            // 
            // lbEcZ
            // 
            this.lbEcZ.AutoSize = true;
            this.lbEcZ.Location = new System.Drawing.Point(313, 30);
            this.lbEcZ.Name = "lbEcZ";
            this.lbEcZ.Size = new System.Drawing.Size(27, 15);
            this.lbEcZ.TabIndex = 9;
            this.lbEcZ.Text = "Z =  ";
            // 
            // tbEcuZ
            // 
            this.tbEcuZ.BackColor = System.Drawing.SystemColors.Window;
            this.tbEcuZ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbEcuZ.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEcuZ.BorderRadius = 0;
            this.tbEcuZ.BorderSize = 2;
            this.tbEcuZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEcuZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEcuZ.Location = new System.Drawing.Point(346, 23);
            this.tbEcuZ.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEcuZ.Multiline = false;
            this.tbEcuZ.Name = "tbEcuZ";
            this.tbEcuZ.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbEcuZ.PasswordChar = false;
            this.tbEcuZ.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEcuZ.PlaceholderText = "";
            this.tbEcuZ.Size = new System.Drawing.Size(145, 33);
            this.tbEcuZ.TabIndex = 8;
            this.tbEcuZ.Texts = "(53+2x-20y)/30";
            this.tbEcuZ.UnderlinedStyle = false;
            // 
            // lbValY
            // 
            this.lbValY.AutoSize = true;
            this.lbValY.Location = new System.Drawing.Point(194, 74);
            this.lbValY.Name = "lbValY";
            this.lbValY.Size = new System.Drawing.Size(28, 15);
            this.lbValY.TabIndex = 7;
            this.lbValY.Text = "Y =  ";
            // 
            // tbValueY
            // 
            this.tbValueY.BackColor = System.Drawing.SystemColors.Window;
            this.tbValueY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbValueY.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbValueY.BorderRadius = 0;
            this.tbValueY.BorderSize = 2;
            this.tbValueY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValueY.ForeColor = System.Drawing.Color.Black;
            this.tbValueY.Location = new System.Drawing.Point(227, 67);
            this.tbValueY.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbValueY.Multiline = false;
            this.tbValueY.Name = "tbValueY";
            this.tbValueY.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbValueY.PasswordChar = false;
            this.tbValueY.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbValueY.PlaceholderText = "";
            this.tbValueY.Size = new System.Drawing.Size(70, 33);
            this.tbValueY.TabIndex = 6;
            this.tbValueY.Texts = "2";
            this.tbValueY.UnderlinedStyle = false;
            // 
            // lbValX
            // 
            this.lbValX.AutoSize = true;
            this.lbValX.Location = new System.Drawing.Point(194, 29);
            this.lbValX.Name = "lbValX";
            this.lbValX.Size = new System.Drawing.Size(28, 15);
            this.lbValX.TabIndex = 5;
            this.lbValX.Text = "X =  ";
            // 
            // tbValueX
            // 
            this.tbValueX.BackColor = System.Drawing.SystemColors.Window;
            this.tbValueX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbValueX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbValueX.BorderRadius = 0;
            this.tbValueX.BorderSize = 2;
            this.tbValueX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValueX.ForeColor = System.Drawing.Color.Black;
            this.tbValueX.Location = new System.Drawing.Point(227, 22);
            this.tbValueX.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbValueX.Multiline = false;
            this.tbValueX.Name = "tbValueX";
            this.tbValueX.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbValueX.PasswordChar = false;
            this.tbValueX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbValueX.PlaceholderText = "";
            this.tbValueX.Size = new System.Drawing.Size(70, 33);
            this.tbValueX.TabIndex = 4;
            this.tbValueX.Texts = "1";
            this.tbValueX.UnderlinedStyle = false;
            // 
            // lbEcY
            // 
            this.lbEcY.AutoSize = true;
            this.lbEcY.Location = new System.Drawing.Point(8, 74);
            this.lbEcY.Name = "lbEcY";
            this.lbEcY.Size = new System.Drawing.Size(28, 15);
            this.lbEcY.TabIndex = 3;
            this.lbEcY.Text = "Y =  ";
            // 
            // tbEcuY
            // 
            this.tbEcuY.BackColor = System.Drawing.SystemColors.Window;
            this.tbEcuY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbEcuY.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEcuY.BorderRadius = 0;
            this.tbEcuY.BorderSize = 2;
            this.tbEcuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEcuY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEcuY.Location = new System.Drawing.Point(42, 67);
            this.tbEcuY.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEcuY.Multiline = false;
            this.tbEcuY.Name = "tbEcuY";
            this.tbEcuY.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbEcuY.PasswordChar = false;
            this.tbEcuY.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEcuY.PlaceholderText = "";
            this.tbEcuY.Size = new System.Drawing.Size(145, 33);
            this.tbEcuY.TabIndex = 2;
            this.tbEcuY.Texts = "(-15 - 1x+2z-3u)/20";
            this.tbEcuY.UnderlinedStyle = false;
            // 
            // lbEcX
            // 
            this.lbEcX.AutoSize = true;
            this.lbEcX.Location = new System.Drawing.Point(8, 29);
            this.lbEcX.Name = "lbEcX";
            this.lbEcX.Size = new System.Drawing.Size(28, 15);
            this.lbEcX.TabIndex = 1;
            this.lbEcX.Text = "X =  ";
            // 
            // tbEcuX
            // 
            this.tbEcuX.BackColor = System.Drawing.SystemColors.Window;
            this.tbEcuX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbEcuX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEcuX.BorderRadius = 0;
            this.tbEcuX.BorderSize = 2;
            this.tbEcuX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEcuX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEcuX.Location = new System.Drawing.Point(42, 22);
            this.tbEcuX.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEcuX.Multiline = false;
            this.tbEcuX.Name = "tbEcuX";
            this.tbEcuX.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbEcuX.PasswordChar = false;
            this.tbEcuX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEcuX.PlaceholderText = "";
            this.tbEcuX.Size = new System.Drawing.Size(145, 33);
            this.tbEcuX.TabIndex = 0;
            this.tbEcuX.Texts = "(26-2y+1z)/10";
            this.tbEcuX.UnderlinedStyle = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.tbEstimado);
            this.groupBox1.Controls.Add(this.cbNumEcuac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de ecuaciones";
            // 
            // tbEstimado
            // 
            this.tbEstimado.BackColor = System.Drawing.SystemColors.Window;
            this.tbEstimado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.tbEstimado.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEstimado.BorderRadius = 0;
            this.tbEstimado.BorderSize = 2;
            this.tbEstimado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEstimado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEstimado.Location = new System.Drawing.Point(157, 54);
            this.tbEstimado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEstimado.Multiline = false;
            this.tbEstimado.Name = "tbEstimado";
            this.tbEstimado.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tbEstimado.PasswordChar = false;
            this.tbEstimado.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEstimado.PlaceholderText = "";
            this.tbEstimado.Size = new System.Drawing.Size(110, 33);
            this.tbEstimado.TabIndex = 4;
            this.tbEstimado.Texts = "0.5";
            this.tbEstimado.UnderlinedStyle = false;
            // 
            // cbNumEcuac
            // 
            this.cbNumEcuac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNumEcuac.FormattingEnabled = true;
            this.cbNumEcuac.Location = new System.Drawing.Point(157, 22);
            this.cbNumEcuac.Name = "cbNumEcuac";
            this.cbNumEcuac.Size = new System.Drawing.Size(109, 23);
            this.cbNumEcuac.TabIndex = 3;
            this.cbNumEcuac.SelectedIndexChanged += new System.EventHandler(this.cbNumEcuac_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estimado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero de ecuaciones:";
            // 
            // labelTittle
            // 
            this.labelTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labelTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTittle.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.White;
            this.labelTittle.Location = new System.Drawing.Point(0, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(1209, 28);
            this.labelTittle.TabIndex = 6;
            this.labelTittle.Text = "Metodo de Gauss-Seidel";
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1209, 369);
            this.dataGridView1.TabIndex = 7;
            // 
            // GaussSeidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTittle);
            this.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GaussSeidel";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox tbEstimado;
        private System.Windows.Forms.ComboBox cbNumEcuac;
        private System.Windows.Forms.Label lbEcY;
        private CustomControls.RJControls.RJTextBox tbEcuY;
        private System.Windows.Forms.Label lbEcX;
        private CustomControls.RJControls.RJTextBox tbEcuX;
        private CustomControls.RJControls.RJButton btnClear;
        private CustomControls.RJControls.RJButton btnCalc;
        private System.Windows.Forms.Label lbValV;
        private CustomControls.RJControls.RJTextBox tbValueV;
        private System.Windows.Forms.Label lbEcV;
        private CustomControls.RJControls.RJTextBox tbEcuV;
        private System.Windows.Forms.Label lbValU;
        private CustomControls.RJControls.RJTextBox tbValueU;
        private System.Windows.Forms.Label lbValZ;
        private CustomControls.RJControls.RJTextBox tbValueZ;
        private System.Windows.Forms.Label lbEcU;
        private CustomControls.RJControls.RJTextBox tbEcuU;
        private System.Windows.Forms.Label lbEcZ;
        private CustomControls.RJControls.RJTextBox tbEcuZ;
        private System.Windows.Forms.Label lbValY;
        private CustomControls.RJControls.RJTextBox tbValueY;
        private System.Windows.Forms.Label lbValX;
        private CustomControls.RJControls.RJTextBox tbValueX;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

