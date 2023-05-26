

using System.IO;

namespace exercicios_de_fixação.Model
{
    public class Evento
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        private const string PATH = "Database/Produto.csv";
        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }


            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Evento p = new Evento();

                p.Nome = atributos[0];
                p.Descricao = atributos[1];
                p.Data = DateTime.Parse(atributos[2]);

                eventos.Add(p);
            }
            return eventos;
        }

        public string PrepararLInhaCSV(Evento p)
        {
            return $"{p.Nome};{p.Descricao};{p.Data}";
            
        }

        public void inserir(Evento p)
        {
            string[] linhas = {PrepararLInhaCSV(p) };

            File.AppendAllLines(PATH, linhas);
        }
    }
}