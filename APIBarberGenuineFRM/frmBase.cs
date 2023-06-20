namespace APIBarberGenuineFRM
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        //Para deslizar el form sin borde
        int posX = 0;
        int posY = 0;
        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);

                Top = Top + (e.Y - posY);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();


        }

        private void frmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
