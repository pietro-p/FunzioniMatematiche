using System;
using System.ComponentModel;
using System.IO;

public class matematica
{
    public static int sommaInt(int a, int b)
    {

        return a + b;
    }
    public static double sommaDouble(double a, double b)
    {

        return a + b;
    }
    public static double differenza(double a, double b)
    {

        return a - b;

    }
    public static double moltipcicazione(double a, double b)
    {
        return a * b;

    }
    public static double divisione(double a, double b)
    {
        return a / b;

    }
    public static long potenza(int a, int b)
    {
        long p = 1;
        int cont = 0;
        for (; cont < b; cont++)
        {
            p = p * a;
        }
        return p;
    }
    public static long CalcoloFattoriale(int a)
    {
        long f = 1;
        int cont = 1;
        for (; cont <= a; cont++)
        {
            f = f * cont;
        }
        return f;
    }
    public static int MinoreTra(int a, int b, int c)
    {
        int min;
        if (a < b && a < c)
        {
            min = a;
        }
        else if (b < a && b < c)
        {
            min = b;
        }
        else
        {
            min = c;
        }
    }
    public static int MaggioreTra(int a, int b, int c)
    {
        int max;
        if (a > b && a > c)
        {
            max = a;
        }
        else if (b > a && b > c)
        {
            max = b;
        }
        else
        {
            max = c;
        }
    }
    public static int inverso(int a, int b, int c)
    {
        return n = n * -1;     
    }
}