namespace Comshark
{
    partial class frmPacketList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.timestamp,
            this.Interface,
            this.protocol,
            this.source,
            this.destination,
            this.length,
            this.info,
            this.valid});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 20;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1384, 391);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // number
            // 
            this.number.DataPropertyName = "Id";
            this.number.HeaderText = "No.";
            this.number.MinimumWidth = 20;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 50;
            // 
            // timestamp
            // 
            this.timestamp.DataPropertyName = "Time";
            this.timestamp.FillWeight = 200F;
            this.timestamp.HeaderText = "Time";
            this.timestamp.MinimumWidth = 150;
            this.timestamp.Name = "timestamp";
            this.timestamp.ReadOnly = true;
            this.timestamp.Width = 200;
            // 
            // Interface
            // 
            this.Interface.DataPropertyName = "Interface";
            this.Interface.HeaderText = "Interface";
            this.Interface.MinimumWidth = 50;
            this.Interface.Name = "Interface";
            this.Interface.ReadOnly = true;
            // 
            // protocol
            // 
            this.protocol.DataPropertyName = "Protocol";
            this.protocol.HeaderText = "Protocol";
            this.protocol.MinimumWidth = 80;
            this.protocol.Name = "protocol";
            this.protocol.ReadOnly = true;
            this.protocol.Width = 150;
            // 
            // source
            // 
            this.source.DataPropertyName = "Source";
            this.source.FillWeight = 70F;
            this.source.HeaderText = "Source";
            this.source.MinimumWidth = 50;
            this.source.Name = "source";
            this.source.ReadOnly = true;
            this.source.Width = 70;
            // 
            // destination
            // 
            this.destination.DataPropertyName = "Destination";
            this.destination.FillWeight = 70F;
            this.destination.HeaderText = "Destination";
            this.destination.MinimumWidth = 50;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 70;
            // 
            // length
            // 
            this.length.DataPropertyName = "Length";
            this.length.FillWeight = 50F;
            this.length.HeaderText = "Length";
            this.length.MinimumWidth = 20;
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Width = 50;
            // 
            // info
            // 
            this.info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.info.DataPropertyName = "Info";
            this.info.HeaderText = "Info";
            this.info.MinimumWidth = 50;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // valid
            // 
            this.valid.DataPropertyName = "Valid";
            this.valid.FillWeight = 50F;
            this.valid.HeaderText = "Valid";
            this.valid.MinimumWidth = 20;
            this.valid.Name = "valid";
            this.valid.ReadOnly = true;
            this.valid.Width = 50;
            // 
            // frmPacketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 391);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmPacketList";
            this.Text = "Packet List";
            this.Load += new System.EventHandler(this.frmPacketList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.DataGridViewTextBoxColumn valid;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}