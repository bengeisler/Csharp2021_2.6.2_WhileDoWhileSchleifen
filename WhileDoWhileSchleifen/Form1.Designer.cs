
namespace WhileDoWhileSchleifen
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
			this.btnDoWhile = new System.Windows.Forms.Button();
			this.btnWhile = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDoWhile
			// 
			this.btnDoWhile.Location = new System.Drawing.Point(308, 54);
			this.btnDoWhile.Name = "btnDoWhile";
			this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
			this.btnDoWhile.TabIndex = 0;
			this.btnDoWhile.Text = "do while";
			this.btnDoWhile.UseVisualStyleBackColor = true;
			this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
			// 
			// btnWhile
			// 
			this.btnWhile.Location = new System.Drawing.Point(308, 16);
			this.btnWhile.Name = "btnWhile";
			this.btnWhile.Size = new System.Drawing.Size(75, 23);
			this.btnWhile.TabIndex = 1;
			this.btnWhile.Text = "while";
			this.btnWhile.UseVisualStyleBackColor = true;
			this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(16, 16);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 2;
			this.lblAusgabe.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnWhile);
			this.Controls.Add(this.btnDoWhile);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDoWhile;
		private System.Windows.Forms.Button btnWhile;
		private System.Windows.Forms.Label lblAusgabe;
	}
}

