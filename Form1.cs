using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Bingo
{
    public partial class Form1 : Form
    {
        private const long a = 1664525; // Multiplicador
        private const long c = 1013904223; // Incremento
        private long m = (long)Math.Pow(2, 32); // Módulo (2^32)
        private long seed = 12345;

        private List<Image> imagePaths = new List<Image>();
        private List<int> numerosGenerados = new List<int>();


        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (numerosGenerados.Count == imagePaths.Count)
            {
                MessageBox.Show("Todas las imágenes se han mostrado.");
                return;
            }

            int numeroAleatorio;
            do
            {
                numeroAleatorio = generarNumero();
            } while (numerosGenerados.Contains(numeroAleatorio));

            numerosGenerados.Add(numeroAleatorio);
            label1.Text = "Número Aleatorio: " + numeroAleatorio.ToString();
            pictureBox1.Image = imagePaths[numeroAleatorio];

        }
        private int generarNumero()
        {
            seed = (a * seed + c) % m;
            return (int)(seed % imagePaths.Count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image imagen0 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\0.png");
            Image imagen1 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\1.png");
            Image imagen2 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\2.png");
            Image imagen3 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\3.png");
            Image imagen4 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\4.png");
            Image imagen5 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\5.png");
            Image imagen6 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\6.png");
            Image imagen7 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\7.png");
            Image imagen8 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\8.png");
            Image imagen9 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\9.png");
            Image imagen10 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\10.png");
            Image imagen11 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\11.png");
            Image imagen12 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\12.png");
            Image imagen13 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\13.png");
            Image imagen14 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\14.png");
            Image imagen15 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\15.png");
            Image imagen16 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\16.png");
            Image imagen17 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\17.png");
            Image imagen18 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\18.png");
            Image imagen19 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\19.png");
            Image imagen20 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\20.png");
            Image imagen21 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\21.png");
            Image imagen22 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\22.png");
            Image imagen23 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\23.png");
            Image imagen24 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\24.png");
            Image imagen25 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\25.png");
            Image imagen26 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\26.png");
            Image imagen27 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\27.png");
            Image imagen28 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\28.png");
            Image imagen29 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\29.png");
            Image imagen30 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\30.png");
            Image imagen31 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\31.png");
            Image imagen32 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\32.png");
            Image imagen33 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\33.png");
            Image imagen34 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\34.png");
            Image imagen35 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\35.png");
            Image imagen36 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\36.png");
            Image imagen37 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\37.png");
            Image imagen38 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\38.png");
            Image imagen39 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\39.png");
            Image imagen40 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\40.png");
            Image imagen41 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\41.png");
            Image imagen42 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\42.png");
            Image imagen43 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\43.png");
            Image imagen44 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\44.png");
            Image imagen45 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\45.png");
            Image imagen46 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\46.png");
            Image imagen47 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\47.png");
            Image imagen48 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\48.png");
            Image imagen49 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\49.png");
            Image imagen50 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\50.png");
            Image imagen51 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\51.png");
            Image imagen52 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\52.png");
            Image imagen53 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\53.png");
            Image imagen54 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\54.png");
            Image imagen55 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\55.png");
            Image imagen56 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\56.png");
            Image imagen57 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\57.png");
            Image imagen58 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\58.png");
            Image imagen59 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\59.png");
            Image imagen60 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\60.png");
            Image imagen61 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\61.png");
            Image imagen62 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\62.png");
            Image imagen63 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\63.png");
            Image imagen64 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\64.png");
            Image imagen65 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\65.png");
            Image imagen66 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\66.png");
            Image imagen67 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\67.png");
            Image imagen68 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\68.png");
            Image imagen69 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\69.png");
            Image imagen70 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\70.png");
            Image imagen71 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\71.png");
            Image imagen72 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\72.png");
            Image imagen73 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\73.png");
            Image imagen74 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\74.png");
            Image imagen75 = Image.FromFile("C:\\Users\\angie\\source\\repos\\Bingo\\Bingo\\Img\\75.png");
            imagePaths.Add(imagen0);
            imagePaths.Add(imagen1);
            imagePaths.Add(imagen2);
            imagePaths.Add(imagen3);
            imagePaths.Add(imagen4);
            imagePaths.Add(imagen5);
            imagePaths.Add(imagen6);
            imagePaths.Add(imagen7);
            imagePaths.Add(imagen8);
            imagePaths.Add(imagen9);
            imagePaths.Add(imagen10);
            imagePaths.Add(imagen11);
            imagePaths.Add(imagen12);
            imagePaths.Add(imagen13);
            imagePaths.Add(imagen14);
            imagePaths.Add(imagen15);
            imagePaths.Add(imagen16);
            imagePaths.Add(imagen17);
            imagePaths.Add(imagen18);
            imagePaths.Add(imagen19);
            imagePaths.Add(imagen20);
            imagePaths.Add(imagen21);
            imagePaths.Add(imagen22);
            imagePaths.Add(imagen23);
            imagePaths.Add(imagen24);
            imagePaths.Add(imagen25);
            imagePaths.Add(imagen26);
            imagePaths.Add(imagen27);
            imagePaths.Add(imagen28);
            imagePaths.Add(imagen29);
            imagePaths.Add(imagen30);
            imagePaths.Add(imagen31);
            imagePaths.Add(imagen32);
            imagePaths.Add(imagen33);
            imagePaths.Add(imagen34);
            imagePaths.Add(imagen35);
            imagePaths.Add(imagen36);
            imagePaths.Add(imagen37);
            imagePaths.Add(imagen38);
            imagePaths.Add(imagen39);
            imagePaths.Add(imagen40);
            imagePaths.Add(imagen41);
            imagePaths.Add(imagen42);
            imagePaths.Add(imagen43);
            imagePaths.Add(imagen44);
            imagePaths.Add(imagen45);
            imagePaths.Add(imagen46);
            imagePaths.Add(imagen47);
            imagePaths.Add(imagen48);
            imagePaths.Add(imagen49);
            imagePaths.Add(imagen50);
            imagePaths.Add(imagen51);
            imagePaths.Add(imagen52);
            imagePaths.Add(imagen53);
            imagePaths.Add(imagen54);
            imagePaths.Add(imagen55);
            imagePaths.Add(imagen56);
            imagePaths.Add(imagen57);
            imagePaths.Add(imagen58);
            imagePaths.Add(imagen59);
            imagePaths.Add(imagen60);
            imagePaths.Add(imagen61);
            imagePaths.Add(imagen62);
            imagePaths.Add(imagen63);
            imagePaths.Add(imagen64);
            imagePaths.Add(imagen65);
            imagePaths.Add(imagen66);
            imagePaths.Add(imagen67);
            imagePaths.Add(imagen68);
            imagePaths.Add(imagen69);
            imagePaths.Add(imagen70);
            imagePaths.Add(imagen71);
            imagePaths.Add(imagen72);
            imagePaths.Add(imagen73);
            imagePaths.Add(imagen74);
            imagePaths.Add(imagen75);
        }

  
        

       
    }
    
}
