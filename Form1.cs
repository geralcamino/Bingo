using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace Bingo
{
    public partial class Form1 : Form
    {
        // Constantes para generar los números aleatorios

        private const long multiplicador = 1664525;
        private const long incremento = 1013904223;
        private readonly long modulo = (long)Math.Pow(2, 32);
        private long semilla = 12345;

        // Listas para almacenar las imágenes y los números generados

        private readonly List<Image> imagePaths = new List<Image>();
        private readonly List<int> numerosGenerados = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ver que todas las imagenes se hayan mostrado 
            if (numerosGenerados.Count == imagePaths.Count)
            {
                MessageBox.Show("Todas las imágenes se han mostrado.");
                return;
            }

            int numeroAleatorio;
            do
            {
                // Generar un número aleatorio
                numeroAleatorio = generarNumero();
            } while (numerosGenerados.Contains(numeroAleatorio));

            // Agregar el número generado a la lista y mostrar la imagen correspondiente
            numerosGenerados.Add(numeroAleatorio);
            label1.Text = "Número Aleatorio: " + numeroAleatorio.ToString();
            pictureBox1.Image = imagePaths[numeroAleatorio];
        }

        private int generarNumero()
        {
            semilla = (multiplicador * semilla + incremento) % modulo;
            return (int)(semilla % imagePaths.Count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string baseUrl = "https://github.com/geralcamino/Bingo/raw/main/Img/";

            for (int i = 0; i <= 75; i++)
            {
                
                string imageUrl = baseUrl + i + ".png";
                Image imagen = LoadImageFromUrl(imageUrl);
                if (imagen != null)
                {
                    imagePaths.Add(imagen);
                }
                else
                {
                    MessageBox.Show("Error al cargar la imagen " + i + ".png desde la URL.");
                }
            }
        }

        private Image LoadImageFromUrl(string url)
        {
            try
            {
                // Usar WebClient para descargar datos desde la URL
                using (WebClient client = new WebClient())
                {
                    byte[] data = client.DownloadData(url);
                    // Usar MemoryStream para crear una imagen desde los datos descargados
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen desde la URL: " + ex.Message);
                return null;
            }
        }
    }
}
