using AirBomber.Exceptions;
using Serilog;

namespace AirBomber
{
    public partial class FormMapWithSetBombers : Form
    {
        private readonly MapsCollection mapsCollection;
        private readonly ILogger logger;

        private readonly Dictionary<string, AbstractMap> mapsDict = new()
        {
            { "Простая карта", new SimpleMap() },
            { "Улучшенная карта", new ImprovedMap() }
        };

        public FormMapWithSetBombers(ILogger logger)
        {
            InitializeComponent();
            this.logger = logger;
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
            FormEntityConfig formCarConfig = new();
            formCarConfig.Show();
            formCarConfig.AddEvent(AddEntity_Delegate);
        }

        private void AddEntity_Delegate(DrawingMoving entity)
        {
            if (ListBoxMaps.SelectedIndex == -1) return;

            try
            {
                if (mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty] + new DrawningObjectAirBomber(entity))
                {
                    MessageBox.Show("Объект добавлен");
                    PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                    logger.Information("Добавлен объект");
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                    logger.Warning("Не удалось добавить объект");
                }
            }
            catch (Exception ex)
            {
                if (ex is StorageOverflowException)
                {
                    MessageBox.Show($"Ошибка добавления: {ex.Message}");
                    logger.Warning(ex, $"Ошибка добавления: {ex.Message}");
                }
                else
                {
                    MessageBox.Show($"Неизвестная ошибка: {ex.Message}");
                    logger.Warning(ex, $"Неизвестная ошибка: {ex.Message}");
                }
            }
        }

        private void RemoveEntity_Click(object sender, EventArgs e)
        {
            if (ListBoxMaps.SelectedIndex == -1 || string.IsNullOrEmpty(MaskedTextBox.Text)) return;
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            int pos = Convert.ToInt32(MaskedTextBox.Text);

            try
            {
                if (mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty] - pos)
                {
                    MessageBox.Show("Объект удалён");
                    PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                    logger.Information("Объект удалён");
                }
                else
                {
                    MessageBox.Show("Не удалось удалить объект");
                    logger.Warning("Не удалось удалить объект");
                }
            }
            catch (Exception ex)
            {
                if (ex is EntityNotFoundException)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                    logger.Warning(ex, $"Ошибка удаления: {ex.Message}");
                }
                else
                {
                    MessageBox.Show($"Неизвестная ошибка: {ex.Message}");
                    logger.Warning(ex, $"Неизвестная ошибка: {ex.Message}");
                }
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
                logger.Warning("Не все данные заполненны");
                return;
            }
            if (!mapsDict.ContainsKey(comboBoxText))
            {
                MessageBox.Show("Такой карты нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warning("Такой карты нет");
                return;
            }

            mapsCollection.AddMap(textBoxText, mapsDict[comboBoxText]);
            logger.Information($"Добавлена карта: {textBoxText}");
            ReloadMaps();
        }

        private void ListBoxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var map = ListBoxMaps.SelectedItem?.ToString();
            PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
            logger.Information($"Переход на карту: {map}");
        }

        private void DeleteMap_Click(object sender, EventArgs e)
        {
            var map = ListBoxMaps.SelectedItem;
            if (ListBoxMaps.SelectedIndex == -1) return;
            if (MessageBox.Show($"Удалить карту {ListBoxMaps.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mapsCollection.RemoveMap(ListBoxMaps.SelectedItem?.ToString() ?? string.Empty);
                logger.Information($"Карта удалена: {map}");
                ReloadMaps();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    mapsCollection.SaveData(SaveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Information("Сохранение прошло успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось сохранить: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warning(ex, $"Не удалось сохранить: {ex.Message}");
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mapsCollection.LoadData(LoadFileDialog.FileName);
                    MessageBox.Show("Загрузка прошла успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Information("Загрузка прошла успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось загрузить: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warning(ex, $"Не удалось загрузить: {ex.Message}");
                }
            }
            ReloadMaps();
        }

        private void SortByTypeButton_Click(object sender, EventArgs e)
        {
            if (ListBoxMaps.SelectedIndex == -1) return;

            mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].Sort(new EntityCompareByType());
            PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }

        private void SortByColorButton_Click(object sender, EventArgs e)
        {
            if (ListBoxMaps.SelectedIndex == -1) return;

            mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].Sort(new EntityCompareByColor());
            PictureBox.Image = mapsCollection[ListBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }
    }
}
