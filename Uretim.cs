using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba_Uretim
{
    internal class Uretim
    {
        string marka;
        string model;
        string renk;
        int motorHacmi;
        int uretimYili;

        public Uretim(string marka, string model, string renk, int motorHacmi, int uretimYili)
        {
            this.marka = marka;
            this.model = model;
            this.renk = renk;
            this.motorHacmi = motorHacmi;
            this.uretimYili = uretimYili;
        }
        public static void Goster(List<Uretim> liste)
        {
            int i = 1;
            Console.WriteLine("Arabalar Listesi: \n\n");
            foreach (Uretim item in liste)
            {
                Console.WriteLine(i + " -Araba Marka: " + item.marka + "\nAraba Modeli: " + item.model + "\nRengi: " + item.renk + "\nMotor Hacmi: " + item.motorHacmi + "\nÜretim Yılı: " + item.uretimYili +"\n");

                i++;
            }
        }
        public static void Guncelleme(List<Uretim> liste, int i)
        {
            Console.WriteLine("Güncelleme Türünü Seç:1-Renk\n2-Motor Hacmi");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim==1)
            {
                Console.WriteLine("Arabanın Rengi: " + liste[i - 1].renk + "\nGüncellemek istediğin renk ?");
                string yeniRenk = Console.ReadLine();
                liste[i - 1].renk = yeniRenk;
            }
            else if (secim==2)
            {
                Console.WriteLine("Arabanın Motor Hacmi: " + liste[i - 1].motorHacmi + "\nGüncellemek istediğin motor hacmi ?");
                int yeniMotor = Convert.ToInt32(Console.ReadLine());
                liste[i - 1].motorHacmi = yeniMotor;
            }
            
        }
        public static void Filtrele(List<Uretim> liste, string marka1)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].marka == marka1)
                {
                    Console.WriteLine((i + 1) + "Araba Marka: " + liste[i].marka + "\nAraba Modeli: " + liste[i].model + "\nRengi: " + liste[i].renk + "\nMotor Hacmi: " + liste[i].motorHacmi + "\nÜretim Yılı: " + liste[i].uretimYili);

                }
                else
                {
                    continue;
                }
            }
        }
    }
}
