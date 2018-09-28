namespace Romeinse_Rekenmachine
{
    partial class Romeinse_Rekenmachine
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
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.I = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.Clear_Entry = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(50, 24);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(447, 60);
            this.Input.TabIndex = 0;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(50, 490);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(447, 66);
            this.Output.TabIndex = 2;
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // I
            // 
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I.Location = new System.Drawing.Point(50, 98);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(145, 50);
            this.I.TabIndex = 3;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // V
            // 
            this.V.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.V.Location = new System.Drawing.Point(50, 154);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(145, 50);
            this.V.TabIndex = 4;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = true;
            this.V.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // X
            // 
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.X.Location = new System.Drawing.Point(50, 210);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(145, 50);
            this.X.TabIndex = 5;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.D.Location = new System.Drawing.Point(50, 378);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(145, 50);
            this.D.TabIndex = 8;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.C.Location = new System.Drawing.Point(50, 322);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(145, 50);
            this.C.TabIndex = 7;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // L
            // 
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.L.Location = new System.Drawing.Point(50, 266);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(145, 50);
            this.L.TabIndex = 6;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // M
            // 
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.M.Location = new System.Drawing.Point(50, 434);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(145, 50);
            this.M.TabIndex = 10;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            this.M.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // Clear_Entry
            // 
            this.Clear_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Clear_Entry.Location = new System.Drawing.Point(352, 254);
            this.Clear_Entry.Name = "Clear_Entry";
            this.Clear_Entry.Size = new System.Drawing.Size(145, 104);
            this.Clear_Entry.TabIndex = 14;
            this.Clear_Entry.Text = "Clear Entry";
            this.Clear_Entry.UseVisualStyleBackColor = true;
            this.Clear_Entry.Click += new System.EventHandler(this.Clear_Entry_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Clear.Location = new System.Drawing.Point(352, 98);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(145, 152);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Plus.Location = new System.Drawing.Point(201, 392);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(145, 90);
            this.Plus.TabIndex = 20;
            this.Plus.Text = "+";
            this.Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Minus.Location = new System.Drawing.Point(201, 294);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(145, 90);
            this.Minus.TabIndex = 16;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Multiply.Location = new System.Drawing.Point(201, 98);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(145, 90);
            this.Multiply.TabIndex = 17;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Divide.Location = new System.Drawing.Point(201, 196);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(145, 90);
            this.Divide.TabIndex = 18;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Equals
            // 
            this.Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Equals.Location = new System.Drawing.Point(352, 364);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(145, 118);
            this.Equals.TabIndex = 19;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Romeinse_Rekenmachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 590);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Clear_Entry);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.M);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.L);
            this.Controls.Add(this.X);
            this.Controls.Add(this.V);
            this.Controls.Add(this.I);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.MaximizeBox = false;
            this.Name = "Romeinse_Rekenmachine";
            this.Text = "Romeinse Rekenmachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button Clear_Entry;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private new System.Windows.Forms.Button Equals;
    }
}

