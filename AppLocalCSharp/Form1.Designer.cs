namespace AppLocalCSharp
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
            label1 = new Label();
            labelMatricula = new Label();
            labelCpf = new Label();
            labelNome = new Label();
            labelEndereco = new Label();
            textMatricula = new TextBox();
            textCpf = new TextBox();
            textNome = new TextBox();
            textEndereco = new TextBox();
            dataGridViewEmpregado = new DataGridView();
            buttonPesquisar = new Button();
            buttonSalvar = new Button();
            buttonExcluir = new Button();
            buttonLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpregado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de empregado";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Font = new Font("Segoe UI", 12F);
            labelMatricula.Location = new Point(12, 51);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(75, 21);
            labelMatricula.TabIndex = 1;
            labelMatricula.Text = "Matricula";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Font = new Font("Segoe UI", 12F);
            labelCpf.Location = new Point(12, 80);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(37, 21);
            labelCpf.TabIndex = 2;
            labelCpf.Text = "CPF";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F);
            labelNome.Location = new Point(12, 109);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(53, 21);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 12F);
            labelEndereco.Location = new Point(12, 138);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(74, 21);
            labelEndereco.TabIndex = 4;
            labelEndereco.Text = "Endereço";
            // 
            // textMatricula
            // 
            textMatricula.Location = new Point(92, 49);
            textMatricula.Name = "textMatricula";
            textMatricula.ReadOnly = true;
            textMatricula.Size = new Size(146, 23);
            textMatricula.TabIndex = 5;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(92, 78);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(146, 23);
            textCpf.TabIndex = 6;
            // 
            // textNome
            // 
            textNome.Location = new Point(92, 107);
            textNome.Name = "textNome";
            textNome.Size = new Size(324, 23);
            textNome.TabIndex = 7;
            // 
            // textEndereco
            // 
            textEndereco.Location = new Point(92, 136);
            textEndereco.Multiline = true;
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(324, 82);
            textEndereco.TabIndex = 8;
            // 
            // dataGridViewEmpregado
            // 
            dataGridViewEmpregado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpregado.Location = new Point(12, 224);
            dataGridViewEmpregado.Name = "dataGridViewEmpregado";
            dataGridViewEmpregado.Size = new Size(577, 150);
            dataGridViewEmpregado.TabIndex = 9;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(422, 106);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(167, 23);
            buttonPesquisar.TabIndex = 10;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(422, 135);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(167, 23);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(422, 166);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(167, 23);
            buttonExcluir.TabIndex = 12;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(422, 195);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(167, 23);
            buttonLimpar.TabIndex = 13;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 382);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonSalvar);
            Controls.Add(buttonPesquisar);
            Controls.Add(dataGridViewEmpregado);
            Controls.Add(textEndereco);
            Controls.Add(textNome);
            Controls.Add(textCpf);
            Controls.Add(textMatricula);
            Controls.Add(labelEndereco);
            Controls.Add(labelNome);
            Controls.Add(labelCpf);
            Controls.Add(labelMatricula);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FormLocal";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpregado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelMatricula;
        private Label labelCpf;
        private Label labelNome;
        private Label labelEndereco;
        private TextBox textMatricula;
        private TextBox textCpf;
        private TextBox textNome;
        private TextBox textEndereco;
        private DataGridView dataGridViewEmpregado;
        private Button buttonPesquisar;
        private Button buttonSalvar;
        private Button buttonExcluir;
        private Button buttonLimpar;
    }
}
