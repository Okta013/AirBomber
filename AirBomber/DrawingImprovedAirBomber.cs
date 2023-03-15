using System.Text;

namespace AirBomber
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение улучшенного объекта-сущности
    /// </summary>
    internal class DrawingImprovedAirBomber : DrawingMoving
    {
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость бомбардировщика</param>
        /// <param name="weight">Вес бомбардировщика</param>
        /// <param name="bodyColor">Цвет корпуса бомбардировщика</param>
        /// <param name="dopColor">Дополнительный цвет бомбардировщика</param>
        /// <param name="fuelTanks">Признак наличия дополнительных топливных баков</param>
        /// <param name="bombs">Признак наличия бомб</param>
        public DrawingImprovedAirBomber(int speed, float weight, Color bodyColor, Color dopColor, bool fuelTanks, bool bombs) : base(speed, weight, bodyColor, 100, 100)
        {
            AirBomber = new EntityImprovedAirBomber(speed, weight, bodyColor, dopColor, fuelTanks, bombs);
        }
        public override void DrawAirBomber(Graphics g)
        {
            if (AirBomber is not EntityImprovedAirBomber improvedAirBomber)
            {
                return;
            }
            Pen pen = new(Color.Black);
            Brush dopBrush = new SolidBrush(improvedAirBomber.DopColor);
            Brush redBrush = new SolidBrush(Color.Red);
            if (improvedAirBomber.FuelTanks)
            {
                g.DrawEllipse(pen, _startPosX + 25, _startPosY + 28, 35, 10);
                g.DrawEllipse(pen, _startPosX + 25, _startPosY + 62, 35, 10);
                g.FillEllipse(dopBrush, _startPosX + 25, _startPosY + 28, 35, 10);
                g.FillEllipse(dopBrush, _startPosX + 25, _startPosY + 62, 35, 10);
            }
            base.DrawAirBomber(g);
            if (improvedAirBomber.Bombs)
            {
                //Первая бомба
                g.DrawRectangle(pen, _startPosX + 30, _startPosY + 2, 2, 3);
                PointF point1 = new PointF(_startPosX + 32, _startPosY + 1);
                PointF point2 = new PointF(_startPosX + 37, _startPosY + 1);
                PointF point3 = new PointF(_startPosX + 39, _startPosY + 2);
                PointF point4 = new PointF(_startPosX + 44, _startPosY + 2);
                PointF point5 = new PointF(_startPosX + 43, _startPosY + 5);
                PointF point6 = new PointF(_startPosX + 39, _startPosY + 5);
                PointF point7 = new PointF(_startPosX + 37, _startPosY + 8);
                PointF point8 = new PointF(_startPosX + 32, _startPosY + 8);
                PointF[] pointsArray1 =
                    {
                    point1,
                    point2,
                    point3,
                    point4,
                    point5,
                    point6,
                    point7,
                    point8
                    };
                g.DrawPolygon(pen, pointsArray1);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY + 2, 7, 3);
                PointF point9 = new PointF(_startPosX + 57, _startPosY + 2);
                PointF point10 = new PointF(_startPosX + 60, _startPosY + 3.5f);
                PointF point11 = new PointF(_startPosX + 57, _startPosY + 5);
                PointF[] pointsArray2 =
                    {
                    point9,
                    point10,
                    point11
                    };
                g.DrawPolygon(pen, pointsArray2);
                g.FillRectangle(redBrush, _startPosX + 30, _startPosY + 2, 2, 3);
                g.FillPolygon(dopBrush, pointsArray1);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 2, 7, 3);
                g.FillPolygon(redBrush, pointsArray2);

                //Вторая бомба
                g.DrawRectangle(pen, _startPosX + 30, _startPosY + 11, 2, 3);
                PointF point12 = new PointF(_startPosX + 32, _startPosY + 10);
                PointF point13 = new PointF(_startPosX + 37, _startPosY + 10);
                PointF point14 = new PointF(_startPosX + 39, _startPosY + 11);
                PointF point15 = new PointF(_startPosX + 42, _startPosY + 11);
                PointF point16 = new PointF(_startPosX + 41, _startPosY + 14);
                PointF point17 = new PointF(_startPosX + 39, _startPosY + 14);
                PointF point18 = new PointF(_startPosX + 37, _startPosY + 17);
                PointF point19 = new PointF(_startPosX + 32, _startPosY + 17);
                PointF[] pointsArray3 =
                    {
                    point12,
                    point13,
                    point14,
                    point15,
                    point16,
                    point17,
                    point18,
                    point19
                    };
                g.DrawPolygon(pen, pointsArray3);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY + 11, 12, 3);
                PointF point20 = new PointF(_startPosX + 62, _startPosY + 11);
                PointF point21 = new PointF(_startPosX + 65, _startPosY + 12.5f);
                PointF point22 = new PointF(_startPosX + 62, _startPosY + 14);
                PointF[] pointsArray4 =
                    {
                    point20,
                    point21,
                    point22
                    };
                g.DrawPolygon(pen, pointsArray4);
                g.FillRectangle(redBrush, _startPosX + 30, _startPosY + 11, 2, 3);
                g.FillPolygon(dopBrush, pointsArray3);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 11, 12, 3);
                g.FillPolygon(redBrush, pointsArray4);

                //Третья бомба
                g.DrawRectangle(pen, _startPosX + 30, _startPosY + 20, 2, 3);
                PointF point23 = new PointF(_startPosX + 32, _startPosY + 19);
                PointF point24 = new PointF(_startPosX + 37, _startPosY + 19);
                PointF point25 = new PointF(_startPosX + 39, _startPosY + 20);
                PointF point26 = new PointF(_startPosX + 40.5f, _startPosY + 20);
                PointF point27 = new PointF(_startPosX + 40, _startPosY + 23);
                PointF point28 = new PointF(_startPosX + 39, _startPosY + 23);
                PointF point29 = new PointF(_startPosX + 37, _startPosY + 26);
                PointF point30 = new PointF(_startPosX + 32, _startPosY + 26);
                PointF[] pointsArray5 =
                    {
                    point23,
                    point24,
                    point25,
                    point26,
                    point27,
                    point28,
                    point29,
                    point30
                    };
                g.DrawPolygon(pen, pointsArray5);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY + 20, 17, 3);
                PointF point31 = new PointF(_startPosX + 67, _startPosY + 20);
                PointF point32 = new PointF(_startPosX + 70, _startPosY + 21.5f);
                PointF point33 = new PointF(_startPosX + 67, _startPosY + 23);
                PointF[] pointsArray6 =
                    {
                    point31,
                    point32,
                    point33
                    };
                g.DrawPolygon(pen, pointsArray6);
                g.FillRectangle(redBrush, _startPosX + 30, _startPosY + 20, 2, 3);
                g.FillPolygon(dopBrush, pointsArray5);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 20, 17, 3);
                g.FillPolygon(redBrush, pointsArray6);

                //Четвертая бомба
                g.DrawRectangle(pen, _startPosX + 30, _startPosY + 75, 2, 3);
                PointF point34 = new PointF(_startPosX + 32, _startPosY + 74);
                PointF point35 = new PointF(_startPosX + 37, _startPosY + 74);
                PointF point36 = new PointF(_startPosX + 39, _startPosY + 75);
                PointF point37 = new PointF(_startPosX + 40.5f, _startPosY + 75);
                PointF point38 = new PointF(_startPosX + 40, _startPosY + 78);
                PointF point39 = new PointF(_startPosX + 39, _startPosY + 78);
                PointF point40 = new PointF(_startPosX + 37, _startPosY + 81);
                PointF point41 = new PointF(_startPosX + 32, _startPosY + 81);
                PointF[] pointsArray7 =
                    {
                    point34,
                    point35,
                    point36,
                    point37,
                    point38,
                    point39,
                    point40,
                    point41
                    };
                g.DrawPolygon(pen, pointsArray5);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY + 75, 17, 3);
                PointF point42 = new PointF(_startPosX + 67, _startPosY + 75);
                PointF point43 = new PointF(_startPosX + 70, _startPosY + 76.5f);
                PointF point44 = new PointF(_startPosX + 67, _startPosY + 78);
                PointF[] pointsArray8 =
                    {
                    point42,
                    point43,
                    point44
                    };
                g.DrawPolygon(pen, pointsArray6);
                g.FillRectangle(redBrush, _startPosX + 30, _startPosY + 75, 2, 3);
                g.FillPolygon(dopBrush, pointsArray7);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 75, 17, 3);
                g.FillPolygon(redBrush, pointsArray8);

                //Пятая бомба
                g.DrawRectangle(pen, _startPosX + 30, _startPosY + 84, 2, 3);
                PointF point45 = new PointF(_startPosX + 32, _startPosY + 83);
                PointF point46 = new PointF(_startPosX + 37, _startPosY + 83);
                PointF point47 = new PointF(_startPosX + 39, _startPosY + 84);
                PointF point48 = new PointF(_startPosX + 42, _startPosY + 84);
                PointF point49 = new PointF(_startPosX + 41, _startPosY + 87);
                PointF point50 = new PointF(_startPosX + 39, _startPosY + 87);
                PointF point51 = new PointF(_startPosX + 37, _startPosY + 90);
                PointF point52 = new PointF(_startPosX + 32, _startPosY + 90);
                PointF[] pointsArray9 =
                    {
                    point45,
                    point46,
                    point47,
                    point48,
                    point49,
                    point50,
                    point51,
                    point52
                    };
                g.DrawPolygon(pen, pointsArray9);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY + 84, 12, 3);
                PointF point53 = new PointF(_startPosX + 62, _startPosY + 84);
                PointF point54 = new PointF(_startPosX + 65, _startPosY + 85.5f);
                PointF point55 = new PointF(_startPosX + 62, _startPosY + 87);
                PointF[] pointsArray10 =
                    {
                    point53,
                    point54,
                    point55
                    };
                g.DrawPolygon(pen, pointsArray10);
                g.FillRectangle(redBrush, _startPosX + 30, _startPosY + 84, 2, 3);
                g.FillPolygon(dopBrush, pointsArray9);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 84, 12, 3);
                g.FillPolygon(redBrush, pointsArray10);

                //Шестая бомба
                g.DrawRectangle(pen, _startPosX + 30, _startPosY + 93, 2, 3);
                PointF point56 = new PointF(_startPosX + 32, _startPosY + 92);
                PointF point57 = new PointF(_startPosX + 37, _startPosY + 92);
                PointF point58 = new PointF(_startPosX + 39, _startPosY + 93);
                PointF point59 = new PointF(_startPosX + 44, _startPosY + 93);
                PointF point60 = new PointF(_startPosX + 43, _startPosY + 96);
                PointF point61 = new PointF(_startPosX + 39, _startPosY + 96);
                PointF point62 = new PointF(_startPosX + 37, _startPosY + 99);
                PointF point63 = new PointF(_startPosX + 32, _startPosY + 99);
                PointF[] pointsArray11 =
                    {
                    point56,
                    point57,
                    point58,
                    point59,
                    point60,
                    point61,
                    point62,
                    point63
                    };
                g.DrawPolygon(pen, pointsArray11);
                g.DrawRectangle(pen, _startPosX + 50, _startPosY + 93, 7, 3);
                PointF point64 = new PointF(_startPosX + 57, _startPosY + 93);
                PointF point65 = new PointF(_startPosX + 60, _startPosY + 94.5f);
                PointF point66 = new PointF(_startPosX + 57, _startPosY + 96);
                PointF[] pointsArray12 =
                    {
                    point64,
                    point65,
                    point66
                    };
                g.DrawPolygon(pen, pointsArray2);
                g.FillRectangle(redBrush, _startPosX + 30, _startPosY + 93, 2, 3);
                g.FillPolygon(dopBrush, pointsArray11);
                g.FillRectangle(dopBrush, _startPosX + 50, _startPosY + 93, 7, 3);
                g.FillPolygon(redBrush, pointsArray12);
            }
        }
    }
}
