using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Sighting
    {
        public int ID { get; set; }

        public string ObserverName { get; set; }

        public bool AllowPublicDisplay { get; set; }

        public string ObserverLocation { get; set; }

        public string PhenomenonLocationName { get; set; }

        public string PhenomenonLocationCoordinates { get; set; }

        public DateTime DateAndTime { get; set; } = DateTime.Now;

        public string Description { get; set; }

        public override string ToString()
        {
            return $"ID: {ID},\n" +
                   $"Observer name: {ObserverName}\n" +
                   $"Observer location: {ObserverLocation}\n" +
                   $"Phenomenon location: {PhenomenonLocationName}\n" +
                   $"Phenomenon coordinates: {PhenomenonLocationCoordinates}\n" +
                   $"Date and time: {DateAndTime}\n" +
                   $"Description: {Description}";
        }
    }
}
