namespace TreeView
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Bisabuela");
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Bisabuelo");
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Abuelo", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Bisabuela");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Bisuabuela");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Abuela", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Mama", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21});
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Bisabuelo");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Bisabuela");
			System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Abuelo", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
			System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Bisabuela");
			System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Bisabuela");
			System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Abuela", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27});
			System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Papa", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode28});
			System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Jose Manuel Sauri", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode29});
			this.button1 = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(187, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Mostrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			treeNode16.Name = "Nodo7";
			treeNode16.Text = "Bisabuela";
			treeNode17.Name = "Nodo8";
			treeNode17.Text = "Bisabuelo";
			treeNode18.Name = "Nodo3";
			treeNode18.Text = "Abuelo";
			treeNode19.Name = "Nodo11";
			treeNode19.Text = "Bisabuela";
			treeNode20.Name = "Nodo12";
			treeNode20.Text = "Bisuabuela";
			treeNode21.Name = "Nodo4";
			treeNode21.Text = "Abuela";
			treeNode22.Name = "Nodo1";
			treeNode22.Text = "Mama";
			treeNode23.Name = "Nodo9";
			treeNode23.Text = "Bisabuelo";
			treeNode24.Name = "Nodo10";
			treeNode24.Text = "Bisabuela";
			treeNode25.Name = "Nodo5";
			treeNode25.Text = "Abuelo";
			treeNode26.Name = "Nodo13";
			treeNode26.Text = "Bisabuela";
			treeNode27.Name = "Nodo14";
			treeNode27.Text = "Bisabuela";
			treeNode28.Name = "Nodo6";
			treeNode28.Text = "Abuela";
			treeNode29.Name = "Nodo2";
			treeNode29.Text = "Papa";
			treeNode30.Name = "Nodo0";
			treeNode30.Text = "Jose Manuel Sauri";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30});
			this.treeView1.Size = new System.Drawing.Size(168, 412);
			this.treeView1.TabIndex = 1;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(187, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(42, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(236, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Generaciones";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}

