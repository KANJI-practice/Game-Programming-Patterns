using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Patterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inPutHandler = new InputHandler();
            ActiveCommand = "null";

        }
        InputHandler inPutHandler;

        string ActiveCommand;
    
        private Command GetActiveButtonCommand()
        {
            if ("Button A" == ActiveCommand)
            {
                return inPutHandler.GetButtonAInstance();
            }
            else if ("Button B" == ActiveCommand)
            {
                return inPutHandler.GetButtonBInstance();
            }
            else if ("Button C" == ActiveCommand)
            {
                return inPutHandler.GetButtonCInstance();
            }
            else
            {
                //TODO nullオブジェクト
                return null;
            }
        }
        //実行
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Command command = GetActiveButtonCommand();
            label8.Text = command.Execute();

        }

        //設定の確定
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //TODO リファクタ
            //Gr1
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            var RadioButtonChecked_InGroup = groupBox1.Controls.OfType<RadioButton>()
                .SingleOrDefault(rb => rb.Checked == true);

            if (RadioButtonChecked_InGroup == null)
            {
                //まだチェックされていない
            }
            else
            {
                inPutHandler.AssignButtonCommand("Button A", RadioButtonChecked_InGroup.Text);
            }

            //Gr2
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            var RadioButtonChecked_InGroup2 = groupBox2.Controls.OfType<RadioButton>()
                .SingleOrDefault(rb => rb.Checked == true);

            if (RadioButtonChecked_InGroup == null)
            {
                //まだチェックされていない
            }
            else
            {
                inPutHandler.AssignButtonCommand("Button B", RadioButtonChecked_InGroup2.Text);
            }

            //Gr3
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            var RadioButtonChecked_InGroup3 = groupBox3.Controls.OfType<RadioButton>()
                .SingleOrDefault(rb => rb.Checked == true);

            if (RadioButtonChecked_InGroup == null)
            {
                //まだチェックされていない
            }
            else
            {
                inPutHandler.AssignButtonCommand("Button C", RadioButtonChecked_InGroup3.Text);
            }
            //Gr4
            // 指定したグループ内のラジオボタンでチェックされている物を取り出す
            var RadioButtonChecked_InGroup4 = groupBox4.Controls.OfType<RadioButton>()
                .SingleOrDefault(rb => rb.Checked == true);

            if (RadioButtonChecked_InGroup != null)
            {
                ActiveCommand = RadioButtonChecked_InGroup4.Text;
            }
        }

      
    }

}

