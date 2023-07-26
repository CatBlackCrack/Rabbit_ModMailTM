using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace ns10
{
	internal class Class78
	{
		public static Bitmap smethod_0(string string_0)
		{
			return new Bitmap(string_0);
		}

		public static Bitmap smethod_1(string string_0, string string_1, double double_0 = 0.9)
		{
			smethod_0(string_0);
			smethod_0(string_1);
			return smethod_1(string_0, string_1, double_0);
		}

		public static Bitmap smethod_2(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.9)
		{
			Image<Bgr, byte> image = new Image<Bgr, byte>(bitmap_0);
			Image<Bgr, byte> image2 = new Image<Bgr, byte>(bitmap_1);
			Image<Bgr, byte> image3 = image.Copy();
			using (Image<Gray, float> image4 = image.MatchTemplate(image2, TemplateMatchingType.CcoeffNormed))
			{
				image4.MinMax(out var _, out var maxValues, out var _, out var maxLocations);
				if (maxValues[0] > double_0)
				{
					Rectangle rect = new Rectangle(maxLocations[0], image2.Size);
					image3.Draw(rect, new Bgr(Color.Red), 2);
				}
				else
				{
					image3 = null;
				}
			}
			return image3?.ToBitmap();
		}

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr intptr_0);

		public static Point? smethod_3(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.9)
		{
			Point? result;
			if (bitmap_1 == null || bitmap_0 == null)
			{
				result = null;
			}
			else
			{
				if (bitmap_1.Width <= bitmap_0.Width && bitmap_1.Height <= bitmap_0.Height)
				{
					Image<Bgr, byte> image = new Image<Bgr, byte>(bitmap_0);
					Image<Bgr, byte> template = new Image<Bgr, byte>(bitmap_1);
					Point? result2 = null;
					using (Image<Gray, float> image2 = image.MatchTemplate(template, TemplateMatchingType.CcoeffNormed))
					{
						image2.MinMax(out var _, out var maxValues, out var _, out var maxLocations);
						if (maxValues[0] > double_0)
						{
							result2 = maxLocations[0];
						}
					}
					GC.Collect();
					GC.WaitForPendingFinalizers();
					return result2;
				}
				result = null;
			}
			return result;
		}

		public static List<Point> smethod_4(Bitmap bitmap_0, Bitmap bitmap_1, double double_0 = 0.9)
		{
			Image<Bgr, byte> image = new Image<Bgr, byte>(bitmap_0);
			Image<Bgr, byte> image2 = new Image<Bgr, byte>(bitmap_1);
			List<Point> list = new List<Point>();
			while (true)
			{
				Image<Gray, float> image3 = image.MatchTemplate(image2, TemplateMatchingType.CcoeffNormed);
				image3.MinMax(out var _, out var maxValues, out var _, out var maxLocations);
				if (!(maxValues[0] > double_0))
				{
					break;
				}
				Rectangle rect = new Rectangle(maxLocations[0], image2.Size);
				image.Draw(rect, new Bgr(Color.Blue), -1);
				list.Add(maxLocations[0]);
			}
			return list;
		}

		public static List<Point> smethod_5(Bitmap bitmap_0, Color color_0)
		{
			int num = color_0.ToArgb();
			List<Point> list = new List<Point>();
			try
			{
				for (int i = 0; i < bitmap_0.Width; i++)
				{
					for (int j = 0; j < bitmap_0.Height; j++)
					{
						if (num.Equals(bitmap_0.GetPixel(i, j).ToArgb()))
						{
							list.Add(new Point(i, j));
						}
					}
				}
			}
			finally
			{
				((IDisposable)bitmap_0)?.Dispose();
			}
			return list;
		}
	}
}
