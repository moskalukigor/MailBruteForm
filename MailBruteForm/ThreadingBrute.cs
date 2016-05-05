using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBruteForm
{
    public class ThreadingBrute
    {
        private Thread[] threads;
        public Object syncIndex = new Object();
        public int threadCount = 10;


        private MailBruteForm _frmMain;
        public ThreadingBrute(MailBruteForm frmMain)
        {
            _frmMain = frmMain;
        }

        public void startThreads()
        {

            if (threadCount == 0)
            {
                threadCount = 100;
            }
            if (threadCount >= _frmMain.chk.countSource)
            {
                threadCount = _frmMain.chk.countSource;
            }
            threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(this.Checking);
                threads[i].IsBackground = true;
                threads[i].Start();
            }

        }

        public void stopThreads()
        {
            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Abort();
            }
        }

        public int isAliveThreads()
        {
            try
            {
                int countAliveThreads = 0;
                for (int i = 0; i < threadCount; i++)
                {
                    if (threads[i].IsAlive)
                    {
                        countAliveThreads++;
                    }
                    threads[i].Abort();
                }
                return countAliveThreads;
            }
            catch
            {
                return 0;
            }
        }

        void Checking()
        {
            while (_frmMain.chk.counterAcc < _frmMain.chk.countSource-1)
            {
                lock (syncIndex)
                {
                    _frmMain.chk.counterAcc++;
                }

                if (_frmMain.chk.counterAcc > _frmMain.chk.countSource)
                {
                    MessageBox.Show("STOOOOPP");break;
                }

                _frmMain.chk.checkMail(_frmMain.chk.accountsList[_frmMain.chk.counterAcc]);


            }
        }
    }
}
