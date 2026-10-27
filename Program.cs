using System;
using System.Collections.Generic;

class Animal
{
private string nome;
private int idade;

public string Nome
{
    get { return nome; }
    set { nome = value; }
}

public int Idade
{
    get { return idade; }
    set { idade = value; }
}

public Animal(string nome, int idade)
{
    Nome = nome;
    Idade = idade;
}

public virtual void EmitirSom()
{
    Console.WriteLine("O animal está emitindo um som.");
}
}

class Cachorro : Animal
{
public Cachorro(string nome, int idade) : base(nome, idade)
{
}

public override void EmitirSom()
{
    Console.WriteLine("O cachorro está latindo: Au au!");
}
}

class Gato : Animal
{
public Gato(string nome, int idade) : base(nome, idade)
{
}

public override void EmitirSom()
{
    Console.WriteLine("O gato está miando: Miau!");
}
}

class Program
{
static void Main(string[] args)
{
Cachorro cachorro = new Cachorro("Rex", 3);
Gato gato = new Gato("Mimi", 2);

    Console.WriteLine("CACHORRO");
    Console.WriteLine("Nome: " + cachorro.Nome);
    Console.WriteLine("Idade: " + cachorro.Idade);
    cachorro.EmitirSom();

    Console.WriteLine();

    Console.WriteLine("GATO");
    Console.WriteLine("Nome: " + gato.Nome);
    Console.WriteLine("Idade: " + gato.Idade);
    gato.EmitirSom();

    Console.WriteLine();

    List<Animal> animais = new List<Animal>();

    animais.Add(cachorro);
    animais.Add(gato);

    Console.WriteLine("LISTA DE ANIMAIS");

    foreach (Animal animal in animais)
    {
        Console.WriteLine("Nome: " + animal.Nome);
        Console.WriteLine("Idade: " + animal.Idade);
        animal.EmitirSom();
        Console.WriteLine();
    }
}
}