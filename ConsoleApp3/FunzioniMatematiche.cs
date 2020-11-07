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
   
    public static double inverso(int a)
    {
        return a = a * -1;
    }
    public static bool IsPari(int a)
    {
        bool IsPari;
        if(a%2==0)
        {
            IsPari = vero;
        }
        else
        {
            IsPari = falso;
        }
        return IsPari;
    }
    
    public static bool IsDispari(int a)
    {
        bool IsDispari;
        if (a % 2 == 0)
        {
            IsDispari = falso;
        }
        else
        {
            IsDispari = vero;
        }
        return IsDispari;
    }
    public static bool IsPositivo(int a)
    {
        bool IsPositivo;
        if (a >0  )
        {
            IsPositivo =vero;
        }
        else
        {
            IsPositivo = falso;
        }
        return IsPositivo;
    }
    public static bool IsNegativo(int a)
    {
        bool IsNegativo;
        if (a < 0)
        {
            IsNegativo = vero;
        }
        else
        {
            IsNegativo = falso;
        }
        return IsNegativo;
    }
}