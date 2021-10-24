using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AtmLib;

namespace prjFinalProject
{

    public partial class frmGab : Form
    {
        public frmGab()
        {
            InitializeComponent();
        }
     
       
        clsAtm Atm;
        clsClient Client;
        private void frmGab_Load(object sender, EventArgs e)
        {
            Atm = new clsAtm("GAB", "1415");
            
            readFile2Collection();
            txtPin.PasswordChar = '*';
            this.Height = 200;
            txtDeposit.Visible= lblDollar.Visible = lblDollar2.Visible = txtWithdraw.Visible = false;
           
           
        }
        private void readFile2Collection()
        {
            StreamReader myFile = new StreamReader("Clients.txt");
           
            while (!myFile.EndOfStream)
            {
                string num = myFile.ReadLine();
                string name = myFile.ReadLine();
                string pin = myFile.ReadLine();

                clsClient cl = new clsClient(name,num,pin);

                //listClients.Add(cl.Number,cl);
                Atm.Clients.Add(cl.Number,cl);
                cl = null;
            }
            myFile.Close();
        }
       

        private void btnNext_Click(object sender, EventArgs e)
        {
            string cardnumb = txtCardNumb.Text;
            if (Atm.Clients.ContainsKey(cardnumb) == true)
            {
                this.Height = 338;

                lblClient.Text = "Welcome, " + Atm.Clients[cardnumb].Name;
            }
            else
            {
                MessageBox.Show("Entered Card Number doesn't exist");
            }
            

        }
      

        private void readAcc2Collection()
        {
            StreamReader myFile = new StreamReader("Account.txt");
            while (!myFile.EndOfStream)
            {
                string AccNum = myFile.ReadLine();
                string ClientNum = myFile.ReadLine();
                string Type = myFile.ReadLine();
                clsDate jDate = new clsDate();
                jDate.Date =Convert.ToInt16( myFile.ReadLine());
                jDate.Month = Convert.ToInt16(myFile.ReadLine());
                jDate.Year= Convert.ToInt16(myFile.ReadLine());
                Int32 Bal = Convert.ToInt32(myFile.ReadLine());

                clsAccount acc = new clsAccount(Bal,AccNum,Type,jDate.Date,jDate.Month,jDate.Year);
                foreach(clsClient cl in Atm.Clients.Values)
                {
                    if (cl.Number == ClientNum)
                    {
                        cl.Accounts.Add(AccNum, acc);
                    }
                }
                
                acc = null;
            }
            myFile.Close();
            
        }

        private void btnNextPin_Click(object sender, EventArgs e)
        {
            string cardnumb = txtCardNumb.Text;
         
            
            if (txtPin.Text == Atm.Clients[cardnumb].Pin)
            {
                readAcc2Collection();
                foreach(clsAccount ac in Atm.Clients[cardnumb].Accounts.Values)
                {
                    cBoxType.Items.Add(ac.Type);
                }
                this.Height = 445;
               
            }
            else
            {
                MessageBox.Show("Entered Pin is Incorrect");
            }

        }


        private void btnNextAcc_Click(object sender, EventArgs e)
        {
            this.Height = 584;
        }


        private void btnNextTrans_Click(object sender, EventArgs e)
        {
            string cardnumb = txtCardNumb.Text;
            string type = cBoxType.SelectedItem.ToString();
            string AcNumb = "";
            foreach(clsAccount ac in Atm.Clients[cardnumb].Accounts.Values)
            {
                if(ac.Type == type)
                {
                    AcNumb = ac.Number;
                }
                
            }

            if (rdbConsult.Checked)
            {
                lblConsult.Text = Atm.Clients[cardnumb].Accounts[AcNumb].Consult();
              
                this.Height = 724;

            }
            else if (rdbDeposit.Checked)
            {
                if (txtDeposit.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter an Amount","No Amount");
                }
                else
                {
                    string message = Atm.Clients[cardnumb].Accounts[AcNumb].Deposit(AcNumb, cardnumb, Atm, Convert.ToInt32(txtDeposit.Text));
                    MessageBox.Show(message);
                    lblConsult.Text = Atm.Clients[cardnumb].Accounts[AcNumb].Consult(/*AN, cardnumb, Atm, Atm.Clients[cardnumb], Atm.Clients[cardnumb].Accounts[AN]*/);
                    if (message == "Money Deposited")
                    {
                        this.Height = 724;
                    }
                }
            }
            else if (rdbWithdraw.Checked)
            {

                if (txtWithdraw.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter an Amount","No Amount");

                }
                else
                {
                    string message = Atm.Clients[cardnumb].Accounts[AcNumb].Withdraw(AcNumb, cardnumb, Atm, Convert.ToInt32(txtWithdraw.Text));
                MessageBox.Show(message);
                lblConsult.Text = Atm.Clients[cardnumb].Accounts[AcNumb].Consult(/*AN, cardnumb, Atm, Atm.Clients[cardnumb], Atm.Clients[cardnumb].Accounts[AN]*/);
                    if (message == "collect your cash")
                    {
                        this.Height = 724;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an option");
            }
            
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
           
            Collection2File();

            this.Height = 200;
            txtCardNumb.Clear();
            txtDeposit.Clear();
            txtWithdraw.Clear();
            txtPin.Clear();
            lblClient.Text = "";
            lblConsult.Text = "";
            cBoxType.Items.Clear();
            rdbConsult.Checked = rdbDeposit.Checked=rdbWithdraw.Checked=false;
            Atm.Clients = new Dictionary<string, clsClient>();
            readFile2Collection();
        }

        private void rdbDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible=lblDollar.Visible=true  ;
            txtWithdraw.Visible = lblDollar2.Visible = false;
        }

        private void rdbWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible  = lblDollar2.Visible= true;
            txtDeposit.Visible = lblDollar.Visible = false;
        }
        private void rdbConsult_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible = lblDollar2.Visible = false;
            txtDeposit.Visible = lblDollar.Visible = false;
        }
        private void Collection2File()
        {
            string cardnumb = txtCardNumb.Text;
            StreamWriter myFile = new StreamWriter("Account.txt");
            foreach(clsClient cl in Atm.Clients.Values)
            {
                foreach(clsAccount ac in cl.Accounts.Values)
                {
                    myFile.WriteLine(ac.Number);
                    myFile.WriteLine(cl.Number);
                    myFile.WriteLine(ac.Type);
                    myFile.WriteLine(ac.OpenDate.Date);
                    myFile.WriteLine(ac.OpenDate.Month);
                    myFile.WriteLine(ac.OpenDate.Year);
                    myFile.WriteLine(ac.Balance);
                    
                }
            }myFile.Close();
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
