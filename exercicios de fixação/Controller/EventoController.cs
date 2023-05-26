
using exercicios_de_fixação.Model;
using exercicios_de_fixação.View;

namespace exercicios_de_fixação.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();

        EventoView eventoView = new EventoView();

        public void ListarEventos()
        {
            List<Evento> produtos = evento.Ler();

            eventoView.Listar(produtos);
        }


        public void CadastrarEvento()
        {

            //chamada para a a view que recebe cada objeto a ser inserido no csv
            Evento novoEvento = eventoView.Cadastrar();

            //chamda para a model para inserir esse objeto no csv
            evento.inserir(novoEvento);



        }
    }
}