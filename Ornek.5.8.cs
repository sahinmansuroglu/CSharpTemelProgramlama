static void Main(string[] args)
        {
            string metin = "Türkiyenin En BÜYÜK Şehri İstanbul'dur ";
            string arananKelime = "Büyük";
            string yeniDegeri = "Kalabalık";
            arananKelime = arananKelime.ToUpper();
            metin = metin.Replace(arananKelime, yeniDegeri);
            Console.WriteLine(metin);
        }
