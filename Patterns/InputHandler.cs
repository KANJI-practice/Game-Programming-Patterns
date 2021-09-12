using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns
{
    class InputHandler
    {
        private Command Button_A;
        private Command Button_B;
        private Command Button_C;


        public bool IsKick(string str)
        {
            return "Kick" == str;
        }

        public bool IsJump(string str)
        {
            return "Jump" == str;
        }

        public bool IsPanch(string str)
        {
            return "Panch" == str;
        }

        public Command GetButtonAInstance()
        {
            return Button_A;
        }

        public Command GetButtonBInstance()
        {
            return Button_B;
        }

        public Command GetButtonCInstance()
        {
            return Button_C;
        }
        public ref Command GetButtonInstance(string str)
        {
            if ("Button A" == str)
            {
                return ref Button_A;
            }
            else if ("Button B" == str)
            {
                return ref Button_B;
            }
            else
            {
                return ref Button_C;
            }
  
            
           
        }
        public void AssignButtonCommand(string ButtonString, string CommadString)
        {
            //C#の参照はこれでよいのか良く知らない
            ref Command Button = ref GetButtonInstance(ButtonString);

            if (IsKick(CommadString))
            {
                Button = new KickCommand();
            }
            else if (IsJump(CommadString))
            {
                Button = new JumpCommand();
            }
            else if (IsPanch(CommadString))
            {
                Button = new PunchCommand();
            }
            else
            {
                //TODO デフォルト割り当て 各ボタンのデフォルトがセットされるようにする
                Button = new KickCommand();
            }
          
        } 


    }
}
