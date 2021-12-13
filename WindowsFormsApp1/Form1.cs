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
    public partial class Form1 : Form
    {

        private PictureBox[] tabla;
        Random rand = new Random();
        Stack<int> CartasAnteriores = new Stack<int>();
        int il = 0;
        public Form1()
        {
            InitializeComponent();
            tabla = new PictureBox[25];
            InicializarTabla();
        }
        private void InicializarTabla()
        {
            int r = 0, c = 0;

            int[] cartas = new int[54];

            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = i + 1;
            }
            
            int a, aux;
            for (int i = 0; i < cartas.Length; i++)
            {
                a = rand.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;
            }
            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = new PictureBox();
                tabla[i].Location = new System.Drawing.Point(31 + (c * 80), 12 + (r * 105));
                tabla[i].Name = "picTabla" + i;
                tabla[i].Size = new System.Drawing.Size(71, 97);
                tabla[i].TabIndex = 0 + i;
                tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tabla[i].TabStop = false;
                tabla[i].Image = Image.FromFile(@"" + (cartas[i]) + ".jpg");
                this.Controls.Add(tabla[i]);
                c++;
                if (c == 5)
                {
                    r++;
                    c = 0;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuenas_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"nombre del archivo y extención");
            player.Play();
        }

        private void btnSCarta_Click(object sender, EventArgs e)
        {

        }

        private void Barajear_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(85, 105);
            this.listView1.LargeImageList=this.imageList1;

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            label1.Text =(54-CartasAnteriores.Count()).ToString();
            bool B = false;
            if (CartasAnteriores.Count()==54)
            {
                B = true;
                MessageBox.Show("No hay cartas", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            while (!B)
            {
                int num = rand.Next(1, 54);
            
            if (!CartasAnteriores.Contains(num))
            {
                pbCarta.Image = Image.FromFile(@"" + num + ".jpg");
                pbCarta.SizeMode = PictureBoxSizeMode.StretchImage;
                CartasAnteriores.Push(num);
                this.imageList1.Images.Add(Image.FromFile(@"" + num + ".jpg"));
                ListViewItem item=new ListViewItem();
                item.ImageIndex = il;
                this.listView1.Items.Add(item);
                B = true;
                    il++;
            }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CartasAnteriores.Clear();
            imageList1.Images.Clear();
            listView1.Items.Clear();
            pbCarta.Image = null;
            il = 0;
            label1.Text = "";
        }
    }
}
