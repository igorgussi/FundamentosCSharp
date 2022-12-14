using ExemploFundamentos.Common.Models;  //Mostrando o namespace ao qual as classes estão

Pessoa p = new Pessoa(); 














//Estruturas de repetição 

//Menu interativo 
/*
String opc = "";

while(true){
    
    Console.WriteLine("Digite a sua opção: \n");
    Console.WriteLine("1- Cadastrar Cliente\n ");
    Console.WriteLine("2- Buscar Cliente\n ");
    Console.WriteLine("3- Excluir Cliente\n ");
    Console.WriteLine("4- Encerrar\n ");

    opc = Console.ReadLine();

    switch (opc)
    {
        case "1":
        Console.WriteLine("Cadaastro de Cliente");
        break;

        case "2":
        Console.WriteLine("Buscar Cliente");
        break;

        case "3":
        Console.WriteLine("Excluir Cliente");
        break;

        case "4":
        Console.WriteLine("Encerrando...");
        Environment.Exit(0); //Para encerrar o programa
        break;

        default:
        Console.WriteLine("Opção inválida!");
        break;
    }
}
*/





//do while
/*
int soma = 0, numero = 0;

do{
    Console.WriteLine("Digite um numero (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero; // ------> soma = soma + numero

}while(numero != 0);

Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");
*/





/*
//While 
int numero;
int cont = 0; //a posição inicial da variavel contador é declarada préviamente

Console.WriteLine("Digite o número da tabuada que deseja: ");
numero = Convert.ToInt32(Console.ReadLine());

while(cont <= 10){
    Console.WriteLine($"{numero} * {cont} = {numero * cont}");
    cont++; // a incrementação é passada dentro do while

    if (cont == 6){
        break; //utilizando para interroper o fluxo de execução quando o contador atingir  a 6(sexta) Execução
    }
}
*/




/*
//for 
int numero;
Console.WriteLine("Digite o número da tabuada que deseja: ");
numero = Convert.ToInt32(Console.ReadLine());

//   inicio        parada      incremento/decremento 
for(int cont = 0; cont <= 10; cont++){
    Console.WriteLine($"{numero} * {cont} = {numero * cont}");
}
*/









//Criando uma calculadora 
/*
Calculadora calc = new Calculadora();
double x = 0, y = 0;
string operacao;

Console.WriteLine ("Digite o primeiro numero: ");
x = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("\nSelecione a operação desejada: \n 1(+) --> Soma\n 2(-) --> Subtração\n 3(/) --> Divisão\n 4(*) --> Multiplicação\n 5(^) --> Potência\n 6 --> Funções Trigonométricas\n 7 --> Raiz Quadrada \n\n\n 0 --> Sair");
operacao = Console.ReadLine();

switch (operacao){
    case "1" or "+":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Somar(x, y);
    break;

    case "2" or "-":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Subtrair(x, y);
    break;

    case "3" or "*":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Multiplicar(x, y);
    break;

    case "4" or "/":
    Console.WriteLine ("\nDigite o segundo numero: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Dividir(x, y);
    break;

    case "5" or "^":
    Console.WriteLine ("\nDigite o expoente: ");
    y = Convert.ToDouble (Console.ReadLine());
    calc.Potencia(x, y);
    break;

    case "6":
    int opcTrigonometrica;

    Console.WriteLine("Selecione a operção Trigonométrica: \n 1 - Seno\n 2 - Coseno\n 3 - Tangente");
    opcTrigonometrica = Convert.ToInt32(Console.ReadLine());
        if (opcTrigonometrica == 1){
            calc.Seno(x);
        }
        else if(opcTrigonometrica == 2){
            calc.Coseno(x);
        }
        else if (opcTrigonometrica == 3){
            calc.Tangente(x);
        }
    break;

    case "7":
    calc.RaizQuadrada(x);
    break;

    case "0":
    Console.WriteLine("Obrigado, até mais!");
    Console.WriteLine("Encerrando...");
    Environment.Exit(0); //Para encerrar o programa
    break;

    default:
    Console.WriteLine($"Operação '{operacao}' não pode ser encontrada!");
    break;
}
*/






