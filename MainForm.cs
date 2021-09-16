using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Financeira
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			String nome;
			nome = Convert.ToString(TxtNome.Text);
			double valTot, parcela=0, valJuros=0;
			valTot = Convert.ToDouble(TxtValorEmp.Text);
			
			if (CmbPlano.SelectedIndex == 0)
				valJuros = valTot * 0.2;
				parcela = (valTot + valJuros) / 12;
				TxtValorJuros.Text = valJuros.ToString("C");
				TxtValorParcela.Text = parcela.ToString("C");
				
			if (CmbPlano.SelectedIndex == 1)
				valJuros = valTot * 0.3;
				parcela = (valTot + valJuros) / 12;
				TxtValorJuros.Text = valJuros.ToString("C");
				TxtValorParcela.Text = parcela.ToString("C");
				
			if (CmbPlano.SelectedIndex == 2)
				valJuros = valTot * 0.45;
				parcela = (valTot + valJuros) / 12;
				TxtValorJuros.Text = valJuros.ToString("C");
				TxtValorParcela.Text = parcela.ToString("C");	
				
			if (CmbPlano.SelectedIndex == 3)
				valJuros = valTot * 0.8;
				parcela = (valTot + valJuros) / 12;
				TxtValorJuros.Text = valJuros.ToString("C");
				TxtValorParcela.Text = parcela.ToString("C");
		}
		
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			TxtNome.Clear();
			CmbPlano.SelectedIndex = -1;
			CmbPlano.Text = "Plano";
			TxtValorEmp.Clear();
			TxtValorJuros.Clear();
			TxtValorParcela.Clear();
		}
		
	}
}
