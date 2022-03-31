namespace JogoRPG.Entities
{
    public class Gatosgerreiros
    {

        public Gatosgerreiros (string name, int level, string gatos){
            this.name = name;
            this.level = level;
            this.gatos = gatos;
        }
        public string name;
        public int level;
        public string gatos;

        public override string ToString(){
            return this.name + " " + this.level + " " + this.gatos;
        }
        
        public virtual string Attack(){
            return this.name + "Atacou com a sua espada";
        }
    }
}