using System;
using JogoRPG.Entities;

namespace JogoRPG
{

class Program {

static void Main(string[] args){


Gatosgerreiros Pandorolider = new Gatosgerreiros ("Pandoro", 23, "Lider");

Magos NinaMaga = new Magos ("Nina", 20, "Maga");



Console.Write(NinaMaga.Attack());

}

}
}