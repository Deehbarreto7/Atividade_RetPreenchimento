Console.Write("Qual a largura?" );
int largura = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual a altura? ");
int altura = Convert.ToInt32(Console.ReadLine());

string preenchimento = "*";

int contadorLinha = 0;
while(contadorLinha < altura)
{
    int contadorColuna = 0;
    while(contadorColuna < largura)
    {
         Console.Write(preenchimento);
         contadorColuna = contadorColuna +1;
    }
    
    Console.WriteLine();
    contadorLinha = contadorLinha +1;
}
