using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    /// <summary>
    /// Класс, отвечающий за прорисовку и перемещение объекта-сущности
    /// </summary>
    internal class DrawingMoving
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public EntityAirBomber AirBomber { get; protected set; }
        /// <summary>
        /// Левая координата отрисовки бомбардировщика
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Верхняя кооридната отрисовки бомбардировщика
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth = null;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight = null;
        /// <summary>
        /// Ширина отрисовки бомбардировщика
        /// </summary>
        private readonly int _airBomberWidth = 100;
        /// <summary>
        /// Высота отрисовки бомбардировщика
        /// </summary>
        private readonly int _airBomberHeight = 100;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость бомбардировщика</param>
        /// <param name="weight">Вес бомбардировщика</param>
        /// <param name="bodyColor">Цвет корпуса бомбардировщика</param>
        public DrawingMoving(int speed, float weight, Color bodyColor)
        {
            AirBomber = new EntityAirBomber(speed, weight, bodyColor);
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        protected DrawingMoving(int speed, float weight, Color bodyColor, int airBomberWidth, int airBomberHeight) : this(speed, weight, bodyColor)
        {
            _airBomberWidth = airBomberWidth;
            _airBomberHeight = airBomberHeight;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            if (width < _airBomberWidth || height < _airBomberHeight || x > width || y > height)
            {
                return;
            }
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveAirBomber(Direction direction)
        {
            if (!_pictureWidth.HasValue || !_pictureHeight.HasValue)
            {
                return;
            }
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + _airBomberWidth + AirBomber.Step < _pictureWidth)
                    {
                        _startPosX += AirBomber.Step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX > AirBomber.Step)
                    {
                        _startPosX -= AirBomber.Step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY > AirBomber.Step)
                    {
                        _startPosY -= AirBomber.Step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + _airBomberHeight + AirBomber.Step < _pictureHeight)
                    {
                        _startPosY += AirBomber.Step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка бомбардировщика
        /// </summary>
        /// <param name="g"></param>
        public virtual void DrawAirBomber(Graphics g)
        {
            if (_startPosX < 0 || _startPosY < 0 || !_pictureHeight.HasValue || !_pictureWidth.HasValue)
            {
                return;
            }
            Pen pen = new(Color.Black);
            //границы бомбардировщика
            PointF point1 = new PointF(_startPosX, _startPosY + 20);
            PointF point2 = new PointF(_startPosX + 15, _startPosY + 35);
            PointF point3 = new PointF(_startPosX + 15, _startPosY + 40);
            PointF point4 = new PointF(_startPosX, _startPosY + 40);
            PointF[] pointsArray1 =
                {
                    point1,
                    point2,
                    point3,
                    point4
                };
            g.DrawPolygon(pen, pointsArray1);

            PointF point5 = new PointF(_startPosX, _startPosY + 60);
            PointF point6 = new PointF(_startPosX + 15, _startPosY + 60);
            PointF point7 = new PointF(_startPosX + 15, _startPosY + 65);
            PointF point8 = new PointF(_startPosX, _startPosY + 80);
            PointF[] pointsArray2 =
                {
                    point5,
                    point6,
                    point7,
                    point8
                };
            g.DrawPolygon(pen, pointsArray2);

            g.DrawRectangle(pen, _startPosX, _startPosY + 40, 80, 20);

            PointF point9 = new PointF(_startPosX + 35, _startPosY + 40);
            PointF point10 = new PointF(_startPosX + 45, _startPosY);
            PointF point11 = new PointF(_startPosX + 50, _startPosY);
            PointF point12 = new PointF(_startPosX + 50, _startPosY + 40);
            PointF[] pointsArray3 =
                {
                    point9,
                    point10,
                    point11,
                    point12
                };
            g.DrawPolygon(pen, pointsArray3);

            PointF point13 = new PointF(_startPosX + 35, _startPosY + 60);
            PointF point14 = new PointF(_startPosX + 50, _startPosY + 60);
            PointF point15 = new PointF(_startPosX + 50, _startPosY + 100);
            PointF point16 = new PointF(_startPosX + 45, _startPosY + 100);
            PointF[] pointsArray4 =
                {
                    point13,
                    point14,
                    point15,
                    point16
                };
            g.DrawPolygon(pen, pointsArray4);

            PointF point17 = new PointF(_startPosX + 80, _startPosY + 40);
            PointF point18 = new PointF(_startPosX + 100, _startPosY + 50);
            PointF point19 = new PointF(_startPosX + 80, _startPosY + 60);
            PointF[] pointsArray5 =
                {
                    point17,
                    point18,
                    point19
                };
            g.DrawPolygon(pen, pointsArray5);

            //Заливка корпуса
            Brush br = new SolidBrush(AirBomber?.BodyColor ?? Color.Black);
            g.FillPolygon(br, pointsArray1);
            g.FillPolygon(br, pointsArray2);
            g.FillPolygon(br, pointsArray3);
            g.FillPolygon(br, pointsArray4);
            g.FillRectangle(br, _startPosX, _startPosY + 40, 80, 20);
            Brush brBlack = new SolidBrush(Color.Black);
            g.FillPolygon(brBlack, pointsArray5);
        }
        /// <summary>
        /// Смена границ формы отрисовки
        /// </summary>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= _airBomberWidth || _pictureHeight <= _airBomberHeight)
            {
                _pictureWidth = null;
                _pictureHeight = null;
                return;
            }
            if (_startPosX + _airBomberWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - _airBomberWidth;
            }
            if (_startPosY + _airBomberHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - _airBomberHeight;
            }
        }
        /// <summary>
        /// Получение текущей позиции объекта
        /// </summary>
        /// <returns></returns>
        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition() 
        {
            return (_startPosX, _startPosY, _startPosX + _airBomberWidth, _startPosY + _airBomberHeight);
        }

    }
}
