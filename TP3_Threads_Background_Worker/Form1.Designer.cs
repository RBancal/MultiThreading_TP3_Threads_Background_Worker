namespace TP3_Threads_Background_Worker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lengthArray = new System.Windows.Forms.Label();
            this.textBoxArray = new System.Windows.Forms.TextBox();
            this.listNonTriee = new System.Windows.Forms.ListView();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.triButton = new System.Windows.Forms.Button();
            this.listTriee = new System.Windows.Forms.ListView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(388, 365);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 25;
            this.lineShape1.X2 = 365;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 50;
            // 
            // lengthArray
            // 
            this.lengthArray.AutoSize = true;
            this.lengthArray.Location = new System.Drawing.Point(12, 23);
            this.lengthArray.Name = "lengthArray";
            this.lengthArray.Size = new System.Drawing.Size(94, 13);
            this.lengthArray.TabIndex = 1;
            this.lengthArray.Text = "Taille du tableau : ";
            // 
            // textBoxArray
            // 
            this.textBoxArray.Location = new System.Drawing.Point(112, 20);
            this.textBoxArray.Name = "textBoxArray";
            this.textBoxArray.Size = new System.Drawing.Size(100, 20);
            this.textBoxArray.TabIndex = 2;
            // 
            // listNonTriee
            // 
            this.listNonTriee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listNonTriee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listNonTriee.Location = new System.Drawing.Point(30, 67);
            this.listNonTriee.Name = "listNonTriee";
            this.listNonTriee.Size = new System.Drawing.Size(121, 286);
            this.listNonTriee.TabIndex = 3;
            this.listNonTriee.UseCompatibleStateImageBehavior = false;
            this.listNonTriee.View = System.Windows.Forms.View.Details;
            // 
            // InitializeButton
            // 
            this.InitializeButton.Location = new System.Drawing.Point(158, 87);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(75, 23);
            this.InitializeButton.TabIndex = 4;
            this.InitializeButton.Text = "Initialiser";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // triButton
            // 
            this.triButton.Location = new System.Drawing.Point(158, 129);
            this.triButton.Name = "triButton";
            this.triButton.Size = new System.Drawing.Size(75, 23);
            this.triButton.TabIndex = 5;
            this.triButton.Text = "Trier";
            this.triButton.UseVisualStyleBackColor = true;
            this.triButton.Click += new System.EventHandler(this.triButton_Click);
            // 
            // listTriee
            // 
            this.listTriee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listTriee.Location = new System.Drawing.Point(239, 67);
            this.listTriee.Name = "listTriee";
            this.listTriee.Size = new System.Drawing.Size(121, 286);
            this.listTriee.TabIndex = 6;
            this.listTriee.UseCompatibleStateImageBehavior = false;
            this.listTriee.View = System.Windows.Forms.View.Details;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(301, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Quitter";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Liste Non Triée";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Liste Triée";
            this.columnHeader2.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 365);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.listTriee);
            this.Controls.Add(this.triButton);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.listNonTriee);
            this.Controls.Add(this.textBoxArray);
            this.Controls.Add(this.lengthArray);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Tri Rapide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lengthArray;
        private System.Windows.Forms.TextBox textBoxArray;
        private System.Windows.Forms.ListView listNonTriee;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.Button triButton;
        private System.Windows.Forms.ListView listTriee;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}

