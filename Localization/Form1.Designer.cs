namespace Localization
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
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProductId
            // 
            resources.ApplyResources(this.labelProductId, "labelProductId");
            this.labelProductId.Name = "labelProductId";
            // 
            // labelQuantity
            // 
            resources.ApplyResources(this.labelQuantity, "labelQuantity");
            this.labelQuantity.Name = "labelQuantity";
            // 
            // labelCustomerId
            // 
            resources.ApplyResources(this.labelCustomerId, "labelCustomerId");
            this.labelCustomerId.Name = "labelCustomerId";
            // 
            // labelDate
            // 
            resources.ApplyResources(this.labelDate, "labelDate");
            this.labelDate.Name = "labelDate";
            // 
            // textBoxProductId
            // 
            resources.ApplyResources(this.textBoxProductId, "textBoxProductId");
            this.textBoxProductId.Name = "textBoxProductId";
            // 
            // textBoxQuantity
            // 
            resources.ApplyResources(this.textBoxQuantity, "textBoxQuantity");
            this.textBoxQuantity.Name = "textBoxQuantity";
            // 
            // textBoxCustomerId
            // 
            resources.ApplyResources(this.textBoxCustomerId, "textBoxCustomerId");
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            // 
            // textBoxDate
            // 
            resources.ApplyResources(this.textBoxDate, "textBoxDate");
            this.textBoxDate.Name = "textBoxDate";
            // 
            // buttonCreate
            // 
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelNotification
            // 
            resources.ApplyResources(this.labelNotification, "labelNotification");
            this.labelNotification.Name = "labelNotification";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNotification);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelProductId);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelNotification;
    }
}

