using System;
public class CalculoPGTO
{

    public static void Main()
    {
        //Lê os valores de entrada 

        float valorSalario = float.Parse(Console.ReadLine());
        float valorBeneficio = float.Parse(Console.ReadLine());

        float valorImposto = 0;

        //Calcula o valor do imposto para salarios de 0 até 1.100
        if (valorSalario >= 0 && valorSalario <= 1100)
        {
            valorImposto = 0.05f * valorSalario;
        }
        else if (valorSalario >= 1100.01 && valorSalario <= 2500)
        {
            valorImposto = 0.10f * valorSalario;
        }
        else
        {
            valorImposto = 0.15f * valorSalario;
        }

        //Saída
        float saida = valorSalario - valorImposto + valorBeneficio;
        Console.WriteLine(saida.ToString("0.00"));

    }
}