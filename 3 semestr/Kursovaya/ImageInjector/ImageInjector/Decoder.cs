using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace ImageInjector
{
	/// Дешифровка
	public static class Decoder
	{
		public static Bitmap CurrentBitmap;

        public const int KEY = Encoder.KEY;
		
		public static string Decode(string fileOutput)
		{
			List<byte> rawData = new List<byte>();
			
            // Запись байтов картинки
			for(int offsetY = 0; offsetY < CurrentBitmap.Height; offsetY++)
			{
				for(int offsetX = 0; offsetX < CurrentBitmap.Width; offsetX++)
				{
					Color color = CurrentBitmap.GetPixel(offsetX, offsetY);
					
					rawData.Add(color.R);
					rawData.Add(color.G);
					rawData.Add(color.B);
				}
			}

			// Получение данных о расшифрованном файле из картинки
			byte[] dataForDecode = FormBytesArray(rawData.ToArray());

			// Чтение расшифрованного файла
			BinaryReader reader = new BinaryReader(new MemoryStream(dataForDecode));

			reader.BaseStream.Seek(0, SeekOrigin.Begin);
			
			int key = reader.ReadInt32();

            if (key == KEY)
			{
                string fileExtension = '.' + reader.ReadString();

                int size = reader.ReadInt32();

				byte[] data = new byte[size];

				reader.Read(data, 0, size);

                File.WriteAllBytes(fileOutput + fileExtension, data);

                return "Файл успешно расшифрован!\nПуть к файлу: " + fileOutput + fileExtension;
			}

            return "Неверный ключ файла!";
		}
		
        // Ф-ция извлечения младшего бита из байта картинки
		internal static bool GetBit(byte ent)
		{
			BitArray ba = new BitArray(new byte[] { ent });
			return ba.Get(0);
		}
		
        // Ф-ция извлечения младших бит из байтов картинки и создание байтов декодируемого файла из этих битов
		internal static byte[] FormBytesArray(byte[] rawData)
		{
			if(rawData.Length < 8)
                throw new Exception("Неверные данные для декодирования!");
			
			List<byte> data = new List<byte>();

            try
            {
                for (int index = 0; index < rawData.Length; index += 8)
                {
                    BitArray bits = new BitArray(new byte[1]);

                    for (int offset = 0; offset < 8; offset++)
                    {
                        bits.Set(offset, GetBit(rawData[index + offset]));
                    }

                    byte[] b = new byte[1];
                    bits.CopyTo(b, 0);

                    data.Add(b[0]);
                }
            }
            catch { }
			
			return data.ToArray();
		}
	}
}
