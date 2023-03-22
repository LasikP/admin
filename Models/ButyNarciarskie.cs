﻿namespace Ski_Rental.Models
{
    public class ButyNarciarskie
    {
        public int IDButyNarciarskie { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Producent { get; set; }
        public string Kolor { get; set; }
        public int Rozmiar { get; set; }
        public decimal CenaGodzinowa { get; set; }
        public bool Dostepnosc { get; set; }
        public byte[] Zdjecie { get; set; }
    }
}
