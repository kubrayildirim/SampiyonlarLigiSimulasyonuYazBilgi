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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		int puan1;
		int puan2;
		int puan3;
		int puan4;

		Random rndm = new Random();

		private void Form3_Load(object sender, EventArgs e)
		{
			btnMacSonuc.Enabled = true;
			List<string> secilenTakimlar = new List<string>();
			List<string> takimlar = B.Bclass.ToList();

			RandomFikstur(rastgele, secilenTakimlar, takimlar);

			/*      1. HAFTA       */
			lbl1hafta1takim.Text = secilenTakimlar[0].ToString();
			lbl1hafta2takim.Text = secilenTakimlar[1].ToString();
			lbl1hafta3takim.Text = secilenTakimlar[2].ToString();
			lbl1hafta4takim.Text = secilenTakimlar[3].ToString();
			/*      2. HAFTA       */
			lbl2hafta1takim.Text = secilenTakimlar[0].ToString();
			lbl2hafta2takim.Text = secilenTakimlar[2].ToString();
			lbl2hafta3takim.Text = secilenTakimlar[1].ToString();
			lbl2hafta4takim.Text = secilenTakimlar[3].ToString();
			/*      3.HAFTA         */
			lbl3hafta1takim.Text = secilenTakimlar[0].ToString();
			lbl3hafta2takim.Text = secilenTakimlar[3].ToString();
			lbl3hafta3takim.Text = secilenTakimlar[1].ToString();
			lbl3hafta4takim.Text = secilenTakimlar[2].ToString();
			/*      4.HAFTA         */
			lbl4hafta1takim.Text = secilenTakimlar[1].ToString();
			lbl4hafta2takim.Text = secilenTakimlar[0].ToString();
			lbl4hafta3takim.Text = secilenTakimlar[3].ToString();
			lbl4hafta4takim.Text = secilenTakimlar[2].ToString();
			/*      5.HAFTA         */
			lbl5hafta1takim.Text = secilenTakimlar[2].ToString();
			lbl5hafta2takim.Text = secilenTakimlar[0].ToString();
			lbl5hafta3takim.Text = secilenTakimlar[3].ToString();
			lbl5hafta4takim.Text = secilenTakimlar[1].ToString();
			/*      6.HAFTA         */
			lbl6hafta1takim.Text = secilenTakimlar[3].ToString();
			lbl6hafta2takim.Text = secilenTakimlar[0].ToString();
			lbl6hafta3takim.Text = secilenTakimlar[2].ToString();
			lbl6hafta4takim.Text = secilenTakimlar[1].ToString();
		}

		private void btnMacSonuc_Click(object sender, EventArgs e)
		{
			btnMacSonuc.Enabled = false;

			lbl1haftasonuc1.Text = rndm.Next(0, 8).ToString();
			lbl1haftasonuc2.Text = rndm.Next(0, 8).ToString();
			lbl1haftasonuc3.Text = rndm.Next(0, 8).ToString();
			lbl1haftasonuc4.Text = rndm.Next(0, 8).ToString();

			MacSonucuPuanla(lbl1haftasonuc1, lbl1haftasonuc2, lbl1haftasonuc3, lbl1haftasonuc4, labelpuan1, labelpuan2, labelpuan3, labelpuan4);
		}

		List<int> puanListesi = new List<int>();
		private void MacSonucuPuanla(Label lbltakim1, Label lbltakim2, Label lbltakim3, Label lbltakim4, Label lblpuan1, Label lblpuan2, Label lblpuan3, Label lblpuan4)
		{
			if (Convert.ToInt32(lbltakim1.Text) > Convert.ToInt32(lbltakim2.Text))
			{
				puan1 += 3;

			}
			if (Convert.ToInt32(lbltakim1.Text) == Convert.ToInt32(lbltakim2.Text))
			{
				puan1 += 1;
				puan2 += 1;

			}
			if (Convert.ToInt32(lbltakim1.Text) < Convert.ToInt32(lbltakim2.Text))
			{
				puan2 += 3;
				//labelpuan2.Text = puan2.ToString();
			}
			if (Convert.ToInt32(lbltakim3.Text) > Convert.ToInt32(lbltakim4.Text))
			{
				puan3 += 3;

			}
			if (Convert.ToInt32(lbltakim3.Text) == Convert.ToInt32(lbltakim4.Text))
			{
				puan3 += 1;
				puan4 += 1;
				//lbl3.Text = puan1.ToString();
				//lbl4.Text = puan2.ToString();

			}

			if (Convert.ToInt32(lbltakim3.Text) < Convert.ToInt32(lbltakim4.Text))
			{
				puan4 += 3;
				//labelpuan2.Text = puan2.ToString();
			}
			puanListesi.Add(puan1);
			puanListesi.Add(puan2);
			puanListesi.Add(puan3);
			puanListesi.Add(puan4);

			//puanListesi = puanListesi.OrderByDescending(x => x).ToList();

			lblpuan1.Text = puan1.ToString();
			lblpuan2.Text = puan2.ToString();
			lblpuan3.Text = puan3.ToString();
			lblpuan4.Text = puan4.ToString();


			lbltakimadi1.Text = lbl1hafta1takim.Text;
			lbltakimadi2.Text = lbl1hafta2takim.Text;
			lbltakimadi3.Text = lbl1hafta3takim.Text;
			lbltakimadi4.Text = lbl1hafta4takim.Text;
		}


		Random rastgele = new Random();

		private static void RandomFikstur(Random rastgele, List<string> secilenTakimlar, List<string> takimlar)
		{
			for (int i = 0; i < takimlar.Count; i++)
			{
				string secilenTakim = takimlar[rastgele.Next(0, takimlar.Count)];
				if (secilenTakimlar.Contains(secilenTakim))
				{
					i--;
				}
				else
				{
					secilenTakimlar.Add(secilenTakim);
				}

			}
		}

		private void btn2haftaSonuc_Click(object sender, EventArgs e)
		{
			btn2haftaSonuc.Enabled = false;

			lbl2haftasonuc1.Text = rndm.Next(0, 8).ToString();
			lbl2haftasonuc2.Text = rndm.Next(0, 8).ToString();
			lbl2haftasonuc3.Text = rndm.Next(0, 8).ToString();
			lbl2haftasonuc4.Text = rndm.Next(0, 8).ToString();

			MacSonucuPuanla(lbl2haftasonuc1, lbl2haftasonuc2, lbl2haftasonuc3, lbl2haftasonuc4, labelpuan1, labelpuan3, labelpuan2, labelpuan4);
		}

		private void btn3haftaSonuc_Click(object sender, EventArgs e)
		{
			btn3haftaSonuc.Enabled = false;

			lbl3haftasonuc1.Text = rndm.Next(0, 8).ToString();
			lbl3haftasonuc2.Text = rndm.Next(0, 8).ToString();
			lbl3haftasonuc3.Text = rndm.Next(0, 8).ToString();
			lbl3haftasonuc4.Text = rndm.Next(0, 8).ToString();

			MacSonucuPuanla(lbl3haftasonuc1, lbl3haftasonuc2, lbl3haftasonuc3, lbl3haftasonuc4, labelpuan1, labelpuan4, labelpuan2, labelpuan3);
		}

		private void btn4haftaSonuc_Click(object sender, EventArgs e)
		{
			btn4haftaSonuc.Enabled = false;

			lbl4haftasonuc1.Text = rndm.Next(0, 8).ToString();
			lbl4haftasonuc2.Text = rndm.Next(0, 8).ToString();
			lbl4haftasonuc3.Text = rndm.Next(0, 8).ToString();
			lbl4haftasonuc4.Text = rndm.Next(0, 8).ToString();

			MacSonucuPuanla(lbl4haftasonuc1, lbl4haftasonuc2, lbl4haftasonuc3, lbl4haftasonuc4, labelpuan2, labelpuan1, labelpuan4, labelpuan3);
		}

		private void btn5haftaSonuc_Click(object sender, EventArgs e)
		{
			btn5haftaSonuc.Enabled = false;

			lbl5haftasonuc1.Text = rndm.Next(0, 8).ToString();
			lbl5haftasonuc2.Text = rndm.Next(0, 8).ToString();
			lbl5haftasonuc3.Text = rndm.Next(0, 8).ToString();
			lbl5haftasonuc4.Text = rndm.Next(0, 8).ToString();


			MacSonucuPuanla(lbl5haftasonuc1, lbl5haftasonuc2, lbl5haftasonuc3, lbl5haftasonuc4, labelpuan3, labelpuan1, labelpuan4, labelpuan2);
		}

		private void btn6haftaSonuc_Click(object sender, EventArgs e)
		{
			btn6haftaSonuc.Enabled = false;

			lbl6haftasonuc1.Text = rndm.Next(0, 8).ToString();
			lbl6haftasonuc2.Text = rndm.Next(0, 8).ToString();
			lbl6haftasonuc3.Text = rndm.Next(0, 8).ToString();
			lbl6haftasonuc4.Text = rndm.Next(0, 8).ToString();

			MacSonucuPuanla(lbl6haftasonuc1, lbl6haftasonuc2, lbl6haftasonuc3, lbl6haftasonuc4, labelpuan4, labelpuan1, labelpuan3, labelpuan2);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<int> sonPuanDurumu = new List<int>();
			SonOnAlti sonOnAlti1 = new SonOnAlti()
			{
				Puan = Convert.ToInt32(labelpuan1.Text),
				TakimAdi = lbltakimadi1.Text
			};
			SonOnAlti sonOnAlti2 = new SonOnAlti()
			{
				Puan = Convert.ToInt32(labelpuan2.Text),
				TakimAdi = lbltakimadi2.Text
			};
			SonOnAlti sonOnAlti3 = new SonOnAlti()
			{
				Puan = Convert.ToInt32(labelpuan2.Text),
				TakimAdi = lbltakimadi3.Text
			};
			SonOnAlti sonOnAlti4 = new SonOnAlti()
			{
				Puan = Convert.ToInt32(labelpuan4.Text),
				TakimAdi = lbltakimadi4.Text
			};
			sonPuanDurumu.Add(sonOnAlti1.Puan);
			sonPuanDurumu.Add(sonOnAlti2.Puan);
			sonPuanDurumu.Add(sonOnAlti3.Puan);
			sonPuanDurumu.Add(sonOnAlti4.Puan);
			sonPuanDurumu.Sort();

			sonPuanDurumu.Reverse();

			SonOnAlti cikan1 = new SonOnAlti();
			SonOnAlti cikan2 = new SonOnAlti();
			if (sonPuanDurumu[0] == sonOnAlti1.Puan)
			{
				cikan1.TakimAdi = sonOnAlti1.TakimAdi;

			}
			else if (sonPuanDurumu[0] == sonOnAlti2.Puan)
			{
				cikan1.TakimAdi = sonOnAlti2.TakimAdi;
			}
			else if (sonPuanDurumu[0] == sonOnAlti3.Puan)
			{
				cikan1.TakimAdi = sonOnAlti3.TakimAdi;
			}
			else if (sonPuanDurumu[0] == sonOnAlti4.Puan)
			{
				cikan1.TakimAdi = sonOnAlti4.TakimAdi;
			}




			if (sonPuanDurumu[1] == sonOnAlti1.Puan)
			{
				cikan2.TakimAdi = sonOnAlti1.TakimAdi;
			}
			else if (sonPuanDurumu[1] == sonOnAlti2.Puan)
			{
				cikan2.TakimAdi = sonOnAlti2.TakimAdi;
			}
			else if (sonPuanDurumu[1] == sonOnAlti3.Puan)
			{
				cikan2.TakimAdi = sonOnAlti3.TakimAdi;
			}
			else if (sonPuanDurumu[1] == sonOnAlti4.Puan)
			{
				cikan2.TakimAdi = sonOnAlti4.TakimAdi;
			}


			label1.Text = cikan1.TakimAdi;
			label2.Text = cikan2.TakimAdi;
		}
	}
}
