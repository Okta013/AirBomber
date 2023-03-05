using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    /// <summary>
    /// Класс-сущность "Бомбардировщик"
    /// </summary>
    internal class EntityAirBomber
    {
        /// <summary>
        /// Скорость бомбардировщика
        /// </summary>
        public int Speed { get; private set; }
        /// <summary>
        /// Вес бомбардировщика
        /// </summary>
        public float Weight { get; private set; }
        /// <summary>
        /// Цвет корпуса бомбардировщика
        /// </summary>
        public Color BodyColor { get; private set; }
        public float Step => Speed * 100 / Weight;
        /// <summary>
        /// Инициализация полей объекта-класса бомбардировщика
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="weight"></param>
        /// <param name="bodyColor"></param>
        /// <returns></returns>
        public EntityAirBomber(int speed, float weight, Color bodyColor)
        {
            Random rnd = new Random();
            Speed = speed <= 0 ? rnd.Next(50, 150) : speed;
            Weight = weight <= 0 ? rnd.Next(40, 70) : weight;
            BodyColor = bodyColor;
        }
    }
}
