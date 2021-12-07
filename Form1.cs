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

namespace CSC240_14_01_EnterInvoices_bpcc
{
    public partial class Form1 : Form
    {
        const string DELIM = ",";
        const string FILENAME =
            @"C:\CSharp\Chapter14\Invoices.txt";
        int num;
        string name;
        double amount;
        static FileStream outFile = new
            FileStream(FILENAME, FileMode.Create, 
            FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);

        public Form1()
        {
            InitializeComponent();
        }

        private void UxEnterButton_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(UxInvoiceBox.Text);
            name = UxNameBox.Text;
            amount = Convert.ToDouble(UxNumberBox.Text);
            writer.WriteLine(num + DELIM + name + DELIM + amount);
            UxInvoiceBox.Clear();
            UxNameBox.Clear();
            UxNumberBox.Clear();
        }
    }
}
