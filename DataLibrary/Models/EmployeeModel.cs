using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// logika biznesowa aplikacji

namespace DataLibrary.Models
{
    public class EmployeeModel
    {
        public string rodzaj_tran { get; set; }
        public string sposob_zapl { get; set; }
        public int numer_pojazd { get; set; }
    }
    public class KlientModel
    {
        public int Id_klienta { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string pesel { get; set; }
        public string kod_pocztowy { get; set; }
        public string miasto { get; set; }
        public string ulica { get; set; }
        public string nr_domu { get; set; }
        public string nr_lokalu { get; set; }
        public string r_dokument { get; set; }
        public string nr_dokument { get; set; }
        public string nip { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
    }

    public class PojazdModel
    {
        //public int Id_pojazd { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public int rok_prod { get; set; }
        public string nr_rej { get; set; }
        public int przebieg { get; set; }
        public string rodzaj_pal { get; set; }
        public string kolor { get; set; }
        public string rodzaj_pojazd { get; set; }
        public string numer_pojazd { get; set; }
    }

    public class TransakcjaModel
    {
        public int Id_transakcji { get; set; }
        public string rodzaj_tran { get; set; }
        public int kwota { get; set; }
        public string nr_faktury { get; set; }
        public string sposob_zapl { get; set; }
        public int znizka { get; set; }
        //public DateTime data_tran { get; set; }
        public string zaplacono { get; set; }
    }
}
