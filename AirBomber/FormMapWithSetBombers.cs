namespace AirBomber
{
    public partial class FormMapWithSetBombers : Form
    {
        private readonly MapsCollection mapsCollection;

        private readonly Dictionary<string, AbstractMap> mapsDict = new()
        {
            { "Простая карта", new SimpleMap() },
            { "Улучшенная карта", new ImprovedMap() }
        };

        public FormMapWithSetBombers()
        {
            InitializeComponent();
            mapsCollection = new(PictureBox.Width, PictureBox.Height);
            ComboBox.Items.Clear();

            foreach (var elem in mapsDict)
            {
                ComboBox.Items.Add(elem.Key);
            }
        }

        private void ReloadMaps()
        {
            var nidx = ListBoxMaps.SelectedIndex;
            ListBoxMaps.Items.Clear();

            for (int i = 0; i < mapsCollection.Keys.Count; i++) ListBoxMaps.Items.Add(mapsCollection.Keys[i]);

            if (ListBoxMaps.Items.Count > 0 && (nidx == -1 || nidx >= ListBoxMaps.Items.Count)) ListBoxMaps.SelectedIndex = 0;
            else if (ListBoxMaps.Items.Count > 0 && nidx > -1 && nidx < ListBoxMaps.Items.Count) ListBoxMaps.SelectedIndex = nidx;
        }

        //private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    AbstractMap map = ComboBox.Text switch
        //    {
        //        "Простая карта" => new SimpleMap(),
        //        "Улучшенная карта" => new ImprovedMap()
        //    };

        //    mapWithEntities = map != null ? new MapWithSetBombersGeneric<DrawningObjectAirBomber, AbstractMap>(PictureBox.Width, PictureBox.Height, map) : null;
        //}

        private void AddEntity_Click(object sender, EventArgs e)
        {
            if (ListBoxMaps.SelectedIndex == -1) return;

            FormAirBomber form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DrawningObjectAirBomber airBomber = new(form.SelectedEntity);
                if (mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty] + airBomber)
                {
                    MessageBox.Show("Объект добавлен");
                    PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                }
                else
                {   
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
        }

        private void RemoveEntity_Click(object sender, EventArgs e)
        {
            if (ListBoxMaps.SelectedIndex == -1 || string.IsNullOrEmpty(MaskedTextBox.Text)) return;
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            int pos = Convert.ToInt32(MaskedTextBox.Text);

            if (mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty] - pos)
            {
                MessageBox.Show("Объект удалён");
                PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            if (mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty] == null) return;
            PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }

        private void CheckMap_Click(object sender, EventArgs e)
        {
            if (mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty] == null) return;
            PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowOnMap();
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty] == null) return;
            var name = ((Button)sender)?.Name ?? string.Empty;
            var direct = name switch
            {
                "ButtonUp" => Direction.Up,
                "ButtonDown" => Direction.Down,
                "ButtonLeft" => Direction.Left,
                "ButtonRight" => Direction.Right,
                _ => Direction.None
            };
            PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].MoveObject(direct);
        }

        private void AddMap_Click(object sender, EventArgs e)
        {
            var comboBoxText = ComboBox.Text;
            var textBoxText = TextBox.Text;

            if (ComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxText)) 
            {
                MessageBox.Show("Не все данные заполненны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!mapsDict.ContainsKey(comboBoxText)) 
            {
                MessageBox.Show("Такой карты нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mapsCollection.AddMap(textBoxText, mapsDict[comboBoxText]);
            ReloadMaps();
        }

        private void ListBoxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }

        private void DeleteMap_Click(object sender, EventArgs e)
        {
            if (ListBoxMaps.SelectedIndex == -1) return;
            if (MessageBox.Show($"Удалить карту {ListBoxMaps.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mapsCollection.RemoveMap(ListBoxMaps.SelectedItem?.ToString() ?? string.Empty);
                ReloadMaps();
            }
        }
    }
}
