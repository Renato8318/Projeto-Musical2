Banda queen = new Banda();
queen.Nome = "Queen";

Album albumDoQueen = new Album();
albumDoQueen.Nome = "A nigth at the opera";

Musica musica = new Musica(queen);
musica.Nome = "Love of my life";
musica.Duracao = 213;

Musica musica2 = new Musica(queen);
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica);
albumDoQueen.AdicionarMusica(musica2);


albumDoQueen.ExibirMusicasDoAlbum();
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();