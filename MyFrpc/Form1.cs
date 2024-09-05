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

using Tomlyn;
using Tomlyn.Model;
using System.Diagnostics;

namespace MyFrpc
{
    public partial class MainForm : Form
    {
        TomlTable model, table;
        Process pro;
        bool isStratedFrp = false;

        public MainForm()
        {
            InitializeComponent();

            upDateForm();
        }


        public void upDateForm()
        {
            string s = File.ReadAllText("frpc.toml");
            model = Toml.ToModel(s);

            table = ((TomlTableArray)(model["proxies"]))[0];

            long curPort = (long)table["localPort"];
            curPortBox.Text = curPort.ToString();
        }

        private void OnClickFrp(object sender, EventArgs e)
        {
            if (isStratedFrp)
            {
                MessageBox.Show("不能重复开启!!","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }


            pro = new Process();
            pro.StartInfo.FileName = "frpc.exe";
            pro.StartInfo.Arguments = "-c frpc.toml";
            pro.Exited += new EventHandler(OnFrpExit);

            pro.StartInfo.UseShellExecute = false;
            pro.EnableRaisingEvents = true;
            pro.Start();

            isStratedFrp = true;
        }

        private void OnFrpExit(object sender, EventArgs e)
        {
            isStratedFrp = false;
        }

        private void MyProcOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            Console.WriteLine(outLine.Data);
        }

        private void curPortBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TryToChange(object sender, EventArgs e)
        {
            int newValue = 0;
            if(!int.TryParse(toBeBox.Text, out newValue))
            {
                MessageBox.Show("非法字符!!!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(newValue < 1 || newValue > 65535)
            {
                MessageBox.Show("不存在的端口!!!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            table["localPort"] = newValue;

            string s = Toml.FromModel(model);

            File.WriteAllText("frpc.toml", s);
            upDateForm();
        }
    }
}
