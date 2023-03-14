namespace AirBomber
{
    public partial class FormEntityConfig : Form
    {
        private DrawingMoving entity;
        private event EntityDelegate EventAddEntity;
        private Color BaseColor = Color.White;
        private Color AdditionColor = Color.Black;

        public FormEntityConfig()
        {
            InitializeComponent();
            PanelBlack.MouseDown += PanelColor_MouseDown;
            PanelBlue.MouseDown += PanelColor_MouseDown;
            PanelGreen.MouseDown += PanelColor_MouseDown;
            PanelRed.MouseDown += PanelColor_MouseDown;
            PanelGrey.MouseDown += PanelColor_MouseDown;
            PanelPurple.MouseDown += PanelColor_MouseDown;
            PanelYellow.MouseDown += PanelColor_MouseDown;
            PanelWhite.MouseDown += PanelColor_MouseDown;
        }

        public void Draw()
        {
            Bitmap bitmap = new(PictureBoxEntity.Width, PictureBoxEntity.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            entity.SetPosition(5, 5, PictureBoxEntity.Width, PictureBoxEntity.Height);
            entity.DrawAirBomber(graphics);
            PictureBoxEntity.Image = bitmap;
        }

        public void AddEvent(EntityDelegate ed)
        {
            if (EventAddEntity == null) EventAddEntity = new EntityDelegate(ed);
            else EventAddEntity += ed;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            var label = sender as Label;
            label.DoDragDrop(label.Name, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void DragPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string))) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void DragPanel_DragDrop(object sender, DragEventArgs e)
        {
            entity = e.Data.GetData(DataFormats.Text).ToString() switch
            {
                "SimpleLabel" => new DrawingMoving(
                    (int)NumericUpDownSpeed.Value, 
                    (int)NumericUpDownWeight.Value, 
                    BaseColor),

                "ImprovedLabel" => new DrawingImprovedAirBomber(
                    (int)NumericUpDownSpeed.Value, 
                    (int)NumericUpDownWeight.Value, 
                    BaseColor, 
                    AdditionColor, 
                    FuelTanksCheckBox.Checked, 
                    BombsCheckBox.Checked),
            };
            Draw();
        }

        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.DoDragDrop(ctrl.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void LabelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color))) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void LabelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color))) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            BaseColor = GetDragDropColor(e);
            CreateNewInstanceOfEntity();
            Draw();
        }

        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            AdditionColor = GetDragDropColor(e);
            CreateNewInstanceOfEntity();
            Draw();
        }

        private Color GetDragDropColor(DragEventArgs e)
        {
            return (e.Data.GetData(typeof(Color)) as Color?)?.Name switch
            {
                "Black" => Color.Black,
                "Yellow" => Color.Yellow,
                "Purple" => Color.Purple,
                "Gray" => Color.Gray,
                "Lime" => Color.Lime,
                "Blue" => Color.Blue,
                "White" => Color.White,
                "Red" => Color.Red
            };
        }

        private void CreateNewInstanceOfEntity()
        {
            if (entity is DrawingImprovedAirBomber)
                entity = new DrawingImprovedAirBomber(
                    (int)NumericUpDownSpeed.Value,
                    (int)NumericUpDownWeight.Value,
                    BaseColor,
                    AdditionColor,
                    FuelTanksCheckBox.Checked,
                    BombsCheckBox.Checked);
            else
                entity = new DrawingMoving(
                    (int)NumericUpDownSpeed.Value,
                    (int)NumericUpDownWeight.Value,
                    BaseColor);
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            EventAddEntity(entity);
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
