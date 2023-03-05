using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    /// <summary>
    /// Класс-сущность "Улучшенный бомбардировщик"
    /// </summary>
    internal class EntityImprovedAirBomber : EntityAirBomber
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { get; private set; }
        /// <summary>
        /// Признак наличия дополнительных топливных баков
        /// </summary>
        public bool FuelTanks { get; private set; }
        /// <summary>
        /// Признак наличия бомб
        /// </summary>
        public bool Bombs { get; private set; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="speed">Скорость бомбардировщика</param>
        /// <param name="weight">Вес бомбардировщика</param>
        /// <param name="bodyColor">Цвет корпуса бомбардировщика</param>
        /// <param name="dopColor">Дополнительный цвет бомбардировщика</param>
        /// <param name="fuelTanks">Признак наличия дополнительных топливных баков</param>
        /// <param name="bombs">Признак наличия бомб</param>
        public EntityImprovedAirBomber(int speed, float weight, Color bodyColor, Color dopColor, bool fuelTanks, bool bombs) : base(speed, weight, bodyColor)
        {
            DopColor = dopColor;
            FuelTanks = fuelTanks;
            Bombs = bombs;
        }
    }
}
