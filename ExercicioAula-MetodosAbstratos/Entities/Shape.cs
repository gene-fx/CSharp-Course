using ExercicioAula_MetodosAbstratos.Entities.Enums;

namespace ExercicioAula_MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
