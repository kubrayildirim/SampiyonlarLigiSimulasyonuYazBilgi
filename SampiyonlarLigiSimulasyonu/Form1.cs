using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampiyonlarLigiSimulasyonu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		List<Takim> takimlar;

		List<ListBox> torbalar = new List<ListBox>();
		List<ListBox> gruplar = new List<ListBox>();

		private void Form1_Load(object sender, EventArgs e)
		{
			button2.Enabled = true;
			button1.Enabled = false;

			Takim yeni = null;
			takimlar = new List<Takim>();

			yeni = new Takim("Bayern Munich", "Almanya");
			takimlar.Add(yeni);
			yeni = new Takim("Sevilla", "İspanya");
			takimlar.Add(yeni);
			yeni = new Takim("Real Madrid", "İspanya");
			takimlar.Add(yeni);
			yeni = new Takim("Liverpool", "İngiltere");
			takimlar.Add(yeni);
			yeni = new Takim("Juventus", "İtalya");
			takimlar.Add(yeni);
			yeni = new Takim("Paris Saint-Germain", "Fransa");
			takimlar.Add(yeni);
			yeni = new Takim("Zenit", "Rusya");
			takimlar.Add(yeni);
			yeni = new Takim("Porto", "Portekiz");
			takimlar.Add(yeni);


			yeni = new Takim("Barcelona", " İspanya");
			takimlar.Add(yeni);
			yeni = new Takim("Atlético Madrid", "İspanya");
			takimlar.Add(yeni);
			yeni = new Takim("Manchester City", "İngiltere");
			takimlar.Add(yeni);
			yeni = new Takim("Manchester United", "İngiltere");
			takimlar.Add(yeni);
			yeni = new Takim("Borussia Dortmund ", "Almanya");
			takimlar.Add(yeni);
			yeni = new Takim("Shakhtar Donetsk", "Ukrayna");
			takimlar.Add(yeni);
			yeni = new Takim("Chelsea", "İngiltere");
			takimlar.Add(yeni);
			yeni = new Takim("Ajax", "Hollanda");
			takimlar.Add(yeni);


			yeni = new Takim("Dynamo Kiev", "Ukrayna");
			takimlar.Add(yeni);
			yeni = new Takim("Red Bull Salzburg", " Almanya");
			takimlar.Add(yeni);
			yeni = new Takim("RB Leipzig", "Almanya");
			takimlar.Add(yeni);
			yeni = new Takim("Internazionale", " İtalya");
			takimlar.Add(yeni);
			yeni = new Takim("Olympiacos", " Yunanistan");
			takimlar.Add(yeni);
			yeni = new Takim("Lazio", "İtalya");
			takimlar.Add(yeni);
			yeni = new Takim("Krasnodar", " Rusya");
			takimlar.Add(yeni);
			yeni = new Takim("Atalanta", "İtalya");
			takimlar.Add(yeni);


			yeni = new Takim("Lokomotiv Moskova", "Rusya");
			takimlar.Add(yeni);
			yeni = new Takim("Marseille", " Fransa");
			takimlar.Add(yeni);
			yeni = new Takim("Club Brugge", "Belçika");
			takimlar.Add(yeni);
			yeni = new Takim("Bor.Mönchengladbach", "Almanya");
			takimlar.Add(yeni);
			yeni = new Takim("Galatasaray", "Türkiye");
			takimlar.Add(yeni);
			yeni = new Takim("Midtjylland", "Danimarka");
			takimlar.Add(yeni);
			yeni = new Takim("Rennes", "Fransa");
			takimlar.Add(yeni);
			yeni = new Takim("Ferencváros", "Macaristan");
			takimlar.Add(yeni);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			button2.Enabled = false;
			button1.Enabled = true;
			Random rastgele = new Random();
			List<int> secilenTakimlar = new List<int>();
			for(int i = 0; i < takimlar.Count; i++)
			{
				int secilenTakim = rastgele.Next(0, takimlar.Count);
				if (secilenTakimlar.Contains(secilenTakim))
				{
					i--;
				}
				else 
				{
					secilenTakimlar.Add(secilenTakim); 
				}
				
			}
			for (int i = 0; i < secilenTakimlar.Count; i++)
			{
				if (i < 8)
				{
					Torba1.Items.Add(takimlar[secilenTakimlar[i]]);
				}
				else if (i<16)
				{
					Torba2.Items.Add(takimlar[secilenTakimlar[i]]);
				}
				else if (i < 24)
				{
					Torba3.Items.Add(takimlar[secilenTakimlar[i]]);
				}
				else
				{
					Torba4.Items.Add(takimlar[secilenTakimlar[i]]);
				}
			}
			torbalar.Add(Torba1);
			
			
			
			torbalar.Add(Torba2);
			
			torbalar.Add(Torba3);
			torbalar.Add(Torba4);

			gruplar.Add(listBox5);
			gruplar.Add(listBox6);
			gruplar.Add(listBox7);
			gruplar.Add(listBox8);
			gruplar.Add(listBox9);
			gruplar.Add(listBox10);
			gruplar.Add(listBox11);
			gruplar.Add(listBox12);
			
			
		}

		private void button1_Click(object sender, EventArgs e)
        {
			button1.Enabled = false;

            Random rastgele = new Random();
            List<int> secilenTakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilenTakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilenTakim = rastgele.Next(0, takimlar.Count / 4);
                    if (secilenTakimlar.Contains(secilenTakim))
                    {
                        i--;
                    }

                    else
                    {
                        secilenTakimlar.Add(secilenTakim);
                    }
                }

                bool aynıulkedentakimvar = false;
                for (int k = 0; k < 8; k++)
                {
                    aynıulkedentakimvar = Aynıulkedentakimvarmı(gruplar[k], torbalar[j].Items[secilenTakimlar[k]] as Takim);
                    if (aynıulkedentakimvar)
                        break;
                }
                if (!aynıulkedentakimvar)
                {
                    listBox5.Items.Add(torbalar[j].Items[secilenTakimlar[0]] as Takim);
                    //A.Aclass = secilenTakimlar[0];
                    listBox6.Items.Add(torbalar[j].Items[secilenTakimlar[1]] as Takim);
                    listBox7.Items.Add(torbalar[j].Items[secilenTakimlar[2]] as Takim);
                    listBox8.Items.Add(torbalar[j].Items[secilenTakimlar[3]] as Takim);
                    listBox9.Items.Add(torbalar[j].Items[secilenTakimlar[4]] as Takim);
                    listBox10.Items.Add(torbalar[j].Items[secilenTakimlar[5]] as Takim);
                    listBox11.Items.Add(torbalar[j].Items[secilenTakimlar[6]] as Takim);
                    listBox12.Items.Add(torbalar[j].Items[secilenTakimlar[7]] as Takim);
                }
                else
                {
                    j--;
                }

            }
            AClassaEkle(listBox5);
            BClassaEkle(listBox6);
            CClassaEkle(listBox7);
            DClassaEkle(listBox8);
			EClassaEkle(listBox9);
			FClassaEkle(listBox10);
			GClassaEkle(listBox11);
			HClassaEkle(listBox12);
			//MessageBox.Show(A.Aclass[0]);
		}
		private void HClassaEkle(ListBox listBox)
		{
			foreach (var item in listBox.Items)
			{
				H.Hclass.Add(item.ToString());
			}
		}
		private void GClassaEkle(ListBox listBox)
		{
			foreach (var item in listBox.Items)
			{
				G.Gclass.Add(item.ToString());
			}
		}
		private void FClassaEkle(ListBox listBox)
		{
			foreach (var item in listBox.Items)
			{
				F.Fclass.Add(item.ToString());
			}
		}

		private void EClassaEkle(ListBox listBox)
		{
			foreach (var item in listBox.Items)
			{
				E.Eclass.Add(item.ToString());
			}
		}
		private void DClassaEkle(ListBox listBox)
        {
			foreach (var item in listBox.Items)
			{
				D.Dclass.Add(item.ToString());
			}
		}

        private void CClassaEkle(ListBox listBox)
        {
			foreach (var item in listBox.Items)
			{
				C.Cclass.Add(item.ToString());
			}
		}

        private void BClassaEkle(ListBox listBox)
        {
			foreach (var item in listBox.Items)
			{
				B.Bclass.Add(item.ToString());
			}
		}

        private void AClassaEkle(ListBox listBox)
        {
            foreach (var item in listBox.Items)
            {
                A.Aclass.Add(item.ToString());
            }
        }
	
		private bool Aynıulkedentakimvarmı(ListBox grup,Takim takim)
		{
			bool durum = false;
			for (int i = 0; i < grup.Items.Count; i++)
			{
				Takim grupTakim = grup.Items[i] as Takim;
				if (grupTakim.TakimUlke == takim.TakimUlke)
				{

					durum = true;

					break;
				}
			}
			return durum;
		
		}

		private void listbox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();

		}

		private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
			frm3.Show();
		}

		private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form4 frm4 = new Form4();
			frm4.Show();
		}

		private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form5 frm5 = new Form5();
			frm5.Show();
		}

		private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form6 frm6 = new Form6();
			frm6.Show();
		}

		private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form7 frm7 = new Form7();
			frm7.Show();
		}

		private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form8 frm8 = new Form8();
			frm8.Show();
		}

		private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
		{
			Form9 frm9 = new Form9();
			frm9.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.Show();
		}
	}
}
