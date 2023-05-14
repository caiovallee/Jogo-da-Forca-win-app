namespace Jogo_da_Forca
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
            LblPalavraSecreta = new Label();
            pnlBotoes = new Panel();
            button26 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button1 = new Button();
            lblDica = new Label();
            btnReset = new Button();
            Pbforca = new PictureBox();
            TxtStatusFinal = new TextBox();
            pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pbforca).BeginInit();
            SuspendLayout();
            // 
            // LblPalavraSecreta
            // 
            LblPalavraSecreta.AutoSize = true;
            LblPalavraSecreta.BackColor = SystemColors.Info;
            LblPalavraSecreta.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblPalavraSecreta.Location = new Point(37, 108);
            LblPalavraSecreta.Name = "LblPalavraSecreta";
            LblPalavraSecreta.Size = new Size(113, 37);
            LblPalavraSecreta.TabIndex = 0;
            LblPalavraSecreta.Text = "????????";
            LblPalavraSecreta.Click += LblPalavraSecreta_Click;
            // 
            // pnlBotoes
            // 
            pnlBotoes.Controls.Add(button26);
            pnlBotoes.Controls.Add(button22);
            pnlBotoes.Controls.Add(button23);
            pnlBotoes.Controls.Add(button24);
            pnlBotoes.Controls.Add(button25);
            pnlBotoes.Controls.Add(button15);
            pnlBotoes.Controls.Add(button16);
            pnlBotoes.Controls.Add(button17);
            pnlBotoes.Controls.Add(button18);
            pnlBotoes.Controls.Add(button19);
            pnlBotoes.Controls.Add(button20);
            pnlBotoes.Controls.Add(button21);
            pnlBotoes.Controls.Add(button2);
            pnlBotoes.Controls.Add(button3);
            pnlBotoes.Controls.Add(button4);
            pnlBotoes.Controls.Add(button5);
            pnlBotoes.Controls.Add(button12);
            pnlBotoes.Controls.Add(button13);
            pnlBotoes.Controls.Add(button14);
            pnlBotoes.Controls.Add(button11);
            pnlBotoes.Controls.Add(button10);
            pnlBotoes.Controls.Add(button9);
            pnlBotoes.Controls.Add(button8);
            pnlBotoes.Controls.Add(button7);
            pnlBotoes.Controls.Add(button6);
            pnlBotoes.Controls.Add(button1);
            pnlBotoes.Location = new Point(37, 174);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(360, 175);
            pnlBotoes.TabIndex = 2;
            pnlBotoes.Paint += panel1_Paint;
            // 
            // button26
            // 
            button26.Location = new Point(208, 137);
            button26.Name = "button26";
            button26.Size = new Size(46, 38);
            button26.TabIndex = 29;
            button26.Text = "Z";
            button26.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(52, 137);
            button22.Name = "button22";
            button22.Size = new Size(46, 38);
            button22.TabIndex = 28;
            button22.Text = "W";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.Location = new Point(104, 137);
            button23.Name = "button23";
            button23.Size = new Size(46, 38);
            button23.TabIndex = 27;
            button23.Text = "X";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // button24
            // 
            button24.Location = new Point(156, 137);
            button24.Name = "button24";
            button24.Size = new Size(46, 38);
            button24.TabIndex = 26;
            button24.Text = "Y";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // button25
            // 
            button25.Location = new Point(0, 137);
            button25.Name = "button25";
            button25.Size = new Size(46, 38);
            button25.TabIndex = 25;
            button25.Text = "V";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button25_Click;
            // 
            // button15
            // 
            button15.Location = new Point(52, 93);
            button15.Name = "button15";
            button15.Size = new Size(46, 38);
            button15.TabIndex = 24;
            button15.Text = "P";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(104, 93);
            button16.Name = "button16";
            button16.Size = new Size(46, 38);
            button16.TabIndex = 23;
            button16.Text = "Q";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(156, 93);
            button17.Name = "button17";
            button17.Size = new Size(46, 38);
            button17.TabIndex = 22;
            button17.Text = "R";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(208, 93);
            button18.Name = "button18";
            button18.Size = new Size(46, 38);
            button18.TabIndex = 21;
            button18.Text = "S";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(260, 93);
            button19.Name = "button19";
            button19.Size = new Size(46, 38);
            button19.TabIndex = 20;
            button19.Text = "T";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(314, 93);
            button20.Name = "button20";
            button20.Size = new Size(46, 38);
            button20.TabIndex = 19;
            button20.Text = "U";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(0, 93);
            button21.Name = "button21";
            button21.Size = new Size(46, 38);
            button21.TabIndex = 18;
            button21.Text = "O";
            button21.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(52, 44);
            button2.Name = "button2";
            button2.Size = new Size(46, 38);
            button2.TabIndex = 17;
            button2.Text = "I";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(104, 44);
            button3.Name = "button3";
            button3.Size = new Size(46, 38);
            button3.TabIndex = 16;
            button3.Text = "J";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(156, 44);
            button4.Name = "button4";
            button4.Size = new Size(46, 38);
            button4.TabIndex = 15;
            button4.Text = "K";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(208, 44);
            button5.Name = "button5";
            button5.Size = new Size(46, 38);
            button5.TabIndex = 14;
            button5.Text = "L";
            button5.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(260, 44);
            button12.Name = "button12";
            button12.Size = new Size(46, 38);
            button12.TabIndex = 13;
            button12.Text = "M";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(314, 44);
            button13.Name = "button13";
            button13.Size = new Size(46, 38);
            button13.TabIndex = 12;
            button13.Text = "N";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(0, 44);
            button14.Name = "button14";
            button14.Size = new Size(46, 38);
            button14.TabIndex = 11;
            button14.Text = "H";
            button14.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(52, 0);
            button11.Name = "button11";
            button11.Size = new Size(46, 38);
            button11.TabIndex = 10;
            button11.Text = "B";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(104, 0);
            button10.Name = "button10";
            button10.Size = new Size(46, 38);
            button10.TabIndex = 9;
            button10.Text = "C";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(156, 0);
            button9.Name = "button9";
            button9.Size = new Size(46, 38);
            button9.TabIndex = 8;
            button9.Text = "D";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(208, 0);
            button8.Name = "button8";
            button8.Size = new Size(46, 38);
            button8.TabIndex = 7;
            button8.Text = "E";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(260, 0);
            button7.Name = "button7";
            button7.Size = new Size(46, 38);
            button7.TabIndex = 6;
            button7.Text = "F";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(314, 0);
            button6.Name = "button6";
            button6.Size = new Size(46, 38);
            button6.TabIndex = 5;
            button6.Text = "G";
            button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(46, 38);
            button1.TabIndex = 0;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblDica
            // 
            lblDica.AutoSize = true;
            lblDica.Location = new Point(45, 93);
            lblDica.Name = "lblDica";
            lblDica.Size = new Size(58, 15);
            lblDica.TabIndex = 3;
            lblDica.Text = "Qtd letras";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(259, 122);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Nova Palavra";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button27_Click;
            // 
            // Pbforca
            // 
            Pbforca.Image = Properties.Resources.Forca1;
            Pbforca.Location = new Point(419, 122);
            Pbforca.Name = "Pbforca";
            Pbforca.Size = new Size(312, 227);
            Pbforca.SizeMode = PictureBoxSizeMode.StretchImage;
            Pbforca.TabIndex = 5;
            Pbforca.TabStop = false;
            Pbforca.Click += Pbforca_Click;
            // 
            // TxtStatusFinal
            // 
            TxtStatusFinal.BackColor = SystemColors.Info;
            TxtStatusFinal.BorderStyle = BorderStyle.None;
            TxtStatusFinal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TxtStatusFinal.Location = new Point(371, 93);
            TxtStatusFinal.Name = "TxtStatusFinal";
            TxtStatusFinal.Size = new Size(360, 26);
            TxtStatusFinal.TabIndex = 6;
            TxtStatusFinal.TextChanged += TxtStatusFinal_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(735, 363);
            Controls.Add(TxtStatusFinal);
            Controls.Add(Pbforca);
            Controls.Add(btnReset);
            Controls.Add(lblDica);
            Controls.Add(pnlBotoes);
            Controls.Add(LblPalavraSecreta);
            Name = "Form1";
            Text = "Jogo da forca dos gurizes";
            pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pbforca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPalavraSecreta;
        private Panel pnlBotoes;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button1;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Label lblDica;
        private Button btnReset;
        private PictureBox Pbforca;
        private TextBox TxtStatusFinal;
    }
}