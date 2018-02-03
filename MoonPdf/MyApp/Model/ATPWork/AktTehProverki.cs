﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace MyApp.Model
{
    public class AktTehProverki:INotifyPropertyChanged ,IComparer<AktTehProverki>
    {
        private int numberMail;
        public int NumberMail
        {
            get
            {
                return this.numberMail;
            }
            set
            {
                this.numberMail = value;
                this.OnPropertyChanged("NumberMail");
                this.OnPropertyChanged("MailName");
            }
        }

        private long _sizePDF;
        public long SizePDF
        {
            get
            {
                return this._sizePDF;
            }
            set
            {
                this._sizePDF = value;
                this.OnPropertyChanged("SizePDF");
            }
        }


        public string MailName
        {
            get {
                string result;
                if ((numberMail > 0) && DateMail != null) result = "исх.№91-" + numberMail + " от " + DateMail?.ToString("d");
                else result = "Неотправлено";
                return result;
            }
            
        }
        public string AktName
        {
            get
            {
                string result;
                if (number>0 && DateWork!=null) result = "№91-" + number + " от " + DateWork?.ToString("d");
                else result = NumberOfPagesInSoursePdf[0] + "стр.; "+ NumberOfPagesInSoursePdf[1] + "стр.;  незаполнен";
               
                return result;
            }
        }

        public List<int> _numberOfPagesInSoursePdf = new List<int>();
        public List<int> NumberOfPagesInSoursePdf
        {
            get { return this._numberOfPagesInSoursePdf; }
            set
            {
                this._numberOfPagesInSoursePdf = value;
                this.OnPropertyChanged("NumberOfPagesInSoursePdf");
                
            }
        }
        public bool ProverkaFlag
        {
            get { return !this.dopuskFlag; }

            set
            {
                this.DopuskFlag = !value;
                this.OnPropertyChanged("ProverkaFlag");
                this.OnPropertyChanged("DopuskFlag");
            }
        }
        private bool dopuskFlag;
        public bool DopuskFlag
        {
            get { return this.dopuskFlag; }
            set
            {
                this.dopuskFlag = value;
                this.OnPropertyChanged("ProverkaFlag");
                this.OnPropertyChanged("DopuskFlag");
            }
        }
        private string ustanovka;
        public string Ustanovka
        {
            get { return this.ustanovka; }
            set
            {
                this.ustanovka = value;
                this.OnPropertyChanged("Ustanovka");
            }
        }
        private string edOborudovania;
        public string EdOborudovania
        {
            get { return this.edOborudovania; }
            set
            {
                this.edOborudovania = value;
                this.OnPropertyChanged("EdOborudovania");
            }
        }
        private string sapNumberAkt;
        public string SapNumberAkt
        {
            get { return this.sapNumberAkt; }
            set
            {
                this.sapNumberAkt = value;
                this.OnPropertyChanged("SapNumberAkt");
            }
        }
        private string puOldNumber;
        public string PuOldNumber
        {
            get { return this.puOldNumber; }
            set
            {
                this.puOldNumber = value;
                this.OnPropertyChanged("PuOldNumber");
            }
        }
        private string puOldType;
        public string PuOldType
        {
            get { return this.puOldType; }
            set
            {
                this.puOldType = value;
                this.OnPropertyChanged("PuOldType");
            }
        }
        private string puNewNumber;
        public string PuNewNumber
        {
            get { return this.puNewNumber; }
            set
            {
                this.puNewNumber = value;
                this.OnPropertyChanged("PuNewNumber");
            }
        }
        private PriborUcheta puNewType;
        public PriborUcheta PuNewType
        {
            get { return this.puNewType; }
            set
            {
                this.puNewType = value;
                this.OnPropertyChanged("PuNewType");
            }
        }
        private string puOldPokaz;
        public string PuOldPokazanie
        {
            get { return this.puOldPokaz; }
            set
            {
                this.puOldPokaz = value;
                this.OnPropertyChanged("PuOldPokazanie");
            }
        }
        private bool puOldMPI;
        public bool PuOldMPI
        {
            get { return this.puOldMPI; }
            set
            {
                this.puOldMPI = value;
                this.OnPropertyChanged("PuOldMPI");
            }
        }
        private bool complete;
        public bool Complete
        {
            get { return this.complete; }
            private set
            {
                this.complete = value;
                this.OnPropertyChanged("Complete");
            }
        }
        private string puNewPokazanie;
        public string PuNewPokazanie
        {
            get { return this.puNewPokazanie; }
            set
            {
                this.puNewPokazanie = value;
                this.OnPropertyChanged("PuNewPokazanie");
            }
        }
        private string puNewPoverkaEar;
        public string PuNewPoverkaEar
        {
            get { return this.puNewPoverkaEar; }
            set
            {
                this.puNewPoverkaEar = value;
                this.OnPropertyChanged("PuNewPoverkaEar");
            }
        }
        private string puNewPoverkaKvartal;
        public string PuNewPoverKvartal
        {
            get { return this.puNewPoverkaKvartal; }
            set
            {
                this.puNewPoverkaKvartal = value;
                this.OnPropertyChanged("PuNewPoverKvartal");
            }
        }
        private string adress;
        public string Adress
        {
            get { return this.adress; }
            set
            {
                this.adress = value;
                this.OnPropertyChanged("Adress");
            }
        }
        private int number;
        public int Number
        {
            get { return this.number; }
            set
            {
                this.number = value;
                this.OnPropertyChanged("Number");
                this.OnPropertyChanged("AktName");
            }
        }
        private DateTime? dateMail;
        public DateTime? DateMail
        {
            get { return this.dateMail; }
            set
            {
                this.dateMail = value;
                this.OnPropertyChanged("DateMail");
                this.OnPropertyChanged("MailName"); 
            }
        }
        private DateTime? dateWork;
        public DateTime? DateWork
        {
            get { return this.dateWork; }
            set { this.dateWork = value;
                this.OnPropertyChanged("DateWork");
                this.OnPropertyChanged("AktName");
            }
        }
        private string fIO;
        public string FIO
        {
            get { return this.fIO; }
            set { this.fIO = value; this.OnPropertyChanged("FIO"); }
        }
        private int iD;
        public int ID
        {
            get { return this.iD; }
            set { this.iD = value; this.OnPropertyChanged("ID"); }
        }
        private ObservableCollection<Plomba> _newPlombs = new ObservableCollection<Plomba>();
        public ObservableCollection<Plomba> NewPlombs {
            get { return _newPlombs; }
            set { this._newPlombs =  value;
                this.OnPropertyChanged("NewPlombs");
            }
        }
        private ObservableCollection<Plomba> _oldPlombs = new ObservableCollection<Plomba>();
        public ObservableCollection<Plomba> OldPlombs
        {
            get { return _oldPlombs; }
            set
            {
                this._oldPlombs = value;
                this.OnPropertyChanged("OldPlombs");
            }
        }
        private Agent agent_1;
        public Agent Agent_1
        {
            get { return this.agent_1; }
            set
            {
                this.agent_1 = value; this.OnPropertyChanged("Agent_1");
            }
        }
        private Agent agent_2;
        public Agent Agent_2
        {
            get { return this.agent_2;  }
            set
            {
                this.agent_2 = value; this.OnPropertyChanged("Agent_2");
            }
        }
        private  string numberLS;
        public  string NumberLS
        {
            get { return this.numberLS; }
            set { this.numberLS = value; this.OnPropertyChanged("NumberLS"); }
        }
        private string namePdfFile;
        public string NamePdfFile
        {
            get { return this.namePdfFile; }
            set { this.namePdfFile = value; this.OnPropertyChanged("NamePdfFile"); }
        }
        public AktTehProverki(int id, List<int> numbersOfPageInPdf, string pathOfPdfFile, long size)
        {
            this.ID = id;
            this.Complete = false;
            this.namePdfFile = pathOfPdfFile;
            this.SizePDF = size;
            foreach (var page in numbersOfPageInPdf)
            {
                NumberOfPagesInSoursePdf.Add(page);
            }
        }
        public void setDataByDb(Dictionary<string, string> dict,List<Dictionary<string, string>> oldPlombs)
        {
            NumberLS = dict["LsNumber"];
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
            OldPlombs.Clear();
            foreach (Dictionary<string,string> item in oldPlombs)
            {
                string plomb_Type, plomb_Number, plomb_Place, plomb_Status, plomb_DateInstall;
                bool plomb_Remove;
                plomb_Type = item["Type"].ToString();
                plomb_Number = item["Number"].ToString();
                plomb_Place = item["Place"].ToString();
                plomb_Status = item["Status"].ToString();
                plomb_DateInstall = item["InstallDate"].ToString();
                OldPlombs.Add(new Plomba(plomb_Type, plomb_Number, plomb_Place, false, true, plomb_Status, plomb_DateInstall));
            }

        }
        public bool checkToComplete()
        {
            bool result = true;
            if (agent_1 == null) result = false;
            if (adress == null || adress == "") result = false;
            if (dateWork == null) result = false;
            if (fIO == null || fIO == "") result = false;
            if (number ==0) result = false;
            if (numberLS == null || numberLS == "") result = false;
            if (puOldNumber == null || puOldNumber == "") result = false;
            if (puOldPokaz == null || puOldPokaz == "") result = false;
            if (puOldType == null || puOldType == "") result = false;
            if (dopuskFlag)
            {
                if (puNewNumber == null || puNewNumber == "") result = false;
                if (puNewPokazanie == null || puNewPokazanie == "") result = false;
                if (puNewPoverkaEar == null || puNewPoverkaEar == "") result = false;
                if (puNewPoverkaKvartal == null || puNewPoverkaKvartal == "") result = false;
                if (puNewType == null) return false;
            }

            foreach (Plomba item in NewPlombs)
            {
                if (item.Number == "" || item.Type == "") result = false;
            }

            Complete = result;
            return result;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }


        public int Compare(AktTehProverki x, AktTehProverki y)
        {
            if (x.Number > y.Number)
            {
                return 1;
            }
            else if (x.Number < y.Number)
            {
                return -1;
            }

            return 0;
        }
    }
}