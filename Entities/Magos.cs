namespace JogoRPG.Entities
{
    public class Magos : Gatosgerreiros
    {

        public Magos (string name, int level, string gatos)
        {
            this.name = name;
            this.level = level;
            this.gatos = gatos;
        }
    
        public override string Attack(){
            return this.name + "Lançou magia";
        }
    }
}