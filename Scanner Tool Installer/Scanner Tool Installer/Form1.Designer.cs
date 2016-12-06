namespace Scanner_Tool_Installer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InstallButton = new System.Windows.Forms.Button();
            this.ShortcutCheckBox = new System.Windows.Forms.CheckBox();
            this.ManualCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(81, 21);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(89, 28);
            this.InstallButton.TabIndex = 0;
            this.InstallButton.Text = "Installieren";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // ShortcutCheckBox
            // 
            this.ShortcutCheckBox.AutoSize = true;
            this.ShortcutCheckBox.Location = new System.Drawing.Point(63, 56);
            this.ShortcutCheckBox.Name = "ShortcutCheckBox";
            this.ShortcutCheckBox.Size = new System.Drawing.Size(126, 17);
            this.ShortcutCheckBox.TabIndex = 1;
            this.ShortcutCheckBox.Text = "Desktopverknüpfung";
            this.ShortcutCheckBox.UseVisualStyleBackColor = true;
            // 
            // ManualCheckBox
            // 
            this.ManualCheckBox.AutoSize = true;
            this.ManualCheckBox.Location = new System.Drawing.Point(63, 79);
            this.ManualCheckBox.Name = "ManualCheckBox";
            this.ManualCheckBox.Size = new System.Drawing.Size(76, 17);
            this.ManualCheckBox.TabIndex = 2;
            this.ManualCheckBox.Text = "Handbuch";
            this.ManualCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 105);
            this.Controls.Add(this.ManualCheckBox);
            this.Controls.Add(this.ShortcutCheckBox);
            this.Controls.Add(this.InstallButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Scanner Tool Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.CheckBox ShortcutCheckBox;
        private System.Windows.Forms.CheckBox ManualCheckBox;
    }
}

