using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailBruteForm
{

    public partial class MailBruteForm : Form
    {
        public ThreadingBrute th;
        public Checker chk;

        public MailBruteForm()
        {
            InitializeComponent();
           th = new ThreadingBrute(this);
           chk = new Checker(this);
        }

        private void MailBruteForm_Load(object sender, EventArgs e)
        {

            //chk.fillAccountsList(@"C:\Users\Home\Downloads\brute\базы\patebin1 укороченная для теста.txt");

            //if (chk.isalivethreads() > 0)
            //{
            //    chk.stopthreads();
            //}



            //CHK.showResult();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (btnStart.Text == "Start")
            {
                btnStart.Text = "Stop";

                th.threadCount = int.Parse(txtBoxCountThread.Text);
                th.startThreads();
            }
            else
            {
                th.stopThreads();
                btnStart.Text = "Start";
            }

        }

       

        private void btnLoadBase_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            chk.fillAccountsList(@openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public void setListBox(string value)
        {


            MethodInvoker inv = delegate
            {
                this.listBoxGood.Items.Add(value);
            };
            this.Invoke(inv);

        }

        public void setLblGood(int value)
        {
            MethodInvoker inv = delegate
            {
                this.lblCountGood.Text = "Good: " + value;
            };
            this.Invoke(inv);
        }

        public void setLblBad(int value)
        {
            MethodInvoker inv = delegate
            {
                this.lblCountBad.Text = "Bad: " + value;
            };
            this.Invoke(inv);
        }

        public void setLblCountAcc(int value)
        {
            MethodInvoker inv = delegate
            {
                this.lblCountAccount.Text = "Count account: " + value;
            };
            this.Invoke(inv);
        }
    }
}
