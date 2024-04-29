using System.Drawing;

namespace Lab_2
{
    partial class TotalCommander
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalCommander));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерОтображаемогоШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.pathField1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.pathField2 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.цветФормыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФайлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ФайлToolStripMenuItem
            // 
            this.ФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалитьToolStripMenuItem1,
            this.скопироватьToolStripMenuItem1,
            this.переименоватьToolStripMenuItem1});
            this.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem";
            this.ФайлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.ФайлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // скопироватьToolStripMenuItem1
            // 
            this.скопироватьToolStripMenuItem1.Name = "скопироватьToolStripMenuItem1";
            this.скопироватьToolStripMenuItem1.Size = new System.Drawing.Size(204, 26);
            this.скопироватьToolStripMenuItem1.Text = "Скопировать";
            // 
            // переименоватьToolStripMenuItem1
            // 
            this.переименоватьToolStripMenuItem1.Name = "переименоватьToolStripMenuItem1";
            this.переименоватьToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.переименоватьToolStripMenuItem1.Text = "Переименовать";
            this.переименоватьToolStripMenuItem1.Click += new System.EventHandler(this.переименоватьToolStripMenuItem1_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерОтображаемогоШрифтаToolStripMenuItem,
            this.цветФормыToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // размерОтображаемогоШрифтаToolStripMenuItem
            // 
            this.размерОтображаемогоШрифтаToolStripMenuItem.Name = "размерОтображаемогоШрифтаToolStripMenuItem";
            this.размерОтображаемогоШрифтаToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.размерОтображаемогоШрифтаToolStripMenuItem.Text = "Вид отображаемого шрифта";
            this.размерОтображаемогоШрифтаToolStripMenuItem.Click += new System.EventHandler(this.размерОтображаемогоШрифтаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.backBtn1);
            this.splitContainer1.Panel1.Controls.Add(this.pathField1);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.backBtn2);
            this.splitContainer1.Panel2.Controls.Add(this.pathField2);
            this.splitContainer1.Panel2.Controls.Add(this.listView2);
            this.splitContainer1.Size = new System.Drawing.Size(931, 616);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 3;
            // 
            // backBtn1
            // 
            this.backBtn1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.backBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backBtn1.Location = new System.Drawing.Point(355, 22);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(30, 30);
            this.backBtn1.TabIndex = 2;
            this.backBtn1.Text = "<";
            this.backBtn1.UseVisualStyleBackColor = false;
            this.backBtn1.Click += new System.EventHandler(this.backBtn1_Click);
            // 
            // pathField1
            // 
            this.pathField1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathField1.Location = new System.Drawing.Point(13, 28);
            this.pathField1.Name = "pathField1";
            this.pathField1.Size = new System.Drawing.Size(320, 22);
            this.pathField1.TabIndex = 1;
            this.pathField1.Leave += new System.EventHandler(this.pathField1_Leave);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 560);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_1);
            // 
            // backBtn2
            // 
            this.backBtn2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.backBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backBtn2.Location = new System.Drawing.Point(358, 22);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(30, 30);
            this.backBtn2.TabIndex = 4;
            this.backBtn2.Text = "<";
            this.backBtn2.UseVisualStyleBackColor = false;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // pathField2
            // 
            this.pathField2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathField2.Location = new System.Drawing.Point(14, 28);
            this.pathField2.Name = "pathField2";
            this.pathField2.Size = new System.Drawing.Size(320, 22);
            this.pathField2.TabIndex = 3;
            this.pathField2.Leave += new System.EventHandler(this.pathField2_Leave);
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.iconList;
            this.listView2.Location = new System.Drawing.Point(0, 56);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(493, 560);
            this.listView2.SmallImageList = this.iconList;
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "9004737_file_document_paper_page_icon.ico");
            this.iconList.Images.SetKeyName(1, "1");
            this.iconList.Images.SetKeyName(2, "9004727_music_sound_audio_media_icon (1).ico");
            this.iconList.Images.SetKeyName(3, "9004735_video_play_movie_player_icon.ico");
            this.iconList.Images.SetKeyName(4, "9004736_image_photo_picture_gallery_icon.ico");
            // 
            // цветФормыToolStripMenuItem
            // 
            this.цветФормыToolStripMenuItem.Name = "цветФормыToolStripMenuItem";
            this.цветФормыToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.цветФормыToolStripMenuItem.Text = "Цвет формы";
            this.цветФормыToolStripMenuItem.Click += new System.EventHandler(this.цветФормыToolStripMenuItem_Click);
            // 
            // TotalCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 616);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TotalCommander";
            this.Text = "Total Commander";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ФайлToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерОтображаемогоШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox pathField1;
        private System.Windows.Forms.TextBox pathField2;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button backBtn1;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.ToolStripMenuItem цветФормыToolStripMenuItem;
    }
}

