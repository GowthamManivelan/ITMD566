/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package serv;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintStream;
import java.net.*;
import java.util.Scanner;

/**
 *
 * @author Jenny Feng, Gowtham Manivelan, Megshi Thakur
 */
public class Serv {
    
    
    public static void main(String[] args){
        double number1, number2, total;
        String operator;
        try{
            ServerSocket ss = new ServerSocket (5000);
            Socket s1= ss.accept();
            
            BufferedReader ed = new BufferedReader (new InputStreamReader(s1.getInputStream()));
            String txt = ed.readLine();
            System.out.print("Received: " + txt);
            
            PrintStream pr = new PrintStream (s1.getOutputStream());
            String t1 = "got it.";
            pr.println(t1);
            
            Scanner scan = new Scanner(s1.getInputStream());
            number1 = scan.nextDouble();
            number2 = scan.nextDouble();
            operator = scan.next();
             PrintStream p = new PrintStream (s1.getOutputStream());
             
            switch(operator){
                case "+":
                    total = number1 +number2;
                    p.println(total);
                    break;
                case "-":
                    total = number1 -number2;
                    p.println(total);
                    break;
                case "*":
                    total = number1 *number2;
                    p.println(total);
                    break;
                case "/":
                    total = number1 /number2;
                    p.println(total);
                    break;
                case "%":
                    total = number1 %number2;
                    p.println(total);
                    break;
                default:
                    System.out.print("\nPlease enter valid input");
                    break;
            }       
            
             ss.close();
             s1.close();
        }
        catch(Exception ex){
            ex.getMessage();
        }
    
    }
    
}
