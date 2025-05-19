using ExerciciosDiversosOO;

Titular titular = new Titular("Silvia Silva", "000.000.001-91", "Rua da Gloria, 123");
Conta minhaConta = new Conta(titular, 134, 5859, 0);

Console.WriteLine(minhaConta.Informacoes);

CatalogoJogos JogosDeFutebol = new CatalogoJogos("ESPORTES 2008");

JogosDeFutebol.AdicionarJogo(new Jogo("FIFA 2008", "LIVRE", "Esporte", 2, "PC"));
JogosDeFutebol.AdicionarJogo(new Jogo("NBA 2008", "LIVRE", "Esporte", 2, "PC"));
JogosDeFutebol.AdicionarJogo(new Jogo("MLB 2008", "LIVRE", "Esporte", 2, "PC"));

JogosDeFutebol.ExibirCatalogo();