using System;
using System.Collections.Generic;
using exercicio02.Models;

Livro livro1 = new Livro();
Autor autorLivro1 = new Autor();

livro1.Nome = "Harry Potter";
autorLivro1.Nome = "J.K. Rowling";
autorLivro1.Email = "jkrowling@gmail.com";

livro1.autores.Add(autorLivro1);

Console.WriteLine(livro1.Nome);
Console.WriteLine(livro1.autores[0].Nome);
Console.WriteLine(livro1.autores[0].Email);