//Switch Case
/*
Console.WriteLine("Digite uma Letra");
string letra = Console.ReadLine();

switch (letra){
    case "a":
    case "e": 
    case "i": 
    case "o": 
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Consoante");
        break;

}
*/


//Operadores condicionais 
//(&& And)
//(|| Or)
// (&& !  NOT)

/*
int idade = 0;

Console.WriteLine("Qual a sua idade?");
 idade = Convert.ToInt32 (Console.ReadLine());

if (idade > 0 && idade < 5){
    Console.WriteLine("Bêbe");
}
else if ( idade >= 5 && idade <= 12 ){
    Console.WriteLine("Criança");
}
else if(idade > 12 && idade < 18){
    Console.WriteLine("Adolescente");
}
else if(idade >= 18 && idade < 60){
    Console.WriteLine("Adulto");
}
else if(idade >= 60 ){
    Console.WriteLine("Idoso");
}
*/




//Operador de atribuição (=)
/*
int a= 2, b = 1, c = a +b;
Console.WriteLine($"O valor de c é: {c}" );
*/




//Operadores aritiméticos (+, -, *, /)
/*
int  a = 1, b = 2, c = a + b;
//c = c + 5;
//ou 
c += 5;
Console.WriteLine($"O valor de c é: {c}");
*/



//Conversão de valores (Cast - Casting)
/*
int  a = Convert.ToInt32 ("5"); // Utilizando o método Convert
int b = int.Parse("6"); //Utilizando o método Parse
Console.WriteLine($"Valor de a é: {a}");
Console.WriteLine($"Valor de b é: {b}");
*/

 

//Conversão para String
/*
int  inteiro = 5;
string a = inteiro.ToString(); //O comando ToStrin() converte qualquer tipo para String 

Console.WriteLine($"{a}");
*/



//Casting implicito
/*
int a = 5; 
double b = a;
Console.WriteLine(b.ToString("0.00"));
*/

//Convertendo de maneira segura 
/*
string a="15-";
int b = 0;

int.TryParse (a, out b); //Nesse caso ele tenta converter a variável "a" de string para int, porém, caso ele não consiga ele não encerra o programa, ele aponta para a variavel "b" como valor de saída
Console.WriteLine(b);
Console.WriteLine("Linha teste para testar execução!");
*/



//Variável do Tipo DateTime
/*
DateTime dataatual = DateTime.Now; //Puxa a data atual do computador. Caso queria adicionar dias na data atual .AddDays(5)
Console.WriteLine($"A data e hora atual são: {dataatual}"); // Caso queira formatar apenas para aparecer dd/MM/yyyy:  .ToString("dd/MM/yyyy") ou .ToString("HH/mm") para mostrar somente a hora.
*/
//Declarando variáveis
/*
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.70;
decimal preco= 1.99M; //valores decimais, é necessário colocar um M no final
bool condicao = true;



//Exibindo variáveis
Console.WriteLine($"{apresentacao}");
Console.WriteLine($"O valor da variável quantidade é: {quantidade}");
Console.WriteLine($"O valor da variável altura é:{altura.ToString("0.00")}"); //Tratamento para colocar casa decimal em variável do tipo double: ToString("0.00")
Console.WriteLine($"O valor da variável preço é: {preco}");
Console.WriteLine($"O valor da variável condição é: {condicao}");
*/



//Instanciando uma classe 
/*
Produto pr = new Produto();
pr.Nome = "Detergente";
pr.Preco = 1.98M;
pr.Validade  = Convert.ToDateTime("10/01/2024"); //Para inserir uma data é preciso fazer a conversão de String para DateTime
pr.ChamaProduto();

Pessoa p = new Pessoa();
p.Nome = "Igor";
p.Idade = 20;
p.Apresentar();
*/


