using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


//logika frontendu
namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Rodzaj transakcji")]
        [Required(ErrorMessage = "Podaj rodzaj transakcji.")]
        public string rodzaj_tran { get; set; }

        [Display(Name = "Sposób zapłaty")]
        [Required(ErrorMessage = "Podaj sposób zapłaty.")]
        public string sposob_zapl { get; set; }

        [Display(Name = "Numer samochodu do wypożyczenia")]
        [Required(ErrorMessage = "Musisz podać numer samochodu, który chcesz wypożyczyć (z listy ogłoszeń)")]
        public int numer_pojazd { get; set; }
    }

    public class KlientModel
    {
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Musisz podać swoje imię.")]
        public string imie { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Musisz podać swoje nazwisko.")]
        public string nazwisko { get; set; }

        [Display(Name = "Numer PESEL")]
        [Range(10000000000, 99999999999, ErrorMessage = "Zły numer PESEL.")]
        [Required(ErrorMessage = "Musisz podać swój numer PESEL.")]
        public string pesel { get; set; }

        [Display(Name = "Kod pocztowy")]
        [Required(ErrorMessage = "Musisz podać swój numer PESEL.")]
        public string kod_pocztowy { get; set; }

        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "Musisz podać swój adres zamieszkania.")]
        public string miasto { get; set; }

        [Display(Name = "Ulica")]
        [Required(ErrorMessage = "Musisz podać swój adres zamieszkania.")]
        public string ulica { get; set; }

        [Display(Name = "Numer domu")]
        [Required(ErrorMessage = "Musisz podać swój adres zamieszkania.")]
        public string nr_domu { get; set; }

        [Display(Name = "Numer Lokalu")]
        public string nr_lokalu { get; set; }

        [Display(Name = "Rodzaj dokumentu")]
        [Required(ErrorMessage = "Musisz podać swój rodzaj dokumentu.")]
        public string r_dokument { get; set; }

        [Display(Name = "Numer dokumentu")]
        [Required(ErrorMessage = "Musisz podać swój numer dokumentu.")]
        public string nr_dokument { get; set; }

        [Display(Name = "NIP (opcjonalne)")]
        public string nip { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Musisz podać swój numer telefonu.")]
        public string telefon { get; set; }

        [Display(Name = "Adres E-mail")]
        [Required(ErrorMessage = "Musisz podać swój adres e-mail.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Zły format adresu e-mail.")]
        public string email { get; set; }
    }
        public class PojazdModel
        { 
            [Display(Name = "Marka")]
            [Required(ErrorMessage = "Musisz podać markę samochodu.")]
            public string marka { get; set; }

            [Display(Name = "Model")]
            [Required(ErrorMessage = "Musisz podać model samochodu.")]
            public string model { get; set; }

            [Display(Name = "Rok produkcji")]
            [Required(ErrorMessage = "Musisz podać rok produkcji samochodu.")]
            public int rok_prod { get; set; }

            [Display(Name = "Numer rejestracji")]
            [Required(ErrorMessage = "Musisz podać numer rejestracji samochodu.")]
            public string nr_rej { get; set; }

            [Display(Name = "Przebieg")]
            [Required(ErrorMessage = "Musisz podać przebieg samochodu.")]
            public int przebieg { get; set; }

            [Display(Name = "Rodzaj paliwa")]
            [Required(ErrorMessage = "Musisz podać rodzaj paliwa w samochodzie.")]
            public string rodzaj_pal { get; set; }

            [Display(Name = "Kolor")]
            [Required(ErrorMessage = "Musisz podać jakiego koloru jest samochód.")]
            public string kolor { get; set; }

            [Display(Name = "Rodzaj pojazdu")]
            [Required(ErrorMessage = "Musisz podać rodzaj pojazdu.")]
            public string rodzaj_pojazd { get; set; }

            [Display(Name = "Numer pojazdu")]
            [Required(ErrorMessage = "Musisz podać numer pojazdu.")]
            public string numer_pojazd { get; set; }
    }
}
