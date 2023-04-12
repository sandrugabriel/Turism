using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Turism.Controllers;
using Turism.Models;

namespace Turism.Panel_uri
{
    internal class pnlVizionareExcursi:Panel
    {
        Button btnGenerare;
        TabControl tabControl1;
        TabPage planificari;
        DataGridView dataGridView1;
        DataGridViewTextBoxColumn name;
        DataGridViewTextBoxColumn dataStart;
        DataGridViewTextBoxColumn dataEnd;
        DataGridViewTextBoxColumn frecventa;
        DataGridViewTextBoxColumn ziua;
        TabPage perioadaViz;
        TabPage itinerariu;
        TabPage imagini;
        Label label2;
        DateTimePicker dateEnd;
        Label label1;
        DateTimePicker dateStart;
        DataGridView dataGridView2;
        DataGridViewTextBoxColumn nume1;
        DataGridViewTextBoxColumn dateStart1;
        DataGridViewTextBoxColumn dateStop1;
        DataGridViewTextBoxColumn frecventa1;
        DataGridViewTextBoxColumn ziua1;
        DataGridView dataGridView3;
        DataGridViewTextBoxColumn nume3;
        DataGridViewTextBoxColumn dateStart3;
        DataGridViewTextBoxColumn dateEnd3;
        DataGridViewTextBoxColumn frecventa3;
        DataGridViewTextBoxColumn ziua3;
        Button btnStart;
        ProgressBar prsBar;
        PictureBox pctImagine;
        Label lblData;
        Label lblNume;
        Timer timer;
        Button btnStop;

        Turism form;

        ControllerPlanificari controllerPlanificari;

        private List<Planificare> planificares;
        private List<Planificare> listItnierariu;

        public pnlVizionareExcursi(Turism form1) {

            form = form1;
            controllerPlanificari = new ControllerPlanificari();
            planificares = new List<Planificare>();
            listItnierariu = new List<Planificare>();
            timer = new Timer();
            this.form.Size = new System.Drawing.Size(960, 675);
            this.Size = new System.Drawing.Size(1212, 774);
            this.Name = "MockupVizionare";
            this.Text = "MockupVizionare";

            this.timer.Enabled = false;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Interval = 2000;

            this.btnGenerare = new Button();
            this.tabControl1 = new TabControl();
            this.planificari = new TabPage();
            this.dataGridView1 = new DataGridView();
            this.name = new DataGridViewTextBoxColumn();
            this.dataStart = new DataGridViewTextBoxColumn();
            this.dataEnd = new DataGridViewTextBoxColumn();
            this.frecventa = new DataGridViewTextBoxColumn();
            this.ziua = new DataGridViewTextBoxColumn();
            this.perioadaViz = new TabPage();
            this.itinerariu = new TabPage();
            this.imagini = new TabPage();
            this.label2 = new Label();
            this.dateEnd = new DateTimePicker();
            this.label1 = new Label();
            this.dateStart = new DateTimePicker();
            this.dataGridView2 = new DataGridView();
            this.nume1 = new DataGridViewTextBoxColumn();
            this.dateStart1 = new DataGridViewTextBoxColumn();
            this.dateStop1 = new DataGridViewTextBoxColumn();
            this.frecventa1 = new DataGridViewTextBoxColumn();
            this.ziua1 = new DataGridViewTextBoxColumn();
            this.dataGridView3 = new DataGridView();
            this.nume3 = new DataGridViewTextBoxColumn();
            this.dateStart3 = new DataGridViewTextBoxColumn();
            this.dateEnd3 = new DataGridViewTextBoxColumn();
            this.frecventa3 = new DataGridViewTextBoxColumn();
            this.ziua3 = new DataGridViewTextBoxColumn();
            this.btnStop = new Button();
            this.btnStart = new Button();
            this.lblNume = new Label();
            this.lblData = new Label();
            this.pctImagine = new PictureBox();
            this.prsBar = new ProgressBar();

            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStart);



            // btnGenerare
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.btnGenerare.Location = new System.Drawing.Point(733, 42);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(160, 49);
            this.btnGenerare.Text = "Generare Excursie";
            this.btnGenerare.Click += new EventHandler(btnGenerare_Click);
             
