using System;
using System.Collections.Generic;
using exercicio02.Models;

Livro livro1 = new Livro();
Autor autorLivro1 = new Autor();
Autor autor2Livro1 = new Autor();

livro1.Nome = "Harry Potter";
autorLivro1.Nome = "J.K. Rowling";
autorLivro1.Email = "jkrowling@gmail.com";
autor2Livro1.Nome = "Lucas";
autor2Livro1.Email = "lucaslucass@gmail.com";

livro1.autores.Add(autorLivro1);
livro1.autores.Add(autor2Livro1);

Console.WriteLine(livro1.autores[0].Nome);
Console.WriteLine(livro1.autores[0].Email);
Console.WriteLine(livro1.autores[1].Nome);
Console.WriteLine(livro1.autores[1].Email);

Livro livro2 = new Livro();
Autor autorLivro2 = new Autor();
Autor autor2Livro2 = new Autor();

livro2.Nome = "Fortaleza Digital";
autorLivro2.Nome = "Dan Brown";
autorLivro2.Email = "dandanbrown@gmail.com";
autor2Livro2.Nome = "Lucas";
autor2Livro2.Email = "lucaslucass@gmail.com";

livro2.autores.Add(autorLivro2);
livro2.autores.Add(autor2Livro2);

Console.WriteLine(livro2.autores[0].Nome);
Console.WriteLine(livro2.autores[0].Email);
Console.WriteLine(livro2.autores[1].Nome);
Console.WriteLine(livro2.autores[1].Email);
