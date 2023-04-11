using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turism.Controllers;

namespace Turism.Panel_uri
{
    internal class pnlGenerarePoster : Panel
    {

        ComboBox cmbLocalitate;
        Label lblLocalitate;
        Label lblImagine;
        ComboBox cmbImagine;
        Button btnAddImg;
        ListBox listImagini;
        Label lblTitlu;
        TextBox txtTitlu;
        PictureBox pctImagine;
        Button btnGenerarePoster;
        SaveFileDialog saveFileDialog1;

        ControllerPlanificari controllerPlanificari;

        private List<string> listLocalitate;

        public pnlGenerarePoster()
        {
            controllerPlanificari = new ControllerPlanificari();
            listLocalitate = new List<string>();
            this.Size = new System.Drawing.Size(1025, 728);
            this.Name = "pnlGenerarePoster";
            this.Text = "Generare Poster";

            this.cmbLocalitate = new ComboBox();
            this.lblLocalitate = new Label();
            this.lblImagine = new Label();
            this.cmbImagine = new ComboBox();
            this.btnAddImg = new Button();
            this.listImagini = new ListBox();
            this.lblTitlu = new Label();
            this.txtTitlu = new TextBox();
            this.pctImagine = new PictureBox();
            this.btnGenerarePoster = new Button();
            this.saveFileDialog1 = new SaveFileDialog();
            this.Controls.Add(this.btnGenerarePoster);
            this.Controls.Add(this.pctImagine);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.listImagini);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.lblImagine);
            this.Controls.Add(this.cmbImagine);
            this.Controls.Add(this.lblLocalitate);
            this.Controls.Add(this.cmbLocalitate);

            // cmbLocalitate
            this.cmbLocalitate.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.cmbLocalitate.Location = new System.Drawing.Point(39, 116);
            this.cmbLocalitate.Name = "cmbLocalitate";
            this.cmbLocalitate.Size = new System.Drawing.Size(202, 35);
            this.cmbLocalitate.Text = "Toate";
            this.cmbLocalitate.SelectedIndexChanged += new EventHandler(cmbLocalitate_Select);

            // lblLocalitate
            this.lblLocalitate.AutoSize = true;
            this.lblLocalitate.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblLocalitate.Location = new System.Drawing.Point(67, 66);
            this.lblLocalitate.Name = "lblLocalitate";
            this.lblLocalitate.Size = new System.Drawing.Size(149, 36);
            this.lblLocalitate.Text = "Localitatea";

            // lblImagine
            this.lblImagine.AutoSize = true;
            this.lblImagine.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblImagine.Location = new System.Drawing.Point(78, 208);
            this.lblImagine.Name = "lblImagine";
            this.lblImagine.Size = new System.Drawing.Size(116, 36);
            this.lblImagine.Text = "Imagine";

            // cmbImagine
            this.cmbImagine.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.cmbImagine.Location = new System.Drawing.Point(39, 263);
            this.cmbImagine.Name = "cmbImagine";
            this.cmbImagine.Size = new System.Drawing.Size(202, 35);
            this.cmbImagine.SelectedIndexChanged += new EventHandler(cmbImg_Select);

            // btnAddImg
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.btnAddImg.Location = new System.Drawing.Point(55, 336);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(186, 49);
            this.btnAddImg.Text = "Adauga imaginea";
            this.btnAddImg.Click += new EventHandler(btnAddImg_Click);

            // listImagini
            this.listImagini.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.8F);
            this.listImagini.Location = new System.Drawing.Point(39, 437);
            this.listImagini.Name = "listImagini";
            this.listImagini.Size = new System.Drawing.Size(230, 124);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F);
            this.lblTitlu.Location = new System.Drawing.Point(366, 27);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(81, 36);
            this.lblTitlu.Text = "Titlul ";

            // txtTitlu
            this.txtTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txtTitlu.Location = new System.Drawing.Point(465, 31);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(303, 34);
            this.txtTitlu.TabIndex = 7;

            // pctImagine
            this.pctImagine.Location = new System.Drawing.Point(320, 126);
            this.pctImagine.Name = "pctImagine";
            this.pctImagine.Size = new System.Drawing.Size(480, 308);
            this.pctImagine.SizeMode = PictureBoxSizeMode.StretchImage;

            // btnGenerarePoster
            this.btnGenerarePoster.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.btnGenerarePoster.Location = new System.Drawing.Point(445, 487);
            this.btnGenerarePoster.Name = "btnGenerarePoster";
            this.btnGenerarePoster.Size = new System.Drawing.Size(208, 61);
            this.btnGenerarePoster.Text = "Genereaza posterul";
            this.btnGenerarePoster.Click += new EventHandler(genereazaPosterBtn_Click);


            loadComboLocalitati();

        }

        public void loadComboLocalitati()
        {

            listLocalitate = controllerPlanificari.getListLoc();

            foreach (string s in listLocalitate)
            {
                cmbLocalitate.Items.Add(s);
            }


        }

        private List<string> listImg = new List<string>();

        private void cmbLocalitate_Select(object sender, System.EventArgs e)
        {
            cmbImagine.Items.Clear();

            string select = cmbLocalitate.SelectedItem.ToString();

            listImg = controllerPlanificari.getImgList(select);

            foreach (string s in listImg)
            {
                cmbImagine.Items.Add(s);
            }

        }

        private string select;

        private void cmbImg_Select(object sender, System.EventArgs e)
        {
            select = cmbImagine.SelectedItem.ToString();

            pctImagine.Image = Image.FromFile(Application.StartupPath + @"/Imagini/"+select);
            
        }

        List<string> listGenerare = new List<string>();

        private void btnAddImg_Click(object sender, System.EventArgs e)
        {

            listImagini.Items.Add(select);
            listGenerare.Add(select);
            

        }

        private void genereazaPosterBtn_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "PNG Image|*.png";

            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                string caleFisier = saveFileDialog1.FileName;
                string numeFisier = Path.GetFileNameWithoutExtension(caleFisier);

                Directory.CreateDirectory(Path.GetDirectoryName(caleFisier));

                foreach (string numeImagine in listGenerare)
                {
                    string caleImagine = Path.Combine("Imagini", numeImagine);
                    string caleImagineDestinatie = Path.Combine(Path.GetDirectoryName(caleFisier), numeImagine);
                    File.Copy(caleImagine, caleImagineDestinatie);
                }
            }
        }

    }
}
