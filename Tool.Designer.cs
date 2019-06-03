namespace Payload_ELF_Injector
{
    partial class Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tool));
            this.SelectELF_Button = new System.Windows.Forms.Button();
            this.ELFInjection_GroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshProcesses_Button = new System.Windows.Forms.Button();
            this.Proccesses_ComboBox = new System.Windows.Forms.ComboBox();
            this.InjectELF_Button = new System.Windows.Forms.Button();
            this.Connection_GroupBox = new System.Windows.Forms.GroupBox();
            this.InjectjkPatch_Button = new System.Windows.Forms.Button();
            this.ConnectPS4_Button = new System.Windows.Forms.Button();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.PayloadInjection_GroupBox = new System.Windows.Forms.GroupBox();
            this.InjectPayload_Button = new System.Windows.Forms.Button();
            this.SelectPayload_Button = new System.Windows.Forms.Button();
            this.CurrentStatus_Label = new System.Windows.Forms.Label();
            this.OpenPayloadDialog = new System.Windows.Forms.OpenFileDialog();
            this.Status_Label = new System.Windows.Forms.Label();
            this.OpenELFDialog = new System.Windows.Forms.OpenFileDialog();
            this.jkPatch_BGWorker = new System.ComponentModel.BackgroundWorker();
            this.Payload_BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ELF_BGWorker = new System.ComponentModel.BackgroundWorker();
            this.ELFInjection_GroupBox.SuspendLayout();
            this.Connection_GroupBox.SuspendLayout();
            this.PayloadInjection_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectELF_Button
            // 
            this.SelectELF_Button.Location = new System.Drawing.Point(7, 19);
            this.SelectELF_Button.Name = "SelectELF_Button";
            this.SelectELF_Button.Size = new System.Drawing.Size(140, 23);
            this.SelectELF_Button.TabIndex = 0;
            this.SelectELF_Button.TabStop = false;
            this.SelectELF_Button.Text = "Select ELF";
            this.SelectELF_Button.UseVisualStyleBackColor = true;
            this.SelectELF_Button.Click += new System.EventHandler(this.SelectELF_Button_Click);
            // 
            // ELFInjection_GroupBox
            // 
            this.ELFInjection_GroupBox.Controls.Add(this.RefreshProcesses_Button);
            this.ELFInjection_GroupBox.Controls.Add(this.Proccesses_ComboBox);
            this.ELFInjection_GroupBox.Controls.Add(this.InjectELF_Button);
            this.ELFInjection_GroupBox.Controls.Add(this.SelectELF_Button);
            this.ELFInjection_GroupBox.Location = new System.Drawing.Point(329, 3);
            this.ELFInjection_GroupBox.Name = "ELFInjection_GroupBox";
            this.ELFInjection_GroupBox.Size = new System.Drawing.Size(152, 106);
            this.ELFInjection_GroupBox.TabIndex = 0;
            this.ELFInjection_GroupBox.TabStop = false;
            this.ELFInjection_GroupBox.Text = "ELF Injection";
            // 
            // RefreshProcesses_Button
            // 
            this.RefreshProcesses_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshProcesses_Button.BackgroundImage")));
            this.RefreshProcesses_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshProcesses_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RefreshProcesses_Button.Location = new System.Drawing.Point(123, 49);
            this.RefreshProcesses_Button.Name = "RefreshProcesses_Button";
            this.RefreshProcesses_Button.Size = new System.Drawing.Size(23, 21);
            this.RefreshProcesses_Button.TabIndex = 0;
            this.RefreshProcesses_Button.TabStop = false;
            this.RefreshProcesses_Button.UseVisualStyleBackColor = true;
            this.RefreshProcesses_Button.Click += new System.EventHandler(this.RefreshProcesses_Button_Click);
            // 
            // Proccesses_ComboBox
            // 
            this.Proccesses_ComboBox.FormattingEnabled = true;
            this.Proccesses_ComboBox.Location = new System.Drawing.Point(7, 49);
            this.Proccesses_ComboBox.Name = "Proccesses_ComboBox";
            this.Proccesses_ComboBox.Size = new System.Drawing.Size(110, 21);
            this.Proccesses_ComboBox.TabIndex = 0;
            this.Proccesses_ComboBox.TabStop = false;
            this.Proccesses_ComboBox.Text = "Select a Process";
            this.Proccesses_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Proccesses_ComboBox_SelectedIndexChanged);
            // 
            // InjectELF_Button
            // 
            this.InjectELF_Button.Location = new System.Drawing.Point(7, 74);
            this.InjectELF_Button.Name = "InjectELF_Button";
            this.InjectELF_Button.Size = new System.Drawing.Size(139, 23);
            this.InjectELF_Button.TabIndex = 0;
            this.InjectELF_Button.TabStop = false;
            this.InjectELF_Button.Text = "Inject ELF";
            this.InjectELF_Button.UseVisualStyleBackColor = true;
            this.InjectELF_Button.Click += new System.EventHandler(this.InjectELF_Button_Click);
            // 
            // Connection_GroupBox
            // 
            this.Connection_GroupBox.Controls.Add(this.InjectjkPatch_Button);
            this.Connection_GroupBox.Controls.Add(this.ConnectPS4_Button);
            this.Connection_GroupBox.Controls.Add(this.Port_TextBox);
            this.Connection_GroupBox.Controls.Add(this.IP_TextBox);
            this.Connection_GroupBox.Location = new System.Drawing.Point(13, 3);
            this.Connection_GroupBox.Name = "Connection_GroupBox";
            this.Connection_GroupBox.Size = new System.Drawing.Size(152, 106);
            this.Connection_GroupBox.TabIndex = 0;
            this.Connection_GroupBox.TabStop = false;
            this.Connection_GroupBox.Text = "Connection";
            // 
            // InjectjkPatch_Button
            // 
            this.InjectjkPatch_Button.Location = new System.Drawing.Point(7, 44);
            this.InjectjkPatch_Button.Name = "InjectjkPatch_Button";
            this.InjectjkPatch_Button.Size = new System.Drawing.Size(140, 23);
            this.InjectjkPatch_Button.TabIndex = 0;
            this.InjectjkPatch_Button.TabStop = false;
            this.InjectjkPatch_Button.Text = "Inject jkPatch";
            this.InjectjkPatch_Button.UseVisualStyleBackColor = true;
            this.InjectjkPatch_Button.Click += new System.EventHandler(this.InjectjkPatch_Button_Click);
            // 
            // ConnectPS4_Button
            // 
            this.ConnectPS4_Button.Location = new System.Drawing.Point(7, 73);
            this.ConnectPS4_Button.Name = "ConnectPS4_Button";
            this.ConnectPS4_Button.Size = new System.Drawing.Size(140, 23);
            this.ConnectPS4_Button.TabIndex = 0;
            this.ConnectPS4_Button.TabStop = false;
            this.ConnectPS4_Button.Text = "Connect to PS4";
            this.ConnectPS4_Button.UseVisualStyleBackColor = true;
            this.ConnectPS4_Button.Click += new System.EventHandler(this.ConnectPS4_Button_Click);
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(113, 19);
            this.Port_TextBox.Multiline = true;
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(33, 20);
            this.Port_TextBox.TabIndex = 0;
            this.Port_TextBox.TabStop = false;
            this.Port_TextBox.TextChanged += new System.EventHandler(this.Port_TextBox_TextChanged);
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IP_TextBox.Location = new System.Drawing.Point(7, 19);
            this.IP_TextBox.Multiline = true;
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(100, 20);
            this.IP_TextBox.TabIndex = 0;
            this.IP_TextBox.TabStop = false;
            this.IP_TextBox.TextChanged += new System.EventHandler(this.IP_TextBox_TextChanged);
            // 
            // PayloadInjection_GroupBox
            // 
            this.PayloadInjection_GroupBox.Controls.Add(this.InjectPayload_Button);
            this.PayloadInjection_GroupBox.Controls.Add(this.SelectPayload_Button);
            this.PayloadInjection_GroupBox.Location = new System.Drawing.Point(171, 3);
            this.PayloadInjection_GroupBox.Name = "PayloadInjection_GroupBox";
            this.PayloadInjection_GroupBox.Size = new System.Drawing.Size(152, 106);
            this.PayloadInjection_GroupBox.TabIndex = 0;
            this.PayloadInjection_GroupBox.TabStop = false;
            this.PayloadInjection_GroupBox.Text = "Payload Injection";
            // 
            // InjectPayload_Button
            // 
            this.InjectPayload_Button.Location = new System.Drawing.Point(7, 59);
            this.InjectPayload_Button.Name = "InjectPayload_Button";
            this.InjectPayload_Button.Size = new System.Drawing.Size(140, 23);
            this.InjectPayload_Button.TabIndex = 0;
            this.InjectPayload_Button.TabStop = false;
            this.InjectPayload_Button.Text = "Inject Payload";
            this.InjectPayload_Button.UseVisualStyleBackColor = true;
            this.InjectPayload_Button.Click += new System.EventHandler(this.InjectPayload_Button_Click);
            // 
            // SelectPayload_Button
            // 
            this.SelectPayload_Button.Location = new System.Drawing.Point(7, 31);
            this.SelectPayload_Button.Name = "SelectPayload_Button";
            this.SelectPayload_Button.Size = new System.Drawing.Size(140, 23);
            this.SelectPayload_Button.TabIndex = 0;
            this.SelectPayload_Button.TabStop = false;
            this.SelectPayload_Button.Text = "Select Payload";
            this.SelectPayload_Button.UseVisualStyleBackColor = true;
            this.SelectPayload_Button.Click += new System.EventHandler(this.SelectPayload_Button_Click);
            // 
            // CurrentStatus_Label
            // 
            this.CurrentStatus_Label.AutoSize = true;
            this.CurrentStatus_Label.Location = new System.Drawing.Point(50, 112);
            this.CurrentStatus_Label.Name = "CurrentStatus_Label";
            this.CurrentStatus_Label.Size = new System.Drawing.Size(0, 13);
            this.CurrentStatus_Label.TabIndex = 0;
            // 
            // OpenPayloadDialog
            // 
            this.OpenPayloadDialog.Filter = "BIN file (*.BIN)|*.BIN";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Location = new System.Drawing.Point(13, 112);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(40, 13);
            this.Status_Label.TabIndex = 0;
            this.Status_Label.Text = "Status:";
            // 
            // OpenELFDialog
            // 
            this.OpenELFDialog.Filter = "ELF file (*.ELF)|*.ELF";
            // 
            // jkPatch_BGWorker
            // 
            this.jkPatch_BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.JkPatch_BGWorker_DoWork);
            // 
            // Payload_BGWorker
            // 
            this.Payload_BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Payload_BGWorker_DoWork);
            // 
            // ELF_BGWorker
            // 
            this.ELF_BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ELF_BGWorker_DoWork);
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 129);
            this.Controls.Add(this.Status_Label);
            this.Controls.Add(this.CurrentStatus_Label);
            this.Controls.Add(this.PayloadInjection_GroupBox);
            this.Controls.Add(this.Connection_GroupBox);
            this.Controls.Add(this.ELFInjection_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payload & ELF Injector";
            this.Load += new System.EventHandler(this.Tool_Load);
            this.ELFInjection_GroupBox.ResumeLayout(false);
            this.Connection_GroupBox.ResumeLayout(false);
            this.Connection_GroupBox.PerformLayout();
            this.PayloadInjection_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectELF_Button;
        private System.Windows.Forms.GroupBox ELFInjection_GroupBox;
        private System.Windows.Forms.Button InjectELF_Button;
        private System.Windows.Forms.GroupBox Connection_GroupBox;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.TextBox IP_TextBox;
        private System.Windows.Forms.GroupBox PayloadInjection_GroupBox;
        private System.Windows.Forms.Button InjectPayload_Button;
        private System.Windows.Forms.Button SelectPayload_Button;
        private System.Windows.Forms.Label CurrentStatus_Label;
        private System.Windows.Forms.OpenFileDialog OpenPayloadDialog;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.OpenFileDialog OpenELFDialog;
        private System.Windows.Forms.ComboBox Proccesses_ComboBox;
        private System.Windows.Forms.Button RefreshProcesses_Button;
        private System.Windows.Forms.Button ConnectPS4_Button;
        private System.Windows.Forms.Button InjectjkPatch_Button;
        private System.ComponentModel.BackgroundWorker jkPatch_BGWorker;
        private System.ComponentModel.BackgroundWorker Payload_BGWorker;
        private System.ComponentModel.BackgroundWorker ELF_BGWorker;
    }
}

