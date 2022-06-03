using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tp_desktop
{
    public partial class Form2 : Form
    {
        string archivo;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                archivo = openFile.FileName;
                textBox1.Text = archivo;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string aux="";

            if (rbtnMp4.Checked)
            {
                aux= rbtnMp4.Text;
            } 
            else if (rbtnAvi.Checked) 
            {
                aux= rbtnAvi.Text;
            }
            else if (rbtnMov.Checked) 
            {
                aux= rbtnMov.Text;
            }
            else if (rbtnWmv.Checked) 
            {
                aux= rbtnWmv.Text;
            } 
            

            if(aux!="")
            {
                //Convertir(textBox1.Text, aux, ruta());

                Ffmepeg(textBox1.Text,"", "archivo convertido."+aux+"\"");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un formato para convertir", "Error");
            }
        }
        

       

        private void btnExtraerAudio_Click(object sender, EventArgs e)
        {
            Ffmepeg(textBox1.Text, "-vn -acodec mp3", "audio extraido.mp3" + "\"");
        }

        private void btnCambiarResolucion_Click(object sender, EventArgs e)
        {
            Ffmepeg(textBox1.Text, "-vf scale=250:100");//en otro cuadro la resolucion
        }

        private void btnRemoverAudio_Click(object sender, EventArgs e)
        {
            Ffmepeg(textBox1.Text, "-c copy -an");
        }

        private void btnExtraerImagen_Click(object sender, EventArgs e)
        {
            int num = 5;//cuadro

            string path = ruta() + "\\capturas\\";

            Directory.CreateDirectory(path);

            Ffmepeg(textBox1.Text, "-vf \"select = not(mod(n\\, "+num+"))\" -vsync 0", "\"" + path + "captura-%03d.png" + "\"", true);
        }


        public string ruta()
        {
            string rutas = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                folder.Description = "Guardar en: ";
                rutas = folder.SelectedPath;
            }
            return rutas;
        }

        public void Ffmepeg(string pathOr, string comando, string pathFi = "", bool completePath = false)
        {
            string[] output = new string[2];
            string aux;
            string path = "";

            if (pathFi == "")
                pathFi = textBox1.Text.Substring(textBox1.Text.LastIndexOf("\\")) + "\"";

            if (!completePath)
                path = "\"" + ruta() + "\\";


            aux = $"/c ffmpeg -i \"{pathOr}\" " + comando + " -y " + path + pathFi;

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Minimized,
                Arguments = aux,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            using (Process exeProcess = Process.Start(startInfo))
            {

                output[0] = exeProcess.StandardOutput.ReadToEnd();
                output[1] = exeProcess.StandardError.ReadToEnd();

                exeProcess.WaitForExit();
            }


            if (output[0] == "")
                MessageBox.Show("Se realizo con exito el comando: \n" + aux, "aceptar");
            else
                MessageBox.Show(output[1], "aceptar");

            textBox1.Text = "";

        }
    }
}
