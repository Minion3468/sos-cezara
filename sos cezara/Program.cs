string kod;
int klucz;

Console.WriteLine("Podaj kod: ");
kod = Console.ReadLine();

Console.WriteLine("Podaj wartosc klucza: ");
klucz = Convert.ToInt32(Console.ReadLine());

zmiana(kod, klucz);

Console.ReadLine();

void zmiana(string kod, int klucz)
{
    char[] litery = kod.ToCharArray();
    string szyfr = "";

    for (int i = 0; i < litery.Length; i++)
    {
        int wartosc = (int)litery[i];

            
        if (wartosc >= 97 && wartosc <= 122 || wartosc >= 65 && wartosc <= 98)
        {
            int warklucza = 0;

            if ((wartosc + klucz) > 123 && (wartosc + klucz) > 91)
            {
                int reszta = 122 - wartosc;
                int dreszta = 90 - wartosc;
                warklucza = 96 + (klucz - reszta);
                warklucza = 64 + (klucz - dreszta);
            }
            else {warklucza = wartosc + klucz;}

            string nlitery = Convert.ToChar(warklucza).ToString();
            szyfr += nlitery;
        }
        else
        {
            string nlitery = Convert.ToChar(wartosc).ToString();
            szyfr += nlitery;
        }
    }  
    Console.WriteLine(szyfr);
}

      
            








