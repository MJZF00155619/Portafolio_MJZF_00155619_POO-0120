package com.MJZF.x00155619;

import java.util.Scanner;

public class Main {



    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        byte n;

        do {
            mainmenu();
            n = in.nextByte();
            in.nextLine();
            Laptop laptop1 = new Laptop("HP", "WINDOWS");
            switch (n) {

                case 1:    //Mostrar por marca y sistema operativo
                    laptop1.Encender();
                    //Mostrar por modelo
                    laptop1.Encender(34544);
                    break;
                case 2:
                    laptop1.Reiniciar("HP", "WINDOWS");
                    break;
                case 3:
                    laptop1.Apagar("HP", "WINDOWS");
                    break;

                case 4:
                    String extra;
                    System.out.println("¿Que sistema operativo extra desea?");
                    extra = in.nextLine();
                    laptop1.setOSextra(extra);break;
                case 5 :
                    System.out.println("El sistema operativo principal es: " + laptop1.getOS()+"\n");
            }
        }while(n!=0);
    }
    public static void mainmenu(){
        System.out.println("¿Que desea hacer?");
        System.out.println("1. Encender");
        System.out.println("2- Reiniciar");
        System.out.println("3. Apagar");
        System.out.println("4 Agregar Sistema Operativo extra");
        System.out.println("5 Ver el sistema operativo principal");
        System.out.println("0 para salir");
    }
}
