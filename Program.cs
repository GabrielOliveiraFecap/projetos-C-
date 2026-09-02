
/** Exercicio 1 Lista 1
int n;

Console.WriteLine("Digite um número inteiro: ");
 n = int.Parse(Console.ReadLine());

while(n<5 || n>2000)
{
    Console.WriteLine("Digite um número entre 5 e 2000: ");
    n = int.Parse(Console.ReadLine());
}

double[] pares = new double[n];
double[] quadrados = new double[pares.Length];


for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        int j=0;
        pares[j] = i;
        quadrados[j] = Math.Pow(pares[j], 2);
        Console.WriteLine(pares[j]+ "^2 = " + quadrados[j]);
        j++;
    }
 
}*/

/*Exercicio 2 Lista 1
Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
1 x N = N      2 x N = 2N        ...       10 x N = 10N

int n;

Console.WriteLine("Digite um número inteiro: ");
 n = int.Parse(Console.ReadLine());

while(n<2 || n>1000)
{
    Console.WriteLine("Digite um número entre 2 e 1000: ");
    n = int.Parse(Console.ReadLine());
}

int[] sequencia = new int[10];

for (int i = 1; i <=10; i++)
{
    sequencia[i-1] = i;
    double resultadoTab = sequencia[i-1] * n;
    Console.WriteLine(sequencia[i-1] + " x " + n + " = " + resultadoTab);
}*/

/* Exercicio 3 Entrada
Um valor real R indicando o tamanho do raio do círculo da pergunta de Gollum.
Limites:
0 < R <= 10;

Saída
Um valor real com duas casas decimais indicando o tamanho total da circunferência do círculo da pergunta de Gollum. */




    




