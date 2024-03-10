using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm
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
        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {

            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTableLayoutPanel.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            //
            // Bindings
            //
            Binding dtpToLblBindings = new Binding("Text", dateTimePicker, "Value");
            dtpToLblBindings.FormattingEnabled = true;
            dtpToLblBindings.FormatString = "dd.MM.yyyy";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.Lavender;
            this.mainTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainTableLayoutPanel.ColumnCount = 6;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.Controls.Add(this.panelTime, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.button1, 2, 3);
            this.mainTableLayoutPanel.Controls.Add(this.button2, 3, 3);
            this.mainTableLayoutPanel.Controls.Add(this.label1, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(800, 400);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainTableLayoutPanel.SetColumnSpan(this.panelTime, 2);
            this.panelTime.Controls.Add(this.dateTimePicker);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTime.Location = new System.Drawing.Point(3, 3);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(260, 94);
            this.panelTime.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(34, 30);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 30);
            this.dateTimePicker.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(276, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(409, 320);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTableLayoutPanel.SetColumnSpan(this.label1, 2);
            this.label1.Cursor = System.Windows.Forms.Cursors.Help;
            this.label1.Location = new System.Drawing.Point(25, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.DataBindings.Add(dtpToLblBindings);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логгер рабочего времени. Width: 800 Height: 400";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private TableLayoutPanel mainTableLayoutPanel;
        private DateTimePicker dateTimePicker;
        private Panel panelTime;
        private Button button1;
        private Button button2;
        private Label label1;

        public TableLayoutPanel TableLayoutPanel => mainTableLayoutPanel;
        public int MainWidth => this.ClientSize.Width;
        public int MainHeight => this.ClientSize.Height;
        public Button ButtonSave => this.button1;
        public Button ButtonCancellation => this.button2;
        public DateTimePicker DateTimePicker => this.dateTimePicker;
    }
}