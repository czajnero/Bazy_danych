using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class EmployeeProcessor
    {
        public static int CreateEmployee(string _rodzaj_tran, string _sposob_zapl, int _numer_pojazd)
        {
            EmployeeModel data = new EmployeeModel
            {
                rodzaj_tran = _rodzaj_tran,
                sposob_zapl = _sposob_zapl,
                numer_pojazd = _numer_pojazd
            };

            string sql = @"insert into dbo.Transakcje (rodzaj_tran, sposob_zapl, numer_pojazd)
                           values (@rodzaj_tran, @sposob_zapl, @numer_pojazd);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select rodzaj_tran, sposob_zapl, numer_pojazd
                           from dbo.Transakcje;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }

        public static int CreateKlient(string _imie, string _nazwisko, string _pesel,
            string _kod_pocztowy, string _miasto, string _ulica, string _nr_domu, string _nr_lokalu,
            string _r_dokument, string _nr_dokument, string _nip, string _telefon, string _email)
        {
            KlientModel data = new KlientModel
            {
                imie = _imie,
                nazwisko = _nazwisko,
                pesel = _pesel,
                kod_pocztowy = _kod_pocztowy,
                miasto = _miasto,
                ulica = _ulica,
                nr_domu = _nr_domu,
                nr_lokalu = _nr_lokalu,
                r_dokument = _r_dokument,
                nr_dokument = _nr_dokument,
                nip = _nip,
                telefon = _telefon,
                email = _email,
            };

            string sql = @"insert into dbo.Klienci (imie, nazwisko, pesel, kod_pocztowy, miasto, ulica,
                                        nr_domu, nr_lokalu, r_dokument, nr_dokument, nip, telefon, email)
                           values (@imie, @nazwisko, @pesel, @kod_pocztowy, @miasto, @ulica, @nr_domu,
                                        @nr_lokalu, @r_dokument, @nr_dokument, @nip, @telefon, @email);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int CreatePojazd(string _marka, string _model, int _rok_prod,
         string _nr_rej, int _przebieg, string _rodzaj_pal, string _kolor, string _rodzaj_pojazd, string _numer_pojazd)
        {
            PojazdModel data = new PojazdModel
            {
                marka = _marka,
                model = _model,
                rok_prod = _rok_prod,
                nr_rej = _nr_rej,
                przebieg = _przebieg,
                rodzaj_pal = _rodzaj_pal,
                kolor = _kolor,
                rodzaj_pojazd = _rodzaj_pojazd,
                numer_pojazd = _numer_pojazd
            };

            string sql = @"insert into dbo.Pojazdy (marka, model, rok_prod, nr_rej, przebieg,
                                                    rodzaj_pal, kolor, rodzaj_pojazd, numer_pojazd)
                           values (@marka, @model, @rok_prod, @nr_rej, @przebieg,
                                                @rodzaj_pal, @kolor, @rodzaj_pojazd, @numer_pojazd);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<PojazdModel> LoadPojazdy()
        {
            string sql = @"select marka, model, rok_prod, nr_rej, przebieg, rodzaj_pal, kolor, rodzaj_pojazd, numer_pojazd
                           from dbo.Pojazdy;";

            return SqlDataAccess.LoadData<PojazdModel>(sql);
        }

    }
}