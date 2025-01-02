namespace Teacher_Student_final_project
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.person = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("list.BackgroundImage")));
            this.list.Location = new System.Drawing.Point(509, 503);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(179, 141);
            this.list.TabIndex = 7;
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click_1);
            // 
            // search
            // 
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.Location = new System.Drawing.Point(790, 265);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(187, 167);
            this.search.TabIndex = 6;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(509, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 134);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // person
            // 
            this.person.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("person.BackgroundImage")));
            this.person.Location = new System.Drawing.Point(224, 260);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(192, 154);
            this.person.TabIndex = 4;
            this.person.UseVisualStyleBackColor = true;
            this.person.Click += new System.EventHandler(this.person_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 714);
            this.Controls.Add(this.list);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.person);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button list;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button person;
    }
}

