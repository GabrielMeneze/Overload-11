namespace Overload_11
{
    public class Cauculo
    {
        public string Calcular(){
            return "Dados do jogador:";
        }

        public string Calcular(int vida){
            return "Vida Total: "+vida;
        }

        public string Calcular(int vida, int Defesa){
            return "Defesa Total: "+ (vida+Defesa);
        }

        public string Calcular(string nome, string sobrenome){
            return $"Golpe especial: {nome} {sobrenome}";
        }      

    }
}