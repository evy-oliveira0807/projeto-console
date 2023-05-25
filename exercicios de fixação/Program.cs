// Criar um programa console Para cadastro de Eventos. Aplique os conceitos MVC aprendidos em sala de aula.

// O evento deve ter Nome, Descrição e Data que o evento ocorrerá.

// As funcionalidades devem ser Cadastrar e Listar.

using exercicios_de_fixação.Controller;
using exercicios_de_fixação.Model;
using exercicios_de_fixação.View;

Evento novoEvento = new Evento();

EventoController controller = new EventoController();

controller.ListarEventos();