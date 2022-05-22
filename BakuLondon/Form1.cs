namespace BakuLondon
{

    public partial class Form1 : Form
    {

        private PictureBox Baku;
        private Label saat;
        private PictureBox london;
        private bool isokay = true;
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox Baku;
            this.london = new System.Windows.Forms.PictureBox();
            this.saat = new System.Windows.Forms.Label();
            Baku = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(Baku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.london)).BeginInit();
            this.SuspendLayout();
            // 
            // Baku
            // 
            Baku.Image = global::BakuLondon.Resource1.cas;
            Baku.Location = new System.Drawing.Point(0, 2);
            Baku.Name = "Baku";
            Baku.Size = new System.Drawing.Size(309, 352);
            Baku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            Baku.TabIndex = 0;
            Baku.TabStop = false;
            Baku.Tag = "";
            Baku.Click += new System.EventHandler(this.Baku_Click);
            // 
            // london
            // 
            this.london.Image = global::BakuLondon.Resource1.london;
            this.london.Location = new System.Drawing.Point(315, 2);
            this.london.Name = "london";
            this.london.Size = new System.Drawing.Size(303, 352);
            this.london.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.london.TabIndex = 1;
            this.london.TabStop = false;
            this.london.Click += new System.EventHandler(this.london_Click);
            // 
            // saat
            // 
            this.saat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saat.Location = new System.Drawing.Point(250, 164);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(118, 31);
            this.saat.TabIndex = 2;
            this.saat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(619, 353);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.london);
            this.Controls.Add(Baku);
            this.MaximumSize = new System.Drawing.Size(635, 392);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(635, 392);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(Baku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.london)).EndInit();
            this.ResumeLayout(false);

        }
        public Form1()
        {
            InitializeComponent();
            TimerExample();
        }

        private void TimerExample()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            switch (isokay)
            {
                case true:
                    saat.Text = DateTime.Now.ToString("hh:mm:ss");
                    break;
                default:
                    TimeZoneInfo London_Standard_Time = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                    DateTime time = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, London_Standard_Time);
                    saat.Text = time.ToString("hh:mm:ss");
                    break;
            }
           
        }
        private void Baku_Click(object sender, EventArgs e)
        {
            isokay = true;
            TimerExample();
        }

        private void london_Click(object sender, EventArgs e)
        {
            isokay = false;
            TimerExample();
        }
    }
}