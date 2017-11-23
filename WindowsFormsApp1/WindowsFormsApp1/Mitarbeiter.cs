using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Mitarbeiter : Form
    {
        public frm_Mitarbeiter()
        {
            InitializeComponent();
        }

        private void frm_Mitarbeiter_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_SparAus_Click(object sender, EventArgs e)
        {
            Spar_Aus SA = new Spar_Aus();
            this.Hide();
            SA.ShowDialog();
            this.Close();
        }

        private void btn_KontoEin_Click(object sender, EventArgs e)
        {
            Konto_Ein KE = new Konto_Ein();
            this.Hide();
            KE.ShowDialog();
            this.Close();
        }

        private void btn_KontoAus_Click(object sender, EventArgs e)
        {
            Konto_Aus KA = new Konto_Aus();
            this.Hide();
            KA.ShowDialog();
            this.Close();
        }

        private void btn_SparEin_Click(object sender, EventArgs e)
        {
            Spar_Ein SE = new Spar_Ein();
            this.Hide();
            SE.ShowDialog();
            this.Close();
        }

        private void btn_Geldwechsel_Click(object sender, EventArgs e)
        {
            Geldwechsel G = new Geldwechsel();
            this.Hide();
            G.ShowDialog();
            this.Close();
        }

        private void btn_Scheck_Click(object sender, EventArgs e)
        {
            Scheck S = new Scheck();
            this.Hide();
            S.ShowDialog();
            this.Close();
        }

        private void btn_Edelmetalle_Click(object sender, EventArgs e)
        {
            Edelmetalle E = new Edelmetalle();
            this.Hide();
            E.ShowDialog();
            this.Close();
        }

        private void btn_Valuten_Click(object sender, EventArgs e)
        {
            Valuten V = new Valuten();
            this.Hide();
            V.ShowDialog();
            this.Close();
        }

        private void btn_AKT_Click(object sender, EventArgs e)
        {
            AKT AKT = new AKT();
            this.Hide();
            AKT.ShowDialog();
            this.Close();
        }

        private void btn_Kassaaufnahme_Click(object sender, EventArgs e)
        {
            Kassaaufnahme K = new Kassaaufnahme();
            this.Hide();
            K.ShowDialog();
            this.Close();
        }

        private void btn_Beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
