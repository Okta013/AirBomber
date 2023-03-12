namespace AirBomber
{
    public partial class FormMapWithSetBombers : Form
    {
        private MapWithSetBombersGeneric<DrawningObjectAirBomber, AbstractMap> mapWithEntities;

        public FormMapWithSetBombers() => InitializeComponent();

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbstractMap map = ComboBox.Text switch
            {
                "Простая карта" => new SimpleMap(),
                "Улучшенная карта" => new ImprovedMap()
            };

            mapWithEntities = map != null ? new MapWithSetBombersGeneric<DrawningObjectAirBomber, AbstractMap>(PictureBox.Width, PictureBox.Height, map) : null;
        }

        private void AddEntity_Click(object sender, EventArgs e)
        {
            if (mapWithEntities == null) return;

            FormAirBomber form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DrawningObjectAirBomber airBomber = new(form.SelectedEntity);
                if (mapWithEntities + airBomber)
                {
                    MessageBox.Show("Объект добавлен");
                    PictureBox.Image = mapWithEntities.ShowSet();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
        }

        private void RemoveEntity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaskedTextBox.Text)) return;
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            int pos = Convert.ToInt32(MaskedTextBox.Text);

            if (mapWithEntities - pos)
            {
                MessageBox.Show("Объект удалён");
                PictureBox.Image = mapWithEntities.ShowSet();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            if (mapWithEntities == null) return;
            PictureBox.Image = mapWithEntities.ShowSet();
        }

        private void CheckMap_Click(object sender, EventArgs e)
        {
            if (mapWithEntities == null) return;
            PictureBox.Image = mapWithEntities.ShowOnMap();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (mapWithEntities == null) return;
            var name = ((Button)sender)?.Name ?? string.Empty;
            var direct = name switch
            {
                "buttonUp" => Direction.Up,
                "buttonDown" => Direction.Down,
                "buttonLeft" => Direction.Left,
                "buttonRight" => Direction.Right,
                _ => Direction.None
            };
            PictureBox.Image = mapWithEntities.MoveObject(direct);
        }
    }
}
