﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace SLRD_ClientApp.Class_flies
{
    public class TicketBarcodeCreator
    {
        private static readonly string[] Code128Patterns = {
            "11011001100", "11001101100", "11001100110", "10010011000", "10010001100", "10001001100", "10011001000", "10011000100",
            "10001100100", "11001001000", "11001000100", "11000100100", "10110011100", "10011011100", "10011001110", "10111001100",
            "10011101100", "10011100110", "11001110010", "11001011100", "11001001110", "11011100100", "11001110100", "11101101110",
            "11101001100", "11100101100", "11100100110", "11101100100", "11100110100", "11100110010", "11011011000", "11011000110",
            "11000110110", "10100011000", "10001011000", "10001000110", "10110001000", "10001101000", "10001100010", "11010001000",
            "11000101000", "11000100010", "10110111000", "10110001110", "10001101110", "10111011000", "10111000110", "10001110110",
            "11101110110", "11010001110", "11000101110", "11011101000", "11011100010", "11011101110", "11101011000", "11101000110",
            "11100010110", "11101101000", "11101100010", "11100011010", "11101111010", "11001000010", "11110001010", "10100110000",
            "10100001100", "10010110000", "10010000110", "10000101100", "10000100110", "10110010000", "10110000100", "10011010000",
            "10011000010", "10000110100", "10000110010", "11000010010", "11001010000", "11110111010", "11000010100", "10001111010",
            "10100111100", "10010111100", "10010011110", "10111100100", "10011110100", "10011110010", "11110100100", "11110010100",
            "11110010010", "11011011110", "11011110110", "11110110110", "10101111000", "10100011110", "10001011110", "10111101000",
            "10111100010", "11110101000", "11110100010", "10111011110", "10111101110", "11101011110", "11110101110"
        };

        private static readonly Dictionary<char, int> Code128CharToPatternIndex;

        static TicketBarcodeCreator()
        {
            Code128CharToPatternIndex = new Dictionary<char, int>();
            for (int i = 0; i <= 127; i++)
            {
                Code128CharToPatternIndex.Add((char)i, i);
            }
        }

        public static Bitmap GenerateCode128Barcode(string data)
        {
            try
            {
                if (string.IsNullOrEmpty(data)) throw new ArgumentException("Data is null or empty");

                string startCode = "11010010000";
                StringBuilder barcodePattern = new StringBuilder(startCode);

                foreach (char c in data)
                {
                    if (!Code128CharToPatternIndex.ContainsKey(c)) throw new ArgumentException($"Data contains unsupported character: {c}");

                    int patternIndex = Code128CharToPatternIndex[c];
                    barcodePattern.Append(Code128Patterns[patternIndex]);
                }

                barcodePattern.Append("1100011101011");

                return RenderBarcode(barcodePattern.ToString());
            }
            catch (Exception ex)
            {
                // Replace this with your actual logging method
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        private static Bitmap RenderBarcode(string pattern)
        {
            int width = pattern.Length * 2;
            int height = 100;
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                int x = 0;

                foreach (char bit in pattern)
                {
                    if (bit == '1')
                    {
                        graphics.FillRectangle(Brushes.Black, x, 0, 2, height);
                    }
                    x += 2;
                }
            }

            return bitmap;
        }
    }
}
