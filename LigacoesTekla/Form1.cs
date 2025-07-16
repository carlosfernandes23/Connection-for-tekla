using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using TeklaMacroBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Drawing;
using Tekla.Structures.Geometry3d;
using ModelPart = Tekla.Structures.Model.Part;
using Tekla.Structures.Model.Operations;
using System.Runtime.InteropServices;
using System.Text;
using WindowsInput;
using WindowsInput.Native;
using Timer = System.Windows.Forms.Timer;

namespace LigacoesTekla
{
    public partial class MACROS : Form

    {    private Timer timer;

        public MACROS()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 10000; 
            timer.Tick += Timer_Tick;
        }

        internal void refreshViewe()
        {
            ModelViewEnumerator ViewEnum = ViewHandler.GetVisibleViews();
            ViewEnum.MoveNext();
            Tekla.Structures.Model.UI.View CurrentView = ViewEnum.Current;
            ViewHandler.RedrawView(CurrentView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "40");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "106");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1003");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1002");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1042");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1047");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1004");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "20");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "22");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "49");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "13");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "23");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "29");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "27");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1014");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "14");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "85");
        }

        int a = 1;
        private readonly object _Macro;

        //private void button18_Click(object sender, EventArgs e)
        //{
        //    a++;
        //    panel1.Visible = false;
        //    panel2.Visible = false;
        //    panel3.Visible = false;
        //    panel4.Visible = false;
        //    panel5.Visible = false;
        //    panel6.Visible = false;


        //    if (a == 0)
        //    {
        //        a = 1;
        //    }
        //    if (a == 1)
        //    {
        //        panel1.Visible = true;

        //    }
        //    if (a == 2)
        //    {
        //        panel2.Visible = true;

        //    }
        //    if (a == 3)
        //    {
        //        panel3.Visible = true;

        //    }
        //    if (a == 4)
        //    {
        //        panel4.Visible = true;

        //    }
        //    if (a == 5)
        //    {
        //        panel5.Visible = true;

        //    }
        //    if (a == 6)
        //    {
        //        panel6.Visible = true;

        //    }
        //    if (a == 7)
        //    {
        //        panel1.Visible = false;
        //        panel1.Visible = true;
        //        a = 1;
        //    }

        //}

        //private void button19_Click(object sender, EventArgs e)
        //{
        //    a--;
        //    panel1.Visible = false;
        //    panel2.Visible = false;
        //    panel3.Visible = false;
        //    panel4.Visible = false;
        //    panel5.Visible = false;
        //    panel6.Visible = false;


        //    if (a == 0)
        //    {
        //        a = 6;
        //    }
        //    if (a == 1)
        //    {
        //        panel1.Visible = true;

        //    }
        //    if (a == 2)
        //    {
        //        panel2.Visible = true;

        //    }
        //    if (a == 3)
        //    {
        //        panel3.Visible = true;

        //    }
        //    if (a == 4)
        //    {
        //        panel4.Visible = true;

        //    }
        //    if (a == 5)
        //    {
        //        panel5.Visible = true;

        //    }
        //    if (a == 6)
        //    {
        //        panel6.Visible = true;

        //    }
        //    if (a == 7)
        //    {
        //        panel1.Visible = false;
        //        panel1.Visible = true;
        //        a = 1;
        //    }
        //}

        private void button23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string anotekla = "2024";
            label4.Text = anotekla;
        }
       

        private void button20_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "144");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "141");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "143");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "146");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "147");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "149");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "184");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "185");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "129");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "24");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "65");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "44");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "146");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "103");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "101");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "116");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "117");
        }

       
        private void button37_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "110");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "53");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1041");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "1052");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "2");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "37");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "39");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "41");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "26");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "33");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "42");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "77");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "126");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "132");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "195");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "90");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "11");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "12");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Tekla.Structures.ModelInternal.Operation.dotStartCommand("ail_create_joint", "14");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var teklaHandler = new AppAbrirTekla();
            teklaHandler.TrazerTeklaParaFrente(
                new[] { VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT },
                VirtualKeyCode.F5
            ); ;

            label6.Text = "Macro Centro Gabarit excutada com sucesso!";
            timer.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var teklaHandler = new AppAbrirTekla();
            teklaHandler.TrazerTeklaParaFrente(
                new[] { VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT },
                VirtualKeyCode.VK_Z
            );

            label6.Text = "Macro elos para Madre Z excutada com sucesso!";
            timer.Start();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            var teklaHandler = new AppAbrirTekla();
            teklaHandler.TrazerTeklaParaFrente(
                new[] { VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT },
                VirtualKeyCode.VK_C
            );

            label6.Text = "Macro elos para Madre Z excutada com sucesso!";
            timer.Start();
        }


        private void button23_Click_1(object sender, EventArgs e)
        {
            var teklaHandler = new AppAbrirTekla();
            teklaHandler.TrazerTeklaParaFrente(
                new[] { VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT },
                VirtualKeyCode.VK_E
            );

            label6.Text = "Macro Esticadores excutada com sucesso!";
            timer.Start();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            var teklaHandler = new AppAbrirTekla();
            teklaHandler.TrazerTeklaParaFrente(
                new[] { VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT },
                VirtualKeyCode.F2
            );
            label6.Text = "Macro Mão de Amigo excutada com sucesso!";
            timer.Start();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            var teklaHandler = new AppAbrirTekla();
            teklaHandler.TrazerTeklaParaFrente(
                new[] { VirtualKeyCode.CONTROL, VirtualKeyCode.SHIFT },
                VirtualKeyCode.VK_L
            );
            label6.Text = "Macro Esticadores com Ligação excutada com sucesso!";
            timer.Start();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string caminhoExe = @"\\marconi\COMPANY SHARED FOLDER\OFELIZ\OFM\2.AN\2.CM\DP\4 Produção\Desenvolvimentos\52.superomegas-tekla\2021\WindowsFormsApp1.exe";

            if (System.IO.File.Exists(caminhoExe))
            {
                System.Diagnostics.Process.Start(caminhoExe);
            }
            else
            {
                MessageBox.Show(this, "O arquivo não foi encontrado: " + caminhoExe, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Visible = true;
        }

        public class AppAbrirTekla
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr GetWindowText(IntPtr hWnd, StringBuilder text, int count);

            [DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            const int SW_RESTORE = 5;

            public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

            private VirtualKeyCode[] _modifierKeys;
            private VirtualKeyCode _mainKey;

            public void TrazerTeklaParaFrente(VirtualKeyCode[] modifierKeys, VirtualKeyCode mainKey)
            {
                _modifierKeys = modifierKeys;
                _mainKey = mainKey;

                EnumWindows(new EnumWindowsProc(EnumWindowCallback), IntPtr.Zero);
            }

            private bool EnumWindowCallback(IntPtr hWnd, IntPtr lParam)
            {
                StringBuilder windowTitle = new StringBuilder(256);
                GetWindowText(hWnd, windowTitle, 256);

                if (windowTitle.ToString().StartsWith("Tekla Structures"))
                {
                    ShowWindow(hWnd, SW_RESTORE);
                    SetForegroundWindow(hWnd);
                    SimularTeclas(); 
                    return false;
                }

                return true;
            }

            private void SimularTeclas()
            {
                var simulator = new InputSimulator();
                simulator.Keyboard.ModifiedKeyStroke(_modifierKeys, _mainKey);
            }
        }


        private void CopiarAtalhos()
        {
            string nomedoutilisador = Environment.UserName;
            string anotekla = "2024.0";
            string origem = $@"\\marconi\OFELIZ\OFELIZ\OFM\2.AN\2.CM\DP\4 Produção\Desenvolvimentos\36.Ligaçõestekla\Copiar\{anotekla}\KeyboardShortcuts.xml";
            string destino = $@"C:\Users\{nomedoutilisador}\AppData\Local\Trimble\Tekla Structures\{anotekla}\Settings\KeyboardShortcuts.xml";

            try
            {
                if (File.Exists(destino))
                {
                    File.Delete(destino);
                }

                File.Copy(origem, destino);

                label5.Text = "Atalhos copiados com sucesso!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao copiar o ficheiro: " + ex.Message);
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            CopiarAtalhos();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); 

            LimparLabel();
        }

        private void LimparLabel()
        {
            label6.Text = string.Empty;
        }
    }

}




    

