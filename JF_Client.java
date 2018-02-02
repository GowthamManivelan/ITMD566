/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package serv;

import java.net.*;
import java.util.Scanner;
import java.io.*;
/**
 *
 * @author Jenny Feng, Gowtham Manivelan, Megshi Thakur
 */
public class JF_Client {
    public static void main (String args[]) {
        double number, number2, total;
        int count =0;
        String operator;
        try{
            Scanner input = new Scanner(System.in);
            Socket s = new Socket("localhost", 5000);
            PrintStream pr = new PrintStream(s.getOutputStream());
            
            System.out.print("Enter something: ");
            InputStreamReader rd = new InputStreamReader(System.in);
            BufferedReader ed = new BufferedReader(rd);
            
            String temp = ed.readLine();
            
            pr.println(temp);
            BufferedReader gt = new BufferedReader(new InputStreamReader(s.getInputStream()));
            String tm = gt.readLine();
            System.out.print(tm);
            
            Scanner sc1 = new Scanner(s.getInputStream());
            System.out.println("\nEnter number: ");
            number = input.nextDouble();
            System.out.println("Enter second number: ");
            number2=input.nextDouble();
            System.out.println("Enter operator symbol: ");
            operator = input.next();
            PrintStream p = new PrintStream(s.getOutputStream());
            p.println(number);
            p.println(number2);
            p.println(operator);
            total = sc1.nextDouble();
            System.out.println(number+operator+number2+"="+total);
            count++;
            
            System.out.println("client number " + count);
            
            
            
            s.close();
        }
        catch (Exception ex){
            ex.getMessage();
        }
        
    }
}
