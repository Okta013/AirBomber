namespace AirBomber
{
    public partial class FormAirBomber : Form
    {
        private AbstractMap _map;
        public FormAirBomber()
        {
            InitializeComponent();
            _map = new SimpleMap();
        }
        /// <summary>
        /// ����� ��������� ������
        /// </summary>
        private void SetData(DrawingMoving airBomber)
        {
            toolStripStatusLabelSpeed.Text = $"��������: {airBomber.AirBomber.Speed}";
            toolStripStatusLabelWeight.Text = $"���: {airBomber.AirBomber.Weight}";
            toolStripStatusLabelBodyColor.Text = $"����: {airBomber.AirBomber.BodyColor.Name}";
            pictureBoxAirBomber.Image = _map.CreateMap(pictureBoxAirBomber.Width, pictureBoxAirBomber.Height, new DrawningObjectAirBomber(airBomber));
        }
        
        /// <summary>
        /// ��������� ������� ������ "�������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var _airBomber = new DrawingMoving(
                rnd.Next(100, 300), rnd.Next(1000, 2000), 
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)));

            SetData(_airBomber);
        }

        /// <summary>
        /// ��������� ������� ������ ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender)?.Name ?? string.Empty;
            var dir = name switch
            {
                "buttonUp" => Direction.Up,
                "buttonDown" => Direction.Down,
                "buttonLeft" => Direction.Left,
                "buttonRight" => Direction.Right,
                _ => Direction.None,
            };

            pictureBoxAirBomber.Image = _map?.MoveObject(dir);
        }

        /// <summary>
        /// ��������� ������� ������ "�����������"
        /// </summary>
        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            var _airBomber = new DrawingImprovedAirBomber(
                rnd.Next(100, 300), 
                rnd.Next(1000, 2000), 
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)),
                Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)), 
                Convert.ToBoolean(rnd.Next(0, 2)), 
                Convert.ToBoolean(rnd.Next(0, 2)));

            SetData(_airBomber);
        }

        private void ComboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectorMap.Text)
            {
                case "������� �����":
                    _map = new SimpleMap();
                    break;
                case "���������� �����":
                    _map = new ImprovedMap();
                    break;
            }
        }
    }
}