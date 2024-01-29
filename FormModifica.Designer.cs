namespace Jody___Verifica
{
    partial class FormModifica
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
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.textBoxCodiceFarnel = new System.Windows.Forms.TextBox();
            this.textBoxProduttore = new System.Windows.Forms.TextBox();
            this.textBoxCodiceProduttore = new System.Windows.Forms.TextBox();
            this.textBoxQuantita = new System.Windows.Forms.TextBox();
            this.textBoxPrezzo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonsalva = new System.Windows.Forms.Button();
            this.buttonannulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(113, 12);
            this.textBoxDescrizione.Multiline = true;
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(247, 120);
            this.textBoxDescrizione.TabIndex = 0;
            this.textBoxDescrizione.TextChanged += new System.EventHandler(this.textBoxDescrizione_TextChanged);
            // 
            // textBoxCodiceFarnel
            // 
            this.textBoxCodiceFarnel.Location = new System.Drawing.Point(113, 138);
            this.textBoxCodiceFarnel.Name = "textBoxCodiceFarnel";
            this.textBoxCodiceFarnel.Size = new System.Drawing.Size(247, 23);
            this.textBoxCodiceFarnel.TabIndex = 1;
            this.textBoxCodiceFarnel.TextChanged += new System.EventHandler(this.textBoxCodiceFarnel_TextChanged);
            // 
            // textBoxProduttore
            // 
            this.textBoxProduttore.Location = new System.Drawing.Point(113, 167);
            this.textBoxProduttore.Name = "textBoxProduttore";
            this.textBoxProduttore.Size = new System.Drawing.Size(247, 23);
            this.textBoxProduttore.TabIndex = 2;
            this.textBoxProduttore.TextChanged += new System.EventHandler(this.textBoxProduttore_TextChanged);
            // 
            // textBoxCodiceProduttore
            // 
            this.textBoxCodiceProduttore.Location = new System.Drawing.Point(113, 196);
            this.textBoxCodiceProduttore.Name = "textBoxCodiceProduttore";
            this.textBoxCodiceProduttore.Size = new System.Drawing.Size(247, 23);
            this.textBoxCodiceProduttore.TabIndex = 3;
            this.textBoxCodiceProduttore.TextChanged += new System.EventHandler(this.textBoxCodiceProduttore_TextChanged);
            // 
            // textBoxQuantita
            // 
            this.textBoxQuantita.Location = new System.Drawing.Point(113, 225);
            this.textBoxQuantita.Name = "textBoxQuantita";
            this.textBoxQuantita.Size = new System.Drawing.Size(247, 23);
            this.textBoxQuantita.TabIndex = 4;
            this.textBoxQuantita.TextChanged += new System.EventHandler(this.textBoxQuantita_TextChanged);
            // 
            // textBoxPrezzo
            // 
            this.textBoxPrezzo.Location = new System.Drawing.Point(113, 254);
            this.textBoxPrezzo.Name = "textBoxPrezzo";
            this.textBoxPrezzo.Size = new System.Drawing.Size(247, 23);
            this.textBoxPrezzo.TabIndex = 5;
            this.textBoxPrezzo.TextChanged += new System.EventHandler(this.textBoxPrezzo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrizione";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codice farnel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prdoduttore";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codice Produttore";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantità";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prezzo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonsalva
            // 
            this.buttonsalva.Location = new System.Drawing.Point(285, 297);
            this.buttonsalva.Name = "buttonsalva";
            this.buttonsalva.Size = new System.Drawing.Size(75, 23);
            this.buttonsalva.TabIndex = 12;
            this.buttonsalva.Text = "salva";
            this.buttonsalva.UseVisualStyleBackColor = true;
            this.buttonsalva.Click += new System.EventHandler(this.buttonsalva_Click);
            // 
            // buttonannulla
            // 
            this.buttonannulla.Location = new System.Drawing.Point(204, 297);
            this.buttonannulla.Name = "buttonannulla";
            this.buttonannulla.Size = new System.Drawing.Size(75, 23);
            this.buttonannulla.TabIndex = 13;
            this.buttonannulla.Text = "annulla";
            this.buttonannulla.UseVisualStyleBackColor = true;
            this.buttonannulla.Click += new System.EventHandler(this.buttonannulla_Click);
            // 
            // FormModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 363);
            this.Controls.Add(this.buttonannulla);
            this.Controls.Add(this.buttonsalva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrezzo);
            this.Controls.Add(this.textBoxQuantita);
            this.Controls.Add(this.textBoxCodiceProduttore);
            this.Controls.Add(this.textBoxProduttore);
            this.Controls.Add(this.textBoxCodiceFarnel);
            this.Controls.Add(this.textBoxDescrizione);
            this.Name = "FormModifica";
            this.Text = "FormModifica";
            this.Load += new System.EventHandler(this.FormModifica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDescrizione;
        private TextBox textBoxCodiceFarnel;
        private TextBox textBoxProduttore;
        private TextBox textBoxCodiceProduttore;
        private TextBox textBoxQuantita;
        private TextBox textBoxPrezzo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonsalva;
        private Button buttonannulla;
    }
}