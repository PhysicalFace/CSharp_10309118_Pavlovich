using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ImageInjector
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
            InitializeComponent();
		}
		
		string fileImage1 = "", fileImage2 = "";
		
        // Выбор картинки для шифрования
		void SelFile1BtnClick(object sender, EventArgs e)
		{
			OpenFileDialog fb = new OpenFileDialog();
        	fb.FilterIndex = 1;
            fb.Filter = "png|*.png|bmp|*.bmp";
            
        	if(fb.ShowDialog() == DialogResult.OK)
        	{	
        		pictureBox1.Image = Image.FromFile(fb.FileName);
        		fileImage1 = fb.FileName;
        	}
		}

        // Выбор картинки для дешифрования
		void SelFile2BtnClick(object sender, EventArgs e)
		{
			OpenFileDialog fb = new OpenFileDialog();
        	fb.FilterIndex = 1;
            fb.Filter = "png|*.png|bmp|*.bmp";
            
            if(fb.ShowDialog() == DialogResult.OK) 
            {
            	pictureBox2.Image = Image.FromFile(fb.FileName);
            	fileImage2 = fb.FileName;
            }
		}
		
        // Процесс шифрования
		void SelFileForEndodeClick(object sender, EventArgs e)
		{
			if(pictureBox1.Image != null)
			{
				OpenFileDialog fb = new OpenFileDialog();
	            
	            if(fb.ShowDialog() == DialogResult.OK)
	            {
                    Random rand = new Random();

                    string s = GenerateRandomKey(
                        "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm",
                        rand.Next(16, 32)
                        );

                    Encoder.KEY = s;
	            	Encoder.CurrentBitmap = new Bitmap(fileImage1);
	            	
	            	string result = Encoder.Encode( File.ReadAllBytes(fb.FileName),
                                        fb.FileName.Substring(fb.FileName.LastIndexOf('.') + 1),
                                        fileImage1.Substring(fileImage1.LastIndexOf('.') + 1),
	            	              		Path.GetDirectoryName(fileImage1) + Path.DirectorySeparatorChar 
	            	              			+ "output" + rand.Next(1000).ToString() + '_' + Path.GetFileName(fileImage1) );

                    if (result != "Размер файла слишком большой! Проверьте соотношение:\n1/8 размера картинки >= размер файла!")
                        textBoxEncoded.Text = s;
	            	
	            	MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fileImage1 = "";
                    pictureBox1.Image = null;
	            }
			}
            else MessageBox.Show("Изображение для шифрования не загружено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
        // Процесс дешифрования
		void SaveFileDecodedClick(object sender, EventArgs e)
		{
			if(pictureBox2.Image != null)
			{
				SaveFileDialog sd = new SaveFileDialog();

                if (sd.ShowDialog() == DialogResult.OK)
                {
                    Decoder.CurrentBitmap = new Bitmap(fileImage2);

                    Decoder.KEY = textBoxForDecode.Text;

                    string result = Decoder.Decode(sd.FileName);

                    MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fileImage2 = "";
                    pictureBox2.Image = null;
                    textBoxForDecode.Text = "";
                }
			}
            else MessageBox.Show("Изображение для расшифровки не загружено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

        // Ф-ция генерации случайной строки
        private string GenerateRandomKey(string Alphabet, int Length)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(Length - 1);

            for (int i = 0; i < Length; i++)
            {
                int Position = rnd.Next(0, Alphabet.Length - 1);
                sb.Append(Alphabet[Position]);
            }

            return sb.ToString();
        }
	}
}
