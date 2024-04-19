using PaintingModel;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PaintingDL
{
  
    public class DataLayer
    {
        public DataLayer()
        {
            History();
        }
        List<Model> famouspainting = new List<Model>();

        public void History()
        {
            Model famous1Painting = new Model()
            {
                Title = "Mona Lisa",
                Painter = "Leonardo da Vinci",
                Date = "Year 1503 to 1519",
                Where = "Lourve Museum (Paris)",
                Description = "Famous portrait of Lisa Gherardini, known for its enigmatic smile.",
            };

            Model famous2Painting = new Model()
            {
                Title = "The Starry Night",
                Painter = "Vincent van Gogh",
                Date = "Year 1889",
                Where = "Museum of Modern Art (New York City)",
                Description = "Iconic depiction of the night sky, featuring swirling clouds and stars.",
            };

            Model famous3Painting = new Model()
            {
                Title = "The Last Supper",
                Painter = "Leonardo da Vinci",
                Date = "Year 1495 to 1498",
                Where = "Santa Maria delle Grazie (Milan, Italy)",
                Description = "Religious mural depicting the last supper of Jesus with his disciples.",
            };

            Model famous4Painting = new Model()
            {
                Title = "The Persistence of Memory",
                Painter = "Salvador Dali",
                Date = "Year 1931",
                Where = "The Museum of Modern Art (New York City)",
                Description = "Surrealist painting featuring melting clocks draped over various objects.",
            };

            Model famous5Painting = new Model()
            {
                Title = "Guernica",
                Painter = "Pablo Picasso",
                Date = "Year 1937",
                Where = "Museo Reina Sofia (Madrid)",
                Description = "Powerful anti-war mural depicting the boming of Guernica during the Spanish Civil War.",
            };
            Model famous6Painting = new Model()
            {
                Title = "The Scream",
                Painter = "Edvard Munch",
                Date = "Year 1893",
                Where = "National Museum (Oslo)",
                Description = "Depicts deformed human figure disturbingly screaming in a landscape with unnatural colors.",
            };
            Model famous7Painting = new Model()
            {
                Title = "The Kiss",
                Painter = "Gustav Klimt",
                Date = "Year 1907",
                Where = "Upper Belvedere Museum (Vienna, Austria)",
                Description = "A pair of lovers, kneeling on a flower meadow and wearing lavish golden robes an infinite cosmos of golden fog.",
            };
            Model famous8Painting = new Model()
            {
                Title = "Girl With a Pearl Earing",
                Painter = "Johannes Vermeer",
                Date = "Year 1665",
                Where = "Mauritshuis (The Hague, Netherlands)",
                Description = "A young woman in a dark shallow space, an intimate setting that draws the viewer's attention exclusively on her.",
            };

            famouspainting.Add(famous1Painting);
            famouspainting.Add(famous2Painting);
            famouspainting.Add(famous3Painting);
            famouspainting.Add(famous4Painting);
            famouspainting.Add(famous5Painting);
            famouspainting.Add(famous6Painting);
            famouspainting.Add(famous7Painting);
            famouspainting.Add(famous8Painting);
        }
        
        public List<Model> GMS()
        {
            return famouspainting;
        }

        public void AddPainting(Model painting)
        {
            famouspainting.Add(painting);
        }

        public void RemovePainting(string title)
        {
            Model paintingToRemove = famouspainting.Find(p => p.Title == title);
            if (paintingToRemove != null)
            {
                famouspainting.Remove(paintingToRemove);
            }
            else
            {
                Console.WriteLine("Painting not found.");
            }
        }
    }
}
