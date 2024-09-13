Livro livro1 = new Livro();
livro1.titulo = "SPQR";
livro1.autor = "Mary Beard";
livro1.ano = 2015;
livro1.paginas = 560;

livro1.Informacoes();

Livro livro2 = new Livro();
livro2.titulo = "Arte da Guerra";
livro2.autor = "Sun Tzu";
livro2.ano = 480;
livro2.paginas = 128;

livro2.Informacoes();
livro2.TemMaisDe300Paginas();

if(livro2.TemMaisDe300Paginas())
{
    Console.WriteLine("tem mais de 300 páginas!");
}
else
{
    Console.WriteLine("tem menos de 300 páginas");
}