            // tabControl1
            this.tabControl1.Controls.Add(this.planificari);
            this.tabControl1.Controls.Add(this.perioadaViz);
            this.tabControl1.Controls.Add(this.itinerariu);
            this.tabControl1.Controls.Add(this.imagini);
            this.tabControl1.Location = new System.Drawing.Point(47, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(879, 484);
             
            // planificari
            this.planificari.Controls.Add(this.dataGridView1);
            this.planificari.Location = new System.Drawing.Point(4, 25);
            this.planificari.Name = "planificari";
            this.planificari.Size = new System.Drawing.Size(871, 455);
            this.planificari.Text = "Planificari";
            
            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.dataStart,
            this.dataEnd,
            this.frecventa,
            this.ziua});
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 426);

            planificares = controllerPlanificari.getAllList();
            listItnierariu = controllerPlanificari.getAllList();

            foreach (var plan in planificares)
            {
                if (plan.getFrecventa() == "ocazional")
                {
                    dataGridView1.Rows.Add(plan.getLocalitate(), plan.getDataStart(), plan.getDataEnd(), plan.getFrecventa());
                }
                else
                    dataGridView1.Rows.Add(plan.getLocalitate(), "","", plan.getFrecventa(), plan.getziua());
            }
            
            // name
            this.name.HeaderText = "Nume";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
             
            // dataStart
            this.dataStart.HeaderText = "Data Start";
            this.dataStart.MinimumWidth = 6;
            this.dataStart.Name = "dataStart";
            this.dataStart.ReadOnly = true;
            this.dataStart.Width = 125;
             
            // dataEnd
            this.dataEnd.HeaderText = "Data Stop";
            this.dataEnd.MinimumWidth = 6;
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.ReadOnly = true;
            this.dataEnd.Width = 125;
             
            // frecventa
            this.frecventa.HeaderText = "Frecventa";
            this.frecventa.MinimumWidth = 6;
            this.frecventa.Name = "frecventa";
            this.frecventa.ReadOnly = true;
            this.frecventa.Width = 125;
             
            // ziua
            this.ziua.HeaderText = "Ziua";
            this.ziua.MinimumWidth = 6;
            this.ziua.Name = "ziua";
            this.ziua.ReadOnly = true;
            this.ziua.Width = 125;
             
            // perioadaViz
            this.perioadaViz.Location = new System.Drawing.Point(4, 25);
            this.perioadaViz.Name = "perioadaViz";
            this.perioadaViz.Padding = new System.Windows.Forms.Padding(3);
            this.perioadaViz.Size = new System.Drawing.Size(871, 455);
            this.perioadaViz.Text = "Peroada de vizitare";
            
            // itinerariu
            this.itinerariu.Location = new System.Drawing.Point(4, 25);
            this.itinerariu.Name = "itinerariu";
            this.itinerariu.Size = new System.Drawing.Size(871, 455);
            this.itinerariu.Text = "Vizualizare itinerariu";
            
            // imagini

            this.imagini.Controls.Add(this.btnStart);
            this.imagini.Controls.Add(this.prsBar);
            this.imagini.Controls.Add(this.pctImagine);
            this.imagini.Controls.Add(this.lblData);
            this.imagini.Controls.Add(this.lblNume);
            this.imagini.Controls.Add(this.btnStop);
            this.imagini.Location = new System.Drawing.Point(4, 25);
            this.imagini.Name = "imagini";
            this.imagini.Size = new System.Drawing.Size(871, 455);
            this.imagini.Text = "Vizualizare imagini";
             
            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.label2.Location = new System.Drawing.Point(371, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.Text = "Finalul excursiei";
             
            // dateEnd
            this.dateEnd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.dateEnd.Location = new System.Drawing.Point(406, 58);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(274, 27);
             
            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.Text = "Inceputul excursiei";
             
            // dateStart
            this.dateStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.dateStart.Location = new System.Drawing.Point(47, 58);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(274, 27);


            // dataGridView2
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nume1,
            this.dateStart1,
            this.dateStop1,
            this.frecventa1,
            this.ziua1});
            this.dataGridView2.Location = new System.Drawing.Point(17, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(848, 431);
            this.perioadaViz.Controls.Add(dataGridView2);
            
            // nume1
            this.nume1.HeaderText = "Nume";
            this.nume1.MinimumWidth = 6;
            this.nume1.Name = "nume1";
            this.nume1.ReadOnly = true;
            this.nume1.Width = 125;
             
            // dateStart1
            this.dateStart1.HeaderText = "Data Start";
            this.dateStart1.MinimumWidth = 6;
            this.dateStart1.Name = "dateStart1";
            this.dateStart1.ReadOnly = true;
            this.dateStart1.Width = 125;
             
            // dateStop1
            this.dateStop1.HeaderText = "Data Stop";
            this.dateStop1.MinimumWidth = 6;
            this.dateStop1.Name = "dateStop1";
            this.dateStop1.ReadOnly = true;
            this.dateStop1.Width = 125;
             
            // frecventa1
            this.frecventa1.HeaderText = "Frecventa";
            this.frecventa1.MinimumWidth = 6;
            this.frecventa1.Name = "frecventa1";
            this.frecventa1.ReadOnly = true;
            this.frecventa1.Width = 125;
            
            // ziua1
            this.ziua1.HeaderText = "Ziua";
            this.ziua1.MinimumWidth = 6;
            this.ziua1.Name = "ziua1";
            this.ziua1.ReadOnly = true;
            this.ziua1.Width = 125;

            // dataGridView3
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nume3,
            this.dateStart3,
            this.dateEnd3,
            this.frecventa3,
            this.ziua3});
            this.dataGridView3.Location = new System.Drawing.Point(19, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(849, 433);
            this.itinerariu.Controls.Add(dataGridView3);
             
            // nume3
            this.nume3.HeaderText = "Nume";
            this.nume3.MinimumWidth = 6;
            this.nume3.Name = "nume3";
            this.nume3.ReadOnly = true;
            this.nume3.Width = 125;
             
            // dateStart3
            this.dateStart3.HeaderText = "Data Start";
            this.dateStart3.MinimumWidth = 6;
            this.dateStart3.Name = "dateStart3";
            this.dateStart3.ReadOnly = true;
            this.dateStart3.Width = 125;
             
            // dateEnd3
            this.dateEnd3.HeaderText = "Data Stop";
            this.dateEnd3.MinimumWidth = 6;
            this.dateEnd3.Name = "dateEnd3";
            this.dateEnd3.ReadOnly = true;
            this.dateEnd3.Width = 125;
            
            // frecventa3
            this.frecventa3.HeaderText = "Frecventa";
            this.frecventa3.MinimumWidth = 6;
            this.frecventa3.Name = "frecventa3";
            this.frecventa3.ReadOnly = true;
            this.frecventa3.Width = 125;
             
            // ziua3
            this.ziua3.HeaderText = "Ziua";
            this.ziua3.MinimumWidth = 6;
            this.ziua3.Name = "ziua3";
            this.ziua3.ReadOnly = true;
            this.ziua3.Width = 125;


            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.lblNume.Location = new System.Drawing.Point(50, 34);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(65, 27);
            this.lblNume.Text = "label3";
             
            // lblData
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.lblData.Location = new System.Drawing.Point(419, 34);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(65, 27);
            this.lblData.Text = "label4";
            
            // pctImagine
            this.pctImagine.Location = new System.Drawing.Point(23, 95);
            this.pctImagine.Name = "pctImagine";
            this.pctImagine.Size = new System.Drawing.Size(540, 318);
            this.pctImagine.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // prsBar
            this.prsBar.Location = new System.Drawing.Point(587, 111);
            this.prsBar.Name = "prsBar";
            this.prsBar.Size = new System.Drawing.Size(284, 43);
             
            // btnStart
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.btnStart.Location = new System.Drawing.Point(650, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 66);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new EventHandler(btnstart_Click);

            // btnStop
            this.btnStop.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.btnStop.Location = new System.Drawing.Point(650, 209);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(150, 66);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new EventHandler(btnstop_Click);
        }

        public void crescatoreNume(List<Planificare> list)
        {

            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(list[j].getLocalitate(), list[j + 1].getLocalitate()) > 0)
                    {

                        Planificare temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }


        }

        public void loadDataView()
        {
            dataGridView2.Rows.Clear();
            planificares = controllerPlanificari.getDateList(dateStart.Value,dateEnd.Value);
            crescatoreNume(planificares);
            foreach (var plan in planificares)
            {
                if (plan.getFrecventa() == "ocazional")
                {
                    dataGridView2.Rows.Add(plan.getLocalitate(), plan.getDataStart(), plan.getDataEnd(), plan.getFrecventa());
                }
                else
                    dataGridView2.Rows.Add(plan.getLocalitate(), plan.getDataStart(),plan.getDataStart(), plan.getFrecventa(), plan.getziua());
            }

        }

        public void crescatorDate(List<Planificare> list)
        {

            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j].getDataStart() > list[j + 1].getDataStart())
                    {

                        Planificare temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }


        }
      
        public void loadItinerariuView()
        {
            dataGridView3.Rows.Clear();
            listItnierariu = controllerPlanificari.getDateList(dateStart.Value, dateEnd.Value);
            crescatorDate(listItnierariu);
            foreach (var plan in listItnierariu)
            {
                if (plan.getFrecventa() == "ocazional")
                {
                    dataGridView3.Rows.Add(plan.getLocalitate(), plan.getDataStart(), plan.getDataEnd(), plan.getFrecventa());
                }
                else
                    dataGridView3.Rows.Add(plan.getLocalitate(), plan.getDataStart(), plan.getDataStart(), plan.getFrecventa(), plan.getziua());
            }

        }

        private void btnGenerare_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tabControl1.TabPages[1];
            loadItinerariuView();
            loadDataView();

        }
        private int i = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
           
            pctImagine.Image = Image.FromFile(Application.StartupPath + @"/Imagini/" +listItnierariu[i].getListImg()[i]);

            i++;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {

            timer.Enabled = true;
            btnStart.Visible = false;
            btnStop.Visible = true;

        }
        private void btnstop_Click(object sender, EventArgs e)
        {

            timer.Enabled = false;
            btnStop.Visible = false;
            btnStart.Visible = true;
        }

    }
}
