﻿Musica musica1 = new Musica();
musica1.nome = "Walk";
musica1.artista = "Foo Fighters";
musica1.duracao = 275;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 375;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();