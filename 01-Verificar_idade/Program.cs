using System;
using System.Collections.Generic;

namespace VerificarIdade {
    class Program {
        static void Main (string[] args){
            Pessoa pessoa1 = new Pessoa ();
            Pessoa pessoa2 = new Pessoa ();
            // Pegar valores da pessoa 1
            Console.WriteLine("\n\n>> Digite o nome da 1° Pessoa:");
            pessoa1.nome = Console.ReadLine().ToUpper();
            Console.WriteLine("> Digite a idade de "+pessoa1.nome);
            pessoa1.idade = int.Parse(Console.ReadLine());
            // Pegar valores da pessoa 2
            Console.WriteLine("\n>> Digite o nome da 2° Pessoa:");
            pessoa2.nome = Console.ReadLine().ToUpper();
            Console.WriteLine("\n> Digite a idade de "+pessoa2.nome);
            pessoa2.idade = int.Parse(Console.ReadLine());
            // Verificar quem é mais velho/a
            if (pessoa1.idade > pessoa2.idade){
                Console.WriteLine ("\n>> "+pessoa1.nome+" é mais velha(o) que "+pessoa2.nome);
            }else if (pessoa1.idade < pessoa2.idade){
                Console.WriteLine ("\n>> "+pessoa2.nome+" é mais velha(o) que "+pessoa1.nome);
            }else {
                Console.WriteLine ("\n>> "+pessoa2.nome+" é "+pessoa1.nome+" tem a mesma idade");
            }

            Console.ReadLine();
        }
    }
}
