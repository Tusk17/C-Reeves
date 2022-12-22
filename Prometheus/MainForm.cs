using LearnKode.Irony;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LearnKode
{
    public partial class MainForm : Form
    {
        string fileLocation = "";
        string fileName = "";
        bool syntaxError = false;
        string a;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            tbCode.Language = FastColoredTextBoxNS.Language.CSharp;
            imgError.Visible = false;
            imgCorrecto.Visible = true;
            imgComienza.Visible = false;
            imgErrorSemantico.Visible = false;
            btnParse.Enabled = false;
            tbCode.Text = "import java.util.*;\r\n\r\npublic class App {\r\n    public static void main(String[] " +
    "args) {\r\n        // Tu código aquí\r\n        \r\n        System.out.println(\"Hola m" +
    "undo\");\r\n    }\r\n}\r\n";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public void HolaMundo()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class HolaMundo {\r\n    public static void main(String[] args) {" +
    "\r\n        // Prueba cambiar el mensaje\r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        \r\n        System.out.println(\"Hola mundo\");\r\n    }\r\n}\r\n";
        }
        public void Scanner()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class Escaneando {\r\n    public static void main(String[] args) {" +
    "\r\n // Prueba introducir un valor por teclado e imprimirlo \r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        String mensaje=\"Lo que escribas por teclado sustituira esto\";\r\n" +
    "\r\n        Scanner leer=new Scanner(System.in);\r\n" +
    "\r\n        mensaje=leer.nextLine();\r\n" +
    "\r\n        System.out.println(mensaje);\r\n    }\r\n}\r\n";
        }
        public void String()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class MidePalabra {\r\n    public static void main(String[] args) {" +
    "\r\n // Prueba introducir un palabra o mensaje dentro de la variable \r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        String mensaje=\"escribe aqui\";\r\n" +
    "\r\n        int A=mensaje.length();\r\n" +
    "\r\n        System.out.println(A);\r\n    }\r\n}\r\n";
        }
        public void If()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class Saludo {\r\n    public static void main(String[] args) {" +
    "\r\n // Prueba cambiar el valor de la variable booleana de true a false \r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        boolean mensaje=true;\r\n" +
    "\r\n        if (mensaje){\r\nSystem.out.println(\"Hola\");\n}else{\r\nSystem.out.println(\"Adios\");\n}\r\n" +
    "\r\n        \r\n    }\r\n}\r\n";
        }
        public void Switch()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class Apagador {\r\n    public static void main(String[] args) {" +
    "\r\n // Prueba cambiar el valor de la variable 'A', máximo 2 \r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        int a=0;\r\n" +
    "\r\n        switch (a){\r\n" +
    "case 0: System.out.println(\"Apagado\"); \r\n break;" +
    "\r\n case 1: System.out.println(\"Encendido\"); \r\n break; \r\n}\r\n" +
    "\r\n    }\r\n}\r\n";
        }
        public void While()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class Cuando {\r\n    public static void main(String[] args) {" +
    "\r\n /* Introduce un numero, uno mayor que 3, \r\npara que se pueda cerrar el programa*/ \r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        Scanner sc = new Scanner(System.in);\r\n" +
    "\r\n        int a=sc.nextInt();\r\n" +
    "\r\n        while(a<=3){\r\n" +
    "System.out.println(\"Numero insuficiente \"); " +
    "\r\n a = sc.nextInt(); }" +
        "\r\nSystem.out.println(\"Numero alcanzado, programa terminado \");" +
    "\r\n    }\r\n}\r\n";
        }
        public void DoWhile()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class HacerCuando {\r\n    public static void main(String[] args) {" +
    "\r\n /* Introduce un numero, uno mayor que 3, \r\npara que se pueda cerrar el programa*/ \r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        Scanner sc = new Scanner(System.in);\r\n" +
    "\r\n        int a=sc.nextInt();\r\n" +
    "\r\n        do{\r\n" +
    "System.out.println(\"Numero insuficiente \"); " +
    "\r\n a = sc.nextInt(); } while(a<=3);" +
        "\r\nSystem.out.println(\"Numero alcanzado, programa terminado \");" +
    "\r\n    }\r\n}\r\n";
        }
        public void For()
        {
            tbCode.Text = "import java.util.*;\r\n\r\npublic class Para {\r\n    public static void main(String[] args) {" +
    "\r\n /* Modifica los numeros de la variable i, \r\n para hacer que llegue de 0 a 100 en el intervalo que quieras*/ \r/* Recuerda guardar el archivo \rcon el mismo nombre de la clase*/" +
    "\r\n        for(int i=0;i<=100;i+=5){\r\n" +
    "\r\n        System.out.println(i);\r\n" +
    "\r\n        }\r\n" +
    "\r\n    }\r\n}\r\n";
        }
        private void AnalizeCode()
        {
            dgvLexer.Rows.Clear();
            foreach (TokenCode token in TokenTable.LexicalAnalysis(tbCode.Text))
            {
                if (token.Name == "ERROR")
                {
                    dgvLexer.Rows.Add(token.Name, token.Lexeme, token.Line, token.Column);
                }
                else
                {
                    if (token.Name != "SPACE" && token.Name != "IGNORE")
                    {
                        dgvLexer.Rows.Add(token.Name, token.Lexeme, token.Line, token.Column);
                    }
                }
            }
        }




        private void btnNewFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "Selecciona un archivo",
                Filter = "Archivos Java (*.java)|*.java",
                Title = "Carga tu código"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dialog.FileName);
                fileLocation = dialog.FileName.Replace(dialog.SafeFileName, "");
                fileName = dialog.SafeFileName;
                tbCode.Text = sr.ReadToEnd();
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (fileLocation == "")
            {
                var saveDialog = new SaveFileDialog()
                {
                    InitialDirectory = @"C:\",
                    Filter = "Archivos Java (*.java)|*.java",
                    DefaultExt = "java",
                    Title = "Guarda tu código antes de ejecutarlo",
                    CheckPathExists = true
                };
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveDialog.FileName != "")
                    {
                        string[] parts = saveDialog.FileName.Split('\\');
                        fileName = parts[parts.Length - 1];
                        fileLocation = saveDialog.FileName.Replace(fileName, "");
                        /*if (!fileName.Contains(PrototypeSemantic.codeClass))
                        {
                            MessageBox.Show("La clase y el archivo deben tener el mismo nombre", "Error al guardar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }*/
                        File.WriteAllText(saveDialog.FileName, tbCode.Text);
                    }
                }
            }
            else
            {
                string fullName = fileLocation + fileName;
                // causa errores al abrir y ejecutar directamente ->
                File.WriteAllText(fullName, tbCode.Text);
            }
            string strCmdText;
            strCmdText = " cd " + @fileLocation + " && javac " + fileName + " && java " + fileName.Replace(".java", "");
            consoleControl1.ClearOutput();
            if (consoleControl1.IsProcessRunning)
            {
                consoleControl1.WriteInput(strCmdText.Replace("/K", ""), consoleControl1.ForeColor, false);
            }
            else
            {
                a = strCmdText;
                ExecuteCommand(a);
            }
        }

        private void checkSemanthic()
        {
            string resultText = "";
            if (PrototypeSemantic.errors.Count > 0)
            {
                foreach (string error in PrototypeSemantic.errors)
                {
                    resultText += error + "\r\n";
                }
                tbSemanticResult.ForeColor = Color.FromArgb(255, 51, 86);
                imgErrorSemantico.Visible = true;
                lkode.ForeColor = Color.FromArgb(255, 51, 86);

                lineaEstado.BackColor = Color.FromArgb(255, 51, 86);
                dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 51, 86);
                btnParse.Enabled = false;
            }
            else
            {

                tbSemanticResult.ForeColor = Color.FromArgb(46, 204, 113);
                resultText = "No se encontraron errores\r\nAnálisis correcto\r\n";
                imgErrorSemantico.Visible = false;
                if (syntaxError)
                {
                    btnParse.Enabled = false;
                }
                else
                {
                    btnParse.Enabled = true;
                }
            }
            tbSemanticResult.Text = resultText;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inicio abrirPantallaCarga = new Inicio();
            abrirPantallaCarga.Show();
            this.Dispose();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            consoleControl1.StopProcess();
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tbCode.Text = "";
            dgvLexer.Rows.Clear();
            imgCorrecto.Visible = false;
            imgError.Visible = false;
            imgComienza.Visible = true;
            imgErrorSemantico.Visible = false;
            lineaEstado.BackColor = Color.FromArgb(255, 202, 40);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lkode_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            TutorialLearnKode AbrirTuto = new TutorialLearnKode();
            AbrirTuto.Show();
        }
        int contadorC = 0;
        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (contadorC % 2 == 0)
            {
                pictureBoxCerrar.Image = pictureBoxCerrar.Image = LearnKode.Properties.Resources.iconocerrar;
                pictureBoxMax.Image = pictureBoxMax.Image = LearnKode.Properties.Resources.iconomaximizar;
                pictureBoxMin.Image = pictureBoxMin.Image = LearnKode.Properties.Resources.iconominimizar;

                labelSemantico.ForeColor = Color.FromArgb(17, 30, 41);
                labelSintactico.ForeColor = Color.FromArgb(17, 30, 41);
                labelConsola.ForeColor = Color.FromArgb(17, 30, 41);
                tbCode.ForeColor = Color.FromArgb(0, 0, 0);
                tbCode.BackColor = Color.FromArgb(241, 241, 241);
                panelTodo.BackColor = Color.FromArgb(241, 241, 241);
                panel1.BackColor = Color.FromArgb(255, 255, 255);
                lLearn.ForeColor = Color.FromArgb(12, 21, 29);
                //datagrid view
                dgvLexer.GridColor = Color.FromArgb(255, 255, 255);
                dgvLexer.BackgroundColor = Color.FromArgb(255, 255, 255);
                dgvLexer.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                dgvLexer.DefaultCellStyle.ForeColor = Color.FromArgb(17, 30, 41);
                dgvLexer.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                dgvLexer.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);

                tbSemanticResult.BackColor = Color.FromArgb(255, 255, 255);
                tbSintaxResult.BackColor = Color.FromArgb(255, 255, 255);

            }
            else
            {
                pictureBoxCerrar.Image = pictureBoxCerrar.Image = LearnKode.Properties.Resources.iconocerrarblanco;
                pictureBoxMax.Image = pictureBoxMax.Image = LearnKode.Properties.Resources.iconomaximizarblanco;
                pictureBoxMin.Image = pictureBoxMin.Image = LearnKode.Properties.Resources.iconominimizarblanco;

                labelSemantico.ForeColor = Color.FromArgb(255, 255, 255);
                labelSintactico.ForeColor = Color.FromArgb(255, 255, 255);
                labelConsola.ForeColor = Color.FromArgb(255, 255, 255);
                tbCode.ForeColor = Color.FromArgb(255, 255, 255);
                tbCode.BackColor = Color.FromArgb(17, 30, 41);
                panelTodo.BackColor = Color.FromArgb(17, 30, 41);
                panel1.BackColor = Color.FromArgb(12, 21, 29);
                lLearn.ForeColor = Color.FromArgb(255, 255, 255);

                dgvLexer.GridColor = Color.FromArgb(17, 30, 41);
                dgvLexer.BackgroundColor = Color.FromArgb(17, 30, 41);
                dgvLexer.DefaultCellStyle.BackColor = Color.FromArgb(17, 30, 41);
                dgvLexer.DefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                dgvLexer.RowsDefaultCellStyle.BackColor = Color.FromArgb(12, 21, 29);
                dgvLexer.RowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);

                tbSemanticResult.BackColor = Color.FromArgb(12, 21, 29);
                tbSintaxResult.BackColor = Color.FromArgb(12, 21, 29);


            }
            contadorC++;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            TutorialLearnKode AbrirTuto = new TutorialLearnKode();
            AbrirTuto.Show();
        }

        private void imgError_Click(object sender, EventArgs e)
        {
            DetallesErrorSintactico abrirDetallesSintactico = new DetallesErrorSintactico();
            abrirDetallesSintactico.Show();
            //click imagen error
        }

        private void imgErrorSemantico_Click(object sender, EventArgs e)
        {
            DetallesErrorSemantico abrirDetallesSemantico = new DetallesErrorSemantico();
            abrirDetallesSemantico.Show();
        }

        public void ExecuteCommand(string _Command)
        {
            //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
            //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
            //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 

            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + _Command);
            // Indicamos que la salida del proceso se redireccione en un Stream
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = false;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
            string result = proc.StandardOutput.ReadToEnd();
            //Muestra en pantalla la salida del Comando
            consoleControl1.WriteOutput("La salida del programa es: "+result,Color.Green);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (tbCode.Text == "")
            {
                imgComienza.Visible = true;
                imgError.Visible = false;
                imgCorrecto.Visible = false;
                imgErrorSemantico.Visible = false;
                dgvLexer.Rows.Clear();
                lineaEstado.BackColor = Color.FromArgb(255, 202, 40);
                dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 202, 40);

            }
            else
            {
                AnalizeCode();
                tbSintaxResult.Text = "";
                PrototypeParser.errors = "";
                PrototypeParser.treeText = "";
                bool result = PrototypeParser.Parse(tbCode.Text);
                string resultText;
                if (result)
                {
                    tbSintaxResult.ForeColor = Color.FromArgb(46, 204, 113);
                    lkode.ForeColor = Color.FromArgb(46, 204, 113);

                    lineaEstado.BackColor = Color.FromArgb(46, 204, 113);

                    resultText = "No se encontraron errores\r\nAnálisis correcto\r\n";
                    imgCorrecto.Visible = true;
                    imgComienza.Visible = false;
                    imgError.Visible = false;
                    dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
                    resultText += "\r\n=====ÁRBOL=====\r\n";
                    resultText += PrototypeParser.treeText;
                    syntaxError = false;
                }
                else
                {
                    lkode.ForeColor = Color.FromArgb(255, 51, 86);
                    dgvLexer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 51, 86);
                    tbSintaxResult.ForeColor = Color.FromArgb(255, 51, 86);
                    resultText = PrototypeParser.errors;
                    imgCorrecto.Visible = false;
                    imgComienza.Visible = false;
                    imgError.Visible = true;
                    lineaEstado.BackColor = Color.FromArgb(255, 51, 86);
                    syntaxError = true;
                }
                checkSemanthic();
                tbSintaxResult.Text = resultText;
                PrototypeSemantic.errors.Clear();
            }
        }
    }
}
