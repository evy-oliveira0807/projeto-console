namespace console_mvc.Model
{
    public class Produto
    {
        //Propriedades

        public int Codigo { get; set; }
        public string Nome { get; set; }

        public float Preco { get; set; }

        //Caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            //obter o caminho da pasta
            string pasta = PATH.Split("/")[0]; // "Database"

            //Se nao existir uma pasta Database, entao criar-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se nao existir um arquivo csv no caminho, entao criar-se uma
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }


        }

        public List<Produto> Ler()
        {
            //instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {

                //antes do split
                //001;Salgatinho;3,50

                //array que recebe os itens da linha separado por ";"
                string[] atributos = item.Split(";");

                //após o split
                //atributo[0] = "001"
                //atributo[1] = "Salgadinho"
                //atributo[2] = "3,50"

                // instancia de objeto produt0
                Produto p = new Produto();

                // atribuir os dados dentro de um objeto 
                p.Codigo = int.Parse(atributos[0]);//001
                p.Nome = atributos[1];//"salgadinho"
                p.Preco = float.Parse(atributos[2]); //3,50

                //adicionar os objetos dentro da lista
                produtos.Add(p);
            }
            //retorna a lista de produtos
            return produtos;

        }

        //metodo para preparar a linha do csv

        public string PrepararLinhaCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }

        //metodo para inserir um rpoduto no arquivo csv

        public void inserir(Produto p)
        {
            //array que vai amarzenar as linhas(cada ""objeto)
            string[] linhas = { PrepararLinhaCSV(p) };

            //vai ate o arquivo e insere todas as linhas

            File.AppendAllLines(PATH, linhas);

        }

    }
}