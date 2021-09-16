/*
 * Created by SharpDevelop.
 * User: uJão
 * Date: 30/06/2021
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Financeira
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxtNome = new System.Windows.Forms.TextBox();
			this.CmbPlano = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtValorEmp = new System.Windows.Forms.TextBox();
			this.TxtValorJuros = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtValorParcela = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.BtnNovo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtNome
			// 
			this.TxtNome.Location = new System.Drawing.Point(30, 50);
			this.TxtNome.Name = "TxtNome";
			this.TxtNome.Size = new System.Drawing.Size(280, 20);
			this.TxtNome.TabIndex = 0;
			// 
			// CmbPlano
			// 
			this.CmbPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CmbPlano.FormattingEnabled = true;
			this.CmbPlano.Items.AddRange(new object[] {
									"12 meses",
									"18 meses",
									"24 meses",
									"36 meses"});
			this.CmbPlano.Location = new System.Drawing.Point(361, 47);
			this.CmbPlano.Name = "CmbPlano";
			this.CmbPlano.Size = new System.Drawing.Size(200, 23);
			this.CmbPlano.TabIndex = 2;
			this.CmbPlano.Text = "Plano";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Informe nome do cliente";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(280, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Informe valor desejado para empréstimo";
			// 
			// TxtValorEmp
			// 
			this.TxtValorEmp.Location = new System.Drawing.Point(30, 130);
			this.TxtValorEmp.Name = "TxtValorEmp";
			this.TxtValorEmp.Size = new System.Drawing.Size(120, 20);
			this.TxtValorEmp.TabIndex = 4;
			// 
			// TxtValorJuros
			// 
			this.TxtValorJuros.Location = new System.Drawing.Point(30, 250);
			this.TxtValorJuros.Name = "TxtValorJuros";
			this.TxtValorJuros.Size = new System.Drawing.Size(120, 20);
			this.TxtValorJuros.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor dos juros";
			// 
			// TxtValorParcela
			// 
			this.TxtValorParcela.Location = new System.Drawing.Point(210, 250);
			this.TxtValorParcela.Name = "TxtValorParcela";
			this.TxtValorParcela.Size = new System.Drawing.Size(145, 20);
			this.TxtValorParcela.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(210, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "Valor de cada parcela";
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCalcular.Location = new System.Drawing.Point(480, 213);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(120, 25);
			this.BtnCalcular.TabIndex = 9;
			this.BtnCalcular.Text = "Calcular Valores";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// BtnNovo
			// 
			this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnNovo.Location = new System.Drawing.Point(480, 245);
			this.BtnNovo.Name = "BtnNovo";
			this.BtnNovo.Size = new System.Drawing.Size(119, 25);
			this.BtnNovo.TabIndex = 10;
			this.BtnNovo.Text = "Novo Cliente";
			this.BtnNovo.UseVisualStyleBackColor = true;
			this.BtnNovo.Click += new System.EventHandler(this.BtnNovoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(614, 292);
			this.Controls.Add(this.BtnNovo);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TxtValorParcela);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtValorJuros);
			this.Controls.Add(this.TxtValorEmp);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CmbPlano);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtNome);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Financeira X";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BtnNovo;
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtValorParcela;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtValorJuros;
		private System.Windows.Forms.TextBox TxtValorEmp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CmbPlano;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtNome;
	}
}
