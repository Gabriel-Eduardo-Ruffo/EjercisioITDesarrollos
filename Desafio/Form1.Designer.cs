
namespace Desafio
{
    partial class Form_Order
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_createFiles = new System.Windows.Forms.Button();
            this.lbl_titlePath = new System.Windows.Forms.Label();
            this.txt_showRoute = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_pathFileTxt = new System.Windows.Forms.Label();
            this.lbl_messages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_createFiles
            // 
            this.btn_createFiles.Enabled = false;
            this.btn_createFiles.Location = new System.Drawing.Point(268, 119);
            this.btn_createFiles.Name = "btn_createFiles";
            this.btn_createFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_createFiles.TabIndex = 1;
            this.btn_createFiles.Text = "Crear";
            this.btn_createFiles.UseVisualStyleBackColor = true;
            this.btn_createFiles.Click += new System.EventHandler(this.btn_createFiles_Click);
            // 
            // lbl_titlePath
            // 
            this.lbl_titlePath.AutoSize = true;
            this.lbl_titlePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePath.Location = new System.Drawing.Point(12, 42);
            this.lbl_titlePath.Name = "lbl_titlePath";
            this.lbl_titlePath.Size = new System.Drawing.Size(90, 13);
            this.lbl_titlePath.TabIndex = 2;
            this.lbl_titlePath.Text = "Archivo a leer:";
            // 
            // txt_showRoute
            // 
            this.txt_showRoute.Location = new System.Drawing.Point(0, 0);
            this.txt_showRoute.Name = "txt_showRoute";
            this.txt_showRoute.Size = new System.Drawing.Size(100, 23);
            this.txt_showRoute.TabIndex = 6;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(74, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(195, 20);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Ejercicio IT-Desarrollos";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.txt";
            this.openFileDialog.Filter = "Archivos txt (*.txt)|*.txt";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(12, 119);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_pathFileTxt
            // 
            this.lbl_pathFileTxt.AutoSize = true;
            this.lbl_pathFileTxt.Location = new System.Drawing.Point(12, 55);
            this.lbl_pathFileTxt.Name = "lbl_pathFileTxt";
            this.lbl_pathFileTxt.Size = new System.Drawing.Size(98, 13);
            this.lbl_pathFileTxt.TabIndex = 7;
            this.lbl_pathFileTxt.Text = "Buscar archivo  .txt";
            // 
            // lbl_messages
            // 
            this.lbl_messages.AutoSize = true;
            this.lbl_messages.Location = new System.Drawing.Point(12, 85);
            this.lbl_messages.Name = "lbl_messages";
            this.lbl_messages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_messages.Size = new System.Drawing.Size(47, 13);
            this.lbl_messages.TabIndex = 8;
            this.lbl_messages.Text = "Mensaje";
            this.lbl_messages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(355, 154);
            this.Controls.Add(this.lbl_messages);
            this.Controls.Add(this.lbl_pathFileTxt);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_showRoute);
            this.Controls.Add(this.lbl_titlePath);
            this.Controls.Add(this.btn_createFiles);
            this.Name = "Form_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenar datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_createFiles;
        private System.Windows.Forms.Label lbl_titlePath;
        private System.Windows.Forms.Label txt_showRoute;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_pathFileTxt;
        private System.Windows.Forms.Label lbl_messages;
    }
}

