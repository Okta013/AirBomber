namespace AirBomber
{
    public partial class FormAirBomber : Form
    {
        private DrawingMoving _airBomber;
        public DrawingMoving SelectedEntity { get; set; }
        public FormAirBomber()
        {
            InitializeComponent();
        }

        private void SetData()
        {
            Random rnd = new();
            _airBomber.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            toolStripStatusLabelSpeed.Text = $"Скорость: {_airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"Цвет: {_airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Вес: {_airBomber.AirBomber.BodyColor.Name}";
        }

        private void Draw()
        {
            Bitmap bmp = new(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _airBomber?.DrawAirBomber(gr);
            pictureBoxAirBomber.Image = bmp;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _airBomber = new DrawingMoving(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            SetData();
            Draw();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender)?.Name ?? string.Empty;
            var direct = name switch
            {
                "buttonUp" => Direction.Up,
                "buttonDown" => Direction.Down,
                "buttonLeft" => Direction.Left,
                "buttonRight" => Direction.Right,
                _ => Direction.None
            };
            _airBomber?.MoveAirBomber(direct, new int[100,100]);
            Draw();
        }

        private void PictureBoxAirBomber_Resize(object sender, EventArgs e)
        {
            _airBomber?.ChangeBorders(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Draw();
        }

        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _airBomber = new DrawingImprovedAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)));
            SetData();
            Draw();
        }

        private void SelectCar_Click(object sender, EventArgs e)
        {
            SelectedEntity = _airBomber;
            DialogResult = DialogResult.OK;
        }
    }
}