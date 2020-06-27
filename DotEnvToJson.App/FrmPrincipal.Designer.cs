namespace DotEnvToJson.App
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.BtnConverter = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.TxtJson = new System.Windows.Forms.TextBox();
            this.LblJson = new System.Windows.Forms.Label();
            this.LblEnvs = new System.Windows.Forms.Label();
            this.TxtEnvs = new System.Windows.Forms.TextBox();
            this.PnlBottom.SuspendLayout();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBottom
            // 
            this.PnlBottom.ColumnCount = 3;
            this.PnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.PnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlBottom.Controls.Add(this.BtnConverter, 1, 0);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 499);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.RowCount = 1;
            this.PnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.PnlBottom.Size = new System.Drawing.Size(784, 62);
            this.PnlBottom.TabIndex = 0;
            // 
            // BtnConverter
            // 
            this.BtnConverter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConverter.Location = new System.Drawing.Point(282, 3);
            this.BtnConverter.Name = "BtnConverter";
            this.BtnConverter.Size = new System.Drawing.Size(220, 56);
            this.BtnConverter.TabIndex = 1;
            this.BtnConverter.Text = "Converter";
            this.BtnConverter.UseVisualStyleBackColor = true;
            this.BtnConverter.Click += new System.EventHandler(this.BtnConverter_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.ColumnCount = 2;
            this.PnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PnlTop.Controls.Add(this.TxtJson, 0, 1);
            this.PnlTop.Controls.Add(this.LblJson, 1, 0);
            this.PnlTop.Controls.Add(this.LblEnvs, 0, 0);
            this.PnlTop.Controls.Add(this.TxtEnvs, 0, 1);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.RowCount = 2;
            this.PnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.PnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTop.Size = new System.Drawing.Size(784, 499);
            this.PnlTop.TabIndex = 1;
            // 
            // TxtJson
            // 
            this.TxtJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtJson.Location = new System.Drawing.Point(395, 25);
            this.TxtJson.Multiline = true;
            this.TxtJson.Name = "TxtJson";
            this.TxtJson.ReadOnly = true;
            this.TxtJson.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtJson.Size = new System.Drawing.Size(386, 471);
            this.TxtJson.TabIndex = 2;
            this.TxtJson.TabStop = false;
            // 
            // LblJson
            // 
            this.LblJson.AutoSize = true;
            this.LblJson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblJson.Location = new System.Drawing.Point(395, 0);
            this.LblJson.Name = "LblJson";
            this.LblJson.Size = new System.Drawing.Size(386, 22);
            this.LblJson.TabIndex = 0;
            this.LblJson.Text = "Json:";
            // 
            // LblEnvs
            // 
            this.LblEnvs.AutoSize = true;
            this.LblEnvs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEnvs.Location = new System.Drawing.Point(3, 0);
            this.LblEnvs.Name = "LblEnvs";
            this.LblEnvs.Size = new System.Drawing.Size(386, 22);
            this.LblEnvs.TabIndex = 0;
            this.LblEnvs.Text = "Envs:";
            // 
            // TxtEnvs
            // 
            this.TxtEnvs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtEnvs.Location = new System.Drawing.Point(3, 25);
            this.TxtEnvs.Multiline = true;
            this.TxtEnvs.Name = "TxtEnvs";
            this.TxtEnvs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtEnvs.Size = new System.Drawing.Size(386, 471);
            this.TxtEnvs.TabIndex = 0;
            this.TxtEnvs.Text = "ENV_1=123\r\n\r\nENV_2=\'aaa\'\r\n\r\n#comentário\r\nENV_3=abc";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.PnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Env to Json";
            this.PnlBottom.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlBottom;
        private System.Windows.Forms.Button BtnConverter;
        private System.Windows.Forms.TableLayoutPanel PnlTop;
        private System.Windows.Forms.Label LblJson;
        private System.Windows.Forms.Label LblEnvs;
        private System.Windows.Forms.TextBox TxtEnvs;
        private System.Windows.Forms.TextBox TxtJson;
    }
}

