using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.Emit;


namespace ednevnik
{
    public partial class Glavna : Form
    {
        DataTable tabela;
        public Glavna()
        {
            InitializeComponent();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            string username = textBox1.Text;
            SqlCommand naredba = new SqlCommand($"Select * FROM Osoba WHERE email = '{username}'", veza);
            SqlDataAdapter adapt = new SqlDataAdapter(naredba);
            DataTable tabela = new DataTable();
            adapt.Fill(tabela);
            if (tabela.Rows.Count == 1)
            {
                if (String.Compare(tabela.Rows[0]["pass"].ToString(), textBox2.Text) == 0)
                {
                    MessageBox.Show("Добродошли!");
                    this.Hide();
                    Osoba main_form = new Osoba();
                    main_form.Show();
                }
                else MessageBox.Show("Лоша лозинка.");
            }
            else MessageBox.Show("Непостојећи username.");
        }
    }
}
