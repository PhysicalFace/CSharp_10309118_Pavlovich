using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageInjector
{
	/// Перевод в шифруемый вид
	public static class Encoder
	{
		public static Bitmap CurrentBitmap;
		
		public const int KEY = int.MinValue;

        public static string Encode(byte[] dataForEncode,  string dataExtension, string imageExtension, string fileOutput)
		{
			int size = dataForEncode.Length;

            // KEY > image extension > size bytes > data
			BinaryWriter dataB = new BinaryWriter(new MemoryStream());
			dataB.Write(KEY);
            dataB.Write(dataExtension);
			dataB.Write(size);
			dataB.Write(dataForEncode);

            int streamSize = sizeof(int) * 2 + sizeof(Int64) + size; // размер потока в байтах
			
			if(!IsNormalSize(streamSize)) return "Размер файла слишком большой! Проверьте соотношение:\n1/8 размера картинки >= размер файла!";
			
            // Запись байтов файла из потока в массив
			byte[] dataBytes = new byte[streamSize];
			
			dataB.Seek(0, SeekOrigin.Begin);
			dataB.BaseStream.Read(dataBytes, 0, streamSize);
			dataB.Close();
			
			bool[] data = EncodeToBits(ref dataBytes);

			int pen = 0;
		
            // Переопределение байтов в картинке
			for(int offsetY = 0; offsetY < CurrentBitmap.Height; offsetY++)
			{
				for(int offsetX = 0; offsetX < CurrentBitmap.Width; offsetX++)
				{
                    if (pen + 3 < streamSize * 8)
					{
						Color pixel = CurrentBitmap.GetPixel(offsetX, offsetY);

						byte Red = SetBit(pixel.R, data[pen]);
						byte Green = SetBit(pixel.G, data[pen + 1]);
						byte Blue = SetBit(pixel.B, data[pen + 2]);
						
						pen += 3;

                        switch (imageExtension)
                        {
                            case "bmp": CurrentBitmap.SetPixel(offsetX, offsetY, Color.FromArgb(Red, Green, Blue)); break;
                            case "png": CurrentBitmap.SetPixel(offsetX, offsetY, Color.FromArgb(pixel.A, Red, Green, Blue)); break;
                        }
					}
				}
			}
			
			CurrentBitmap.Save(fileOutput);
            CurrentBitmap.Dispose();

            return "Файл зашифрован успешно!\nПуть к файлу: " + fileOutput;
		}
        
        // Ф-ция перехода от байтов к битам файла
		internal static bool[] EncodeToBits(ref byte[] data)
		{
			List<bool> result = new List<bool>();
			
			BitArray bits = new BitArray(data);
			
			for(int i = 0; i < bits.Count; i++)
                result.Add(bits.Get(i));
			
			return result.ToArray();
		}
		
        // Ф-ция переопределения байта картинки
		internal static byte SetBit(byte ent, bool status)
		{
			BitArray ba = new BitArray( new byte[] { ent } );
			ba.Set(0, status);
			
			byte[] bytes = new byte[1];
		    ba.CopyTo(bytes, 0);
		    return bytes[0];
		}
		
        // Ф-ция проверки размера файла
		public static bool IsNormalSize(int size)
		{
			return ( size < ((CurrentBitmap.Width * CurrentBitmap.Height * 3) / 8) );
		}
	}
}
