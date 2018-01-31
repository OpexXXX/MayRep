﻿using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATPWork.MyApp.Model.Plan
{
   public class Abonent
    {
        public Abonent(string numberLS, DateTime dateWork)
        {
            NumberLS = numberLS;
            DateWork = dateWork;
            this.setDataByDb();
        }
        private string ustanovka;
        public string Ustanovka
        {
            get { return this.ustanovka; }
            set
            {
                this.ustanovka = value;
            }
        }
        private string edOborudovania;
        public string EdOborudovania
        {
            get { return this.edOborudovania; }
            set
            {
                this.edOborudovania = value;
            }
        }
        private string puOldNumber;
        public string PuOldNumber
        {
            get { return this.puOldNumber; }
            set
            {
                this.puOldNumber = value;
            }
        }

        private string puOldType;
        public string PuOldType
        {
            get { return this.puOldType; }
            set
            {
                this.puOldType = value;
            }
        }

        private string puOldPokaz;
        public string PuOldPokazanie
        {
            get { return this.puOldPokaz; }
            set
            {
                this.puOldPokaz = value;
            }
        }

        private bool puOldMPI;
        public bool PuOldMPI
        {
            get { return this.puOldMPI; }
            set
            {
                this.puOldMPI = value;
            }
        }
        private string adress;
        public string Adress
        {
            get { return this.adress; }
            set
            {
                this.adress = value;
            }
        }
        private string _podkl;
        public string Podkl
        {
            get { return this._podkl; }
            set
            {
                this._podkl = value;
            }
        }
        private DateTime dateWork;
        public DateTime DateWork
        {
            get { return this.dateWork; }
            set
            {
                this.dateWork = value;
            }
        }
        private string fIO;
        public string FIO
        {
            get { return this.fIO; }
            set { this.fIO = value; }
        }
        private List<Plomba> _oldPlombs = new List<Plomba>();
        public List<Plomba> OldPlombs
        {
            get { return _oldPlombs; }
            set
            {
                this._oldPlombs = value;
            }
        }
        private string numberLS;
        public string NumberLS
        {
            get { return this.numberLS; }
            set { this.numberLS = value; }
        }
        public void setDataByDb()
        {
            List<Dictionary<string, string>> searchResult = DataBaseWorker.PlanGetAbonentFromDb(numberLS);
            if (searchResult.Count == 1)
            {
                Dictionary<string, string> dict = searchResult[0];
                PuOldType = dict["PuType"];
                PuOldNumber = dict["PuNumber"];
                FIO = dict["FIO"];
                string tmpadress = "";
                tmpadress = dict["City"] + ", " + dict["Street"] + ", д. " + dict["House"];
                if (dict.ContainsKey("Korpus")) tmpadress += dict["Korpus"];
                if (dict.ContainsKey("Kv")) tmpadress += ", кв." + dict["Kv"];
                Adress = tmpadress;
                Ustanovka = dict["Ustanovka"];
                EdOborudovania = dict["EdOborudovania"];
                Podkl = dict["Podkluchenie"];

                List<Dictionary<string, string>> plombs = DataBaseWorker.GetPlombsFromEdOb(EdOborudovania);
                foreach (Dictionary<string, string> item in plombs)
                {
                    string plomb_Type, plomb_Number, plomb_Place, plomb_Status, plomb_DateInstall;
                    plomb_Type = item["Type"].ToString();
                    plomb_Number = item["Number"].ToString();
                    plomb_Place = item["Place"].ToString();
                    plomb_Status = item["Status"].ToString();
                    plomb_DateInstall = item["InstallDate"].ToString();
                    OldPlombs.Add(new Plomba(plomb_Type, plomb_Number, plomb_Place, false, true, plomb_Status, plomb_DateInstall));
                }
            }
        }
    }
}
