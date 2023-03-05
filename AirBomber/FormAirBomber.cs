namespace AirBomber
{
    public partial class FormAirBomber : Form
    {
        private DrawingMoving _airBomber;
        public FormAirBomber()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод установки данных
        /// </summary>
        private void SetData()
        {
            Random rnd = new();
            _airBomber.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            toolStripStatusLabelSpeed.Text = $"Скорость: {_airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {_airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {_airBomber.AirBomber.BodyColor.Name}";
        }
        /// <summary>
        /// Метод прорисовки бомбардировщика
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _airBomber?.DrawAirBomber(gr);
            pictureBoxAirBomber.Image = bmp;
        }
        
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _airBomber = new DrawingMoving(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));
            SetData();
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок движения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //Получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _airBomber?.MoveAirBomber(Direction.Up);
                    break;
                case "buttonDown":
                    _airBomber?.MoveAirBomber(Direction.Down);
                    break;
                case "buttonLeft":
                    _airBomber?.MoveAirBomber(Direction.Left);
                    break;
                case "buttonRight":
                    _airBomber?.MoveAirBomber(Direction.Right);
                    break;
            }
            Draw();
        }
        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxAirBomber_Resize(object sender, EventArgs e)
        {
            _airBomber?.ChangeBorders(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height);
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Модификация"
        /// </summary>
        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            _airBomber = new DrawingImprovedAirBomber(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), Convert.ToBoolean(rnd.Next(0, 1)), Convert.ToBoolean(rnd.Next(0, 1)));
            SetData();
            Draw();
        }
    }
}