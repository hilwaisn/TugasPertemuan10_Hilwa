namespace TugasPertemuan10_Hilwa
{
    partial class store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(store));
            this.lblStore = new System.Windows.Forms.Label();
            this.dataStore = new System.Windows.Forms.DataGridView();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnKat = new System.Windows.Forms.Button();
            this.btnPel = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.BackColor = System.Drawing.Color.Transparent;
            this.lblStore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStore.Location = new System.Drawing.Point(281, 203);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(553, 134);
            this.lblStore.TabIndex = 0;
            this.lblStore.Text = "WELCOME TO STORE\r\nKE50NG0";
            this.lblStore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataStore
            // 
            this.dataStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStore.Location = new System.Drawing.Point(130, 471);
            this.dataStore.Name = "dataStore";
            this.dataStore.RowHeadersWidth = 62;
            this.dataStore.RowTemplate.Height = 28;
            this.dataStore.Size = new System.Drawing.Size(848, 334);
            this.dataStore.TabIndex = 1;
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSup.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSup.Location = new System.Drawing.Point(179, 366);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(128, 57);
            this.btnSup.TabIndex = 2;
            this.btnSup.Text = "Supplier";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnKat
            // 
            this.btnKat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKat.Location = new System.Drawing.Point(371, 366);
            this.btnKat.Name = "btnKat";
            this.btnKat.Size = new System.Drawing.Size(128, 57);
            this.btnKat.TabIndex = 3;
            this.btnKat.Text = "Kategori";
            this.btnKat.UseVisualStyleBackColor = false;
            this.btnKat.Click += new System.EventHandler(this.btnKat_Click);
            // 
            // btnPel
            // 
            this.btnPel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPel.Location = new System.Drawing.Point(570, 366);
            this.btnPel.Name = "btnPel";
            this.btnPel.Size = new System.Drawing.Size(138, 57);
            this.btnPel.TabIndex = 4;
            this.btnPel.Text = "Pelanggan";
            this.btnPel.UseVisualStyleBackColor = false;
            this.btnPel.Click += new System.EventHandler(this.btnPel_Click);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPro.Location = new System.Drawing.Point(773, 366);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(128, 57);
            this.btnPro.TabIndex = 5;
            this.btnPro.Text = "Produk";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TugasPertemuan10_Hilwa.Properties.Resources.Balibaris_store__Paris;
            this.ClientSize = new System.Drawing.Size(1063, 806);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.btnPel);
            this.Controls.Add(this.btnKat);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.dataStore);
            this.Controls.Add(this.lblStore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "store";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.DataGridView dataStore;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnKat;
        private System.Windows.Forms.Button btnPel;
        private System.Windows.Forms.Button btnPro;
    }
}

