namespace AirBomber
{
    public partial class FormMap : Form
    {
        private AbstractMap _abstractMap;
        public FormMap()
        {
            InitializeComponent();
            _abstractMap = new SimpleMap();
        }
        /// <summary>
        /// Заполнение информации по объекту
        /// </summary>
        /// <param name="car"></param>
        private void SetData(DrawingMoving airBomber)
        {
            toolStripStatusLabelSpeed.Text = $"Скорость: {airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {airBomber.AirBomber.BodyColor.Name}";
            pictureBoxAirBomber.Image = _abstractMap.CreateMap(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height, new DrawningObjectAirBomber(airBomber));
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var airBomber = new DrawingMoving(
                rnd.Next(100, 300), rnd.Next(1000, 2000), 
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));

            SetData(airBomber);
        }
        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            var dir = name switch
            {
                "buttonUp" => Direction.Up,
                "buttonDown" => Direction.Down,
                "buttonLeft" => Direction.Left,
                "buttonRight" => Direction.Right,
                _ => Direction.None,
            };

            pictureBoxAirBomber.Image = _abstractMap?.MoveObject(dir);
        }

        /// <summary>
        /// Обработка нажатия кнопки "Модификация"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var improvedBomber = new DrawingImprovedAirBomber(
                rnd.Next(100, 300), 
                rnd.Next(1000, 2000),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), 
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Convert.ToBoolean(rnd.Next(0, 2)), 
                Convert.ToBoolean(rnd.Next(0, 2)));

            SetData(improvedBomber);
        }
        /// <summary>
        /// Смена карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectorMap.Text)
            {
                case "Простая карта":
                    _abstractMap = new SimpleMap();
                    break;
                case "Улучшенная карта":
                    _abstractMap = new ImprovedMap();
                    break;
            }
        }
    }
}