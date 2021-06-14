using System;
using System.Windows.Forms;


namespace Desafio
{
    public partial class Form_Order : Form
    {
        private string filePath;
        private string filePathRead;
        private string filePathSaveM;
        private string filePathSaveF;
        private string filePathSaveH;

        private DateTime startProcess;
        private string allFileReading;

        private Path path;
        private ReadAllFile readAllFile;
        private CreateFile createFile;

        private SortGroup sortGroup;

        public Form_Order()
        {
            InitializeComponent();
        }

        private void btn_createFiles_Click(object sender, EventArgs e)
        {
            //iniciamos el proceso..... SE GUARDA EL MOMENTO EN QUE INICIA EL PROCESO
            startProcess = DateTime.Now;

            //leemos el archivo
            allFileReading = readAllFile.Read(filePathRead);

            //primero que el archivo no este vacio, si esta vacio crea historial, lo guarda y no continua.
            if (allFileReading != null)
            {
                BeginProcess();
            }
            else{
                FinalizeProcess();
            }          
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                InitAll();
                CreatePathsFiles();
            }          
        }

        public void InitAll()
        {
            filePath = "";
            filePathRead = "";
            filePathSaveM = "";
            filePathSaveF = "";
            filePathSaveH = "";

            allFileReading ="";

            path = new Path();
            readAllFile = new ReadAllFile();
            createFile = new CreateFile();

            sortGroup = new SortGroup();
        }

        //Comenzar el proceso de lectura y ordenado de datos. Ver de hacer clase para esto y ver que datos hay que pasarle y que retorna
        public void BeginProcess()
        {
            //guardamos en un array los registros separados, para evitar errores nomralizamos los datos y los ponemos todo en mayuscula
            allFileReading = allFileReading.ToUpper();
            string[] myText = allFileReading.Split('\n');

            sortGroup.InitGroups(myText);


            if (filePath != null)
            {
                //empezamos la creacion de los archivos de texto. ARMAR FUNCION PARA ESTO????
                string tempM="";
                string tempF = "";
                string tempH = "Historial";
                foreach (string item in sortGroup.Masculino())
                {
                    tempM += item +"\n";
                }
                createFile.Create(filePathSaveM, tempM, startProcess);

                foreach (string item in sortGroup.Femenino())
                {
                    tempF += item + "\n";
                }
                createFile.Create(filePathSaveF, tempF, startProcess);

                if(createFile.Create(filePathSaveH, tempH, startProcess, true, sortGroup.TotalRegOk(),sortGroup.TotalErr(),sortGroup.TotalReg(),sortGroup.TotalRep()))
                {
                    lbl_messages.Text = "Archivos creados en " + filePath;
                }
                else
                {
                    lbl_messages.Text = "Error al guardar en " + filePath;
                }               
            }
        }

        public void FinalizeProcess()
        {
            //solo se crea el archivo de historial pasando la info
            string tempH = "Historial" + " \n";
            tempH += string.Format("El archivo de origen '{0}' esta vacio o no pudo ser leido", filePathRead);
            createFile.Create(filePathSaveH, tempH, startProcess, true);
            lbl_messages.Text = "Hubo un error, Se genero solo Historial " + filePath;
        }

        public void CreatePathsFiles()
        {
            filePathRead = openFileDialog.FileName;
            lbl_pathFileTxt.Text = filePathRead;

            filePath = path.SettingPath(filePathRead);

            if (filePath != null)
            {
                filePathSaveM = filePath + "masculinos.txt";
                filePathSaveF = filePath + "femeninos.txt";
                filePathSaveH = filePath + "HISTORICO.txt";
                lbl_messages.Text = "Todo listo para comenzar";
                btn_createFiles.Enabled = true;
            }
            else
            {
                btn_createFiles.Enabled = false;
                lbl_messages.Text = "Error al crear ruta de guardado";
            }
        }

    }
}
