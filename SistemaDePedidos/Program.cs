using SistemaDePedidos.Historico;

{
    Cliente titular = new Cliente();
    titular.nome = "Luiz Silva";
    titular.endereco = "Rua Das Flores, 732 Apto 683 Bloco 1";
    titular.telefone = 123456789;

    Pedido pedido = new Pedido();
    pedido.Produto = "Livro 1984";
    pedido.titular = titular;
    pedido.ValorTotal = 35.20;
    pedido.NumeroPedido = 135;
    pedido.ValorProduto = 25.00;
    pedido.ValorFrete = 10.20;

    Console.WriteLine("Pedido Realizado");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Gerou o Número: " + pedido.NumeroPedido);
    Console.WriteLine("Produto: " + pedido.Produto);
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Dados do Titular da compra:");
    Console.WriteLine("Nome completo: " + pedido.titular.nome);
    Console.WriteLine("Endereço de entrega: " + pedido.titular.endereco);
    Console.WriteLine("Telefone para contato: " + pedido.titular.telefone);
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Valor do pedido");
    Console.WriteLine("Frete R$: " + pedido.ValorFrete);
    Console.WriteLine("Produto R$: " + pedido.ValorProduto);
    Console.WriteLine("Valor Total R$: " + pedido.ValorTotal);
    Console.WriteLine("------------------------------------------");

    Console.WriteLine("Aperte Enter para Sair...");
    return;
}

