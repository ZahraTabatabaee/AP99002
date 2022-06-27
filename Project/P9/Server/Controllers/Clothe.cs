using System ;
namespace P9.Server.Controllers
{
    public class Clothe
    {
        public int Price {get; set ;}
        public string Name {get; set ;}
        public int Id {get; set ;}
        public string Color {get; set ;}
        public override string ToString()
        {
            return $"{this.Name}, {this.Price}, {this.Id}, {this.Color}";
        }
        public override int GetHashCode()
        {
            return this.Id ;
        }
        public override bool Equals(object obj)
        {
            var other = obj as Clothe ;
            if(obj is null)
                return false ;
            return this.Id == other.Id ;
        }
        public void SetValue( Clothe other)
        {
            this.Price = other.Price ;
            this.Name = other.Name ;
            this.Color = other.Color;
        }
    }

}