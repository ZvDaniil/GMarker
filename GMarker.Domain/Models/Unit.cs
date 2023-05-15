namespace GMarker.Domain.Models
{
    /// <summary>
    /// Модель условной единицы техники.
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Широта.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Долгота.
        /// </summary>
        public double Longitude { get; set; }
    }
}