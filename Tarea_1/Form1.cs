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

namespace Tarea_1
{
    public partial class Form1 : Form
    {

        String rutaArchivo;
        String nombre;
        String nombreInterprete = "Interprete Mamalon";

        public Form1()
        {
            InitializeComponent();
        }

        private void botonAbrirArchivo_Click(object sender, EventArgs e)
        {
            Stream Flujo;
            OpenFileDialog DialogoAbrirArchivo = new OpenFileDialog();
            DialogoAbrirArchivo.Filter = "(*.lt1)|*.lt1";
            if (DialogoAbrirArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                               
                if ( (Flujo = DialogoAbrirArchivo.OpenFile() )!= null )
                {
                    rutaArchivo = DialogoAbrirArchivo.FileName;
                    nombre = DialogoAbrirArchivo.SafeFileName;                    
                    String textoArchivo = File.ReadAllText(rutaArchivo);                  
                    areaEditor.Text = textoArchivo;
                    Form1.ActiveForm.Text = nombre + " - " + nombreInterprete; 
                    Flujo.Close();
                }
                else
                {
                    areaErrores.Text = "Error abrir Archivo";
                }            
            }
            else
            {
                areaErrores.Text = "Error al abrir dialogo abrir (valgame la redundancia xd)";
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {            
            if ( (areaEditor.Text).Length == 0)
            {
                areaErrores.Text = "No hay codigo que guardar";
            }
            else
            {                      
                if (File.Exists(rutaArchivo))
                {
                    File.WriteAllText(rutaArchivo, areaEditor.Text);
                    areaErrores.Text = nombre + " Guardado con Exito";
                }
                else
                {
                    SaveFileDialog dialogoGuardar = new SaveFileDialog();
                    dialogoGuardar.AddExtension = true;
                    dialogoGuardar.DefaultExt = ".lt1";
                    dialogoGuardar.Filter = "(*.lt1)|*.lt1";
                    if (dialogoGuardar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        rutaArchivo = dialogoGuardar.FileName;
                        //Inicio Codigo para sacar Nombre (Eliminar si se encuentra otra manera)
                        String[] partesNombre = rutaArchivo.Split('\\');
                        nombre = partesNombre[partesNombre.Length - 1];
                        //Fin Codigo para sacar Nombre (Eliminar si se encuentra otra manera)
                        Form1.ActiveForm.Text = nombre + " - " + nombreInterprete;
                        File.WriteAllText(rutaArchivo, areaEditor.Text);
                    }
                    else
                    {
                        areaErrores.Text = "No se abrio dialogo guardar";
                    }
                }                                                                                                             
            }
        }

        private void botonEjecutar_Click(object sender, EventArgs e)
        {

        }

        private void botonNuevoArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.AddExtension = true;
            dialogoGuardar.DefaultExt = ".lt1";
            dialogoGuardar.Filter = "(*.lt1)|*.lt1";
      
            
            if (dialogoGuardar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                                   
                rutaArchivo = dialogoGuardar.FileName;
                //Inicio Codigo para sacar Nombre (Eliminar si se encuentra otra manera)
                String[] partesNombre = rutaArchivo.Split('\\');
                nombre = partesNombre[partesNombre.Length - 1];
                //Fin Codigo para sacar Nombre (Eliminar si se encuentra otra manera)
                Form1.ActiveForm.Text = nombre + " - " + nombreInterprete;
                areaEditor.Text = "";
                File.WriteAllText(rutaArchivo,areaEditor.Text);
               

            }
            else
            {
                areaErrores.Text = "No se abrio dialogo guardar";
            }

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
