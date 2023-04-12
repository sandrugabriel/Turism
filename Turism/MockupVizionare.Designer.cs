namespace Turism
{
    partial class MockupVizionare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerare = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.planificari = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ziua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perioadaViz = new System.Windows.Forms.TabPage();
            this.itinerariu = new System.Windows.Forms.TabPage();
            this.imagini = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nume1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStart1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecventa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ziua1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nume3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStart3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnd3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecventa3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ziua3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.planificari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.perioadaViz.SuspendLayout();
            this.itinerariu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerare
            // 
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerare.Location = new System.Drawing.Point(733, 42);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(189, 59);
            this.btnGenerare.TabIndex = 12;
            this.btnGenerare.Text = "Generare Excursie";
            this.btnGenerare.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.planificari);
            this.tabControl1.Controls.Add(this.perioadaViz);
            this.tabControl1.Controls.Add(this.itinerariu);
            this.tabControl1.Controls.Add(this.imagini);
            this.tabControl1.Location = new System.Drawing.Point(47, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 484);
            this.tabControl1.TabIndex = 11;
            // 
            // planificari
            // 
            this.planificari.Controls.Add(this.dataGridView1);
            this.planificari.Location = new System.Drawing.Point(4, 25);
            this.planificari.Name = "planificari";
            this.planificari.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.planificari.Size = new System.Drawing.Size(871, 455);
            this.planificari.TabIndex = 0;
            this.planificari.Text = "Planificari";
            this.planificari.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Size = new System.Drawing.Size(847, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Nume";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // dataStart
            // 
            this.dataStart.HeaderText = "Data Start";
            this.dataStart.MinimumWidth = 6;
            this.dataStart.Name = "dataStart";
            this.dataStart.ReadOnly = true;
            this.dataStart.Width = 125;
            // 
            // dataEnd
            // 
            this.dataEnd.HeaderText = "Data Stop";
            this.dataEnd.MinimumWidth = 6;
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.ReadOnly = true;
            this.dataEnd.Width = 125;
            // 
            // frecventa
            // 
            this.frecventa.HeaderText = "Frecventa";
            this.frecventa.MinimumWidth = 6;
            this.frecventa.Name = "frecventa";
            this.frecventa.ReadOnly = true;
            this.frecventa.Width = 125;
            // 
            // ziua
            // 
            this.ziua.HeaderText = "Ziua";
            this.ziua.MinimumWidth = 6;
            this.ziua.Name = "ziua";
            this.ziua.ReadOnly = true;
            this.ziua.Width = 125;
            // 
            // perioadaViz
            // 
            this.perioadaViz.Controls.Add(this.dataGridView2);
            this.perioadaViz.Location = new System.Drawing.Point(4, 25);
            this.perioadaViz.Name = "perioadaViz";
            this.perioadaViz.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.perioadaViz.Size = new System.Drawing.Size(871, 455);
            this.perioadaViz.TabIndex = 1;
            this.perioadaViz.Text = "Peroada de vizitare";
            this.perioadaViz.UseVisualStyleBackColor = true;
            // 
            // itinerariu
            // 
            this.itinerariu.Controls.Add(this.dataGridView3);
            this.itinerariu.Location = new System.Drawing.Point(4, 25);
            this.itinerariu.Name = "itinerariu";
            this.itinerariu.Size = new System.Drawing.Size(871, 455);
            this.itinerariu.TabIndex = 2;
            this.itinerariu.Text = "Vizualizare itinerariu";
            this.itinerariu.UseVisualStyleBackColor = true;
            // 
            // imagini
            // 
            this.imagini.Location = new System.Drawing.Point(4, 25);
            this.imagini.Name = "imagini";
            this.imagini.Size = new System.Drawing.Size(871, 455);
            this.imagini.TabIndex = 3;
            this.imagini.Text = "Vizualizare imagini";
            this.imagini.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Finalul excursiei";
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(406, 58);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(274, 27);
            this.dateEnd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Inceputul excursiei";
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(47, 58);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(274, 27);
            this.dateStart.TabIndex = 7;
            // 
            // dataGridView2
            // 
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
            this.dataGridView2.TabIndex = 1;
            // 
            // nume1
            // 
            this.nume1.HeaderText = "Nume";
            this.nume1.MinimumWidth = 6;
            this.nume1.Name = "nume1";
            this.nume1.ReadOnly = true;
            this.nume1.Width = 125;
            // 
            // dateStart1
            // 
            this.dateStart1.HeaderText = "Data Start";
            this.dateStart1.MinimumWidth = 6;
            this.dateStart1.Name = "dateStart1";
            this.dateStart1.ReadOnly = true;
            this.dateStart1.Width = 125;
            // 
            // dateStop1
            // 
            this.dateStop1.HeaderText = "Data Stop";
            this.dateStop1.MinimumWidth = 6;
            this.dateStop1.Name = "dateStop1";
            this.dateStop1.ReadOnly = true;
            this.dateStop1.Width = 125;
            // 
            // frecventa1
            // 
            this.frecventa1.HeaderText = "Frecventa";
            this.frecventa1.MinimumWidth = 6;
            this.frecventa1.Name = "frecventa1";
            this.frecventa1.ReadOnly = true;
            this.frecventa1.Width = 125;
            // 
            // ziua1
            // 
            this.ziua1.HeaderText = "Ziua";
            this.ziua1.MinimumWidth = 6;
            this.ziua1.Name = "ziua1";
            this.ziua1.ReadOnly = true;
            this.ziua1.Width = 125;
            // 
            // dataGridView3
            // 
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
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // nume3
            // 
            this.nume3.HeaderText = "Nume";
            this.nume3.MinimumWidth = 6;
            this.nume3.Name = "nume3";
            this.nume3.ReadOnly = true;
            this.nume3.Width = 125;
            // 
            // dateStart3
            // 
            this.dateStart3.HeaderText = "Data Start";
            this.dateStart3.MinimumWidth = 6;
            this.dateStart3.Name = "dateStart3";
            this.dateStart3.ReadOnly = true;
            this.dateStart3.Width = 125;
            // 
            // dateEnd3
            // 
            this.dateEnd3.HeaderText = "Data Stop";
            this.dateEnd3.MinimumWidth = 6;
            this.dateEnd3.Name = "dateEnd3";
            this.dateEnd3.ReadOnly = true;
            this.dateEnd3.Width = 125;
            // 
            // frecventa3
            // 
            this.frecventa3.HeaderText = "Frecventa";
            this.frecventa3.MinimumWidth = 6;
            this.frecventa3.Name = "frecventa3";
            this.frecventa3.ReadOnly = true;
            this.frecventa3.Width = 125;
            // 
            // ziua3
            // 
            this.ziua3.HeaderText = "Ziua";
            this.ziua3.MinimumWidth = 6;
            this.ziua3.Name = "ziua3";
            this.ziua3.ReadOnly = true;
            this.ziua3.Width = 125;
            // 
            // MockupVizionare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 627);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateStart);
            this.Name = "MockupVizionare";
            this.Text = "MockupVizionare";
            this.tabControl1.ResumeLayout(false);
            this.planificari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.perioadaViz.ResumeLayout(false);
            this.itinerariu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerare;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage planificari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziua;
        private System.Windows.Forms.TabPage perioadaViz;
        private System.Windows.Forms.TabPage itinerariu;
        private System.Windows.Forms.TabPage imagini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStop1;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecventa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziua1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStart3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnd3;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecventa3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziua3;
    }
}