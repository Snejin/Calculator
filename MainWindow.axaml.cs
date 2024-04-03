using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Diagnostics;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        string ing;
        double choice;
        double choice2;

        public MainWindow()
        {
            InitializeComponent();
            Null.Click += Null_Click;
            One.Click += One_Click;
            Two.Click += Two_Click;
            Three.Click += Three_Click;
            Four.Click += Four_Click;
            Five.Click += Five_Click;
            Six.Click += Six_Click;
            Seven.Click += Seven_Click;
            Eight.Click += Eight_Click;
            Nine.Click += Nine_Click;
            comma.Click += Comma_Click;
            step.Click += Step_Click;
            Delete.Click += Delete_Click;
            Equals.Click += Equals_Click;
            sko.Click += Sko_Click;
            skob.Click += Skob_Click;
            Plus.Click += Plus_Click;
            xᵞ.Click += Xᵞ_Click;
            Multiplication.Click += Multiplication_Click;
            Division.Click += Division_Click;
            teNx.Click += TeNx_Click;
          //  Erase.Click += Erase_Click; // удаление последнего символа
            smena.Click += Smena_Click;
            Minus.Click += Minus_Click;
            drob.Click += Drob_Click;
            Xmodul.Click += Xmodul_Click;
            Pi.Click += Pi_Click;
            e.Click += E_Click;
            fact.Click += Fact_Click;
            Sin.Click += Sin_Click;
            Cos.Click += Cos_Click;
            Cot.Click += Cot_Click;
            tan.Click += Tan_Click;
            Log.Click += Log_Click;
            Ln.Click += Ln_Click;
            x.Click += X_Click;
            exp.Click += Exp_Click;
            mod.Click += Mod_Click;
        }

        private void Mod_Click(object? sender, RoutedEventArgs e)
        {
            ing = "mod";
            choice = Convert.ToDouble(namepase.Text);
            string number = "";
            namepase.Text = number;
        }

        private void Exp_Click(object? sender, RoutedEventArgs e)
        {
            ing = ",e+";
            choice = Convert.ToDouble(namepase.Text);
            string number = "";
            namepase.Text = number;
        }
        // ²√x 
        private void X_Click(object? sender, RoutedEventArgs e)                                    
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double number2 = 10;
            double number = Convert.ToDouble(Math.Pow(number2, number1));
            namepase.Text = $"{number}";
        }
        private void Cot_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            double number = Convert.ToDouble(namepase.Text);
            double cot = 1 / Math.Tan(number);
            namepase.Text = Convert.ToString(cot);
        }
        private void Equals_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)         
        {
            if (ing == "+")
            {
                choice2 = Convert.ToDouble(namepase.Text);
                double number1 = Convert.ToDouble(choice);
                double number2 = Convert.ToDouble(choice2);
                double answer = Convert.ToDouble(number1 + number2);
                choice = answer;
                namepase.Text = Convert.ToString(choice);
            }
            else if (ing == "10x")
            {
                double number1 = Convert.ToDouble(choice);
                double number2 = 10;
                double number = Convert.ToDouble(Math.Pow(number2, number1));
                namepase.Text = $"{number}";
            }
            else if (ing == "-")
            {
                choice2 = Convert.ToDouble(namepase.Text);
                double number1 = Convert.ToDouble(choice);
                double number2 = Convert.ToDouble(choice2);
                double answer = Convert.ToDouble(number1 - number2);
                choice = answer;
                namepase.Text = Convert.ToString(choice);
            }
            else if (ing == "*")
            {
                choice2 = Convert.ToDouble(namepase.Text);
                double number1 = Convert.ToDouble(choice);
                double number2 = Convert.ToDouble(choice2);
                double answer = Convert.ToDouble(number1 * number2);
                choice = answer;
                namepase.Text = $"{choice}";
            }
            else if (ing == "/")
            {
                choice2 = Convert.ToDouble(namepase.Text);
                double number1 = Convert.ToDouble(choice);
                double number2 = Convert.ToDouble(choice2);
                double answer = Convert.ToDouble(number1 / number2);
                choice = answer;
                namepase.Text = $"{choice}";
            }
            else if (ing == "xᵞ")
            {
                choice2 = Convert.ToDouble(namepase.Text);
                double number1 = Convert.ToDouble(choice);
                double number2 = Convert.ToDouble(choice2);
                double number = Math.Pow(number1, number2);
                double answer = Convert.ToDouble(number);
                choice = answer;
                namepase.Text = $"{choice}";
            }
            else if (ing ==",e+")
            {
                choice2 = Convert.ToDouble(namepase.Text);
                double num = 10;
                double num2 = Convert.ToInt32(choice2);
                double num3 = Convert.ToInt32(choice);
                double answer = num3 * (Math.Pow(num, num2));
                namepase.Text = $"{answer}";
            }
            else if (ing == "mod")
            {
                choice2 = Convert.ToDouble(namepase.Text);
                double answer = choice % choice2;
                namepase.Text = $"{answer}";
            }
        }
        // Tan 
        private void Tan_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)            
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double answer = Convert.ToDouble((Math.Tan(number1)));
            namepase.Text = $"{answer}";
        }
        // Cos
        private void Cos_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)             
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double answer = Convert.ToDouble((Math.Cos(number1)));
            namepase.Text = $"{answer}";
        }
        //sin
        private void Sin_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)            
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double answer = Convert.ToDouble((Math.Sin(number1)));
            namepase.Text = $"{answer}";
        }
        // |x| 
        private void Xmodul_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)          
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double answer = Convert.ToDouble((Math.Abs(number1)));
            namepase.Text = $"{answer}";
        }       
        //е 
        private void E_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)              
        {
            string E = "2,7182818284590452353602874713527";
            double answer = Convert.ToDouble(E);
            namepase.Text = $"{answer}";
        }
        //Pi 
        private void Pi_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)             
        {
            string Pi = "3,1415926535897932384626433832795";
            double answer = Convert.ToDouble(Pi);
            namepase.Text = $"{answer}";
        }
        //x² 
        private void Step_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double number = number1 * number1;
            double answer = Convert.ToDouble(number);
            namepase.Text = $"{answer}";
        }
        //Ln 
        private void Ln_Click(object? sender, RoutedEventArgs e)                                    
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double number = Math.Log(number1);
            namepase.Text = Convert.ToString(number);
        }
        //Log  
        private void Log_Click(object? sender, RoutedEventArgs e)                                   
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double number = Math.Log10(number1);
            namepase.Text = Convert.ToString(number);
        }
        //10ᵡ 
        private void TeNx_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double number2 = 10;
            double number = Convert.ToDouble(Math.Pow(number2, number1));
            namepase.Text = $"{number}";
        }
        //¹/x 
        private void Drob_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            double number1 = Convert.ToDouble(namepase.Text);
            double number2 = 1;
            double number = Convert.ToDouble(number2 / number1);
            namepase.Text = $"{number}";
        }
        // +/- 
        private void Smena_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)          
        {
            if (namepase.Text[0] == '-')
                namepase.Text = namepase.Text.Remove(0, 1);
            else
                namepase.Text = "-" + namepase.Text;
        }
        // n!
        private void Fact_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)            
        {
            double num = Convert.ToDouble(namepase.Text);
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
                if (i == num)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0} * ", i);
                }
            }
            namepase.Text = $"{factorial}";
        }
        // /
        private void Division_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)        
        {
            ing = "/";
            choice = Convert.ToDouble(namepase.Text);
            string number = "";
            namepase.Text = number;
        }
        // * 
        private void Multiplication_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) 
        {
            ing = "*";
            choice = Convert.ToDouble(namepase.Text);
            string number = "";
            namepase.Text = number;
        }
        // xᵞ 
        private void Xᵞ_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)             
        {
            ing = "xᵞ";
            choice = Convert.ToDouble(namepase.Text);
            string number = "";
            namepase.Text = number;
        }
        // - 
        private void Minus_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)          
        {
            ing = "-";
            choice = Convert.ToDouble(namepase.Text);
            string number = "";
            namepase.Text = number;
        }
        // +
        private void Plus_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)            
        {
            ing = "+";

            choice = Convert.ToDouble(namepase.Text);
            string number = "";
            namepase.Text = number;
        }
        //Delete 
        private void Delete_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)         
        {
            string number = "";
            namepase.Text = number;
            
            
        }
        // ) 
        private void Skob_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            string number = ")";
            namepase.Text += number;
        }
        // ( 
        private void Sko_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)            
        {
            string number = "(";
            namepase.Text += number;
        }
        // 9 
        private void Nine_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            string number = "9";
            namepase.Text += number;
        }
        // 8
        private void Eight_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            string number = "8";
            namepase.Text += number;
        }
        //7
        private void Seven_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)          
        {
            string number = "7";
            namepase.Text += number;
        }
        //6
        private void Six_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)             
        {
            string number = "6";
            namepase.Text += number;
        }
        //5
        private void Five_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)            
        {
            string number = "5";
            namepase.Text += number;
        }
        // ,
        private void Comma_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            if ((namepase.Text.IndexOf(",") == -1) && (namepase.Text.IndexOf(" ") == -1))
                namepase.Text += ",";
        }
        //0
        private void Null_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            string number = "0";
            namepase.Text += number;
        }
        //1
        private void One_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)             
        {
            string number = "1";
            namepase.Text += number;
        }
        //2
        private void Two_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)            
        {
            string number = "2";
            namepase.Text += number;
        }
        //3
        private void Three_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)          
        {
            string number = "3";
            namepase.Text += number;
        }
        //4
        private void Four_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)           
        {
            string number = "4";
            namepase.Text += number;
        }
    }
}