package com.MJZF.x00155619;

import java.util.Scanner;
import  java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        Scanner in = new Scanner(System.in);


        ArrayList<Libro> libros = new ArrayList<>();
        int ISBN=0;
        String nombreL;
        int paginas;


        byte n2;
                do {
                        System.out.println("¿Que desea hacer?");
                        menuLibros();

                        n2 = in.nextByte(); in.nextLine();
                        switch (n2){
                            case 1:
                                System.out.println("NOMBRE DEL LIBRO: "); nombreL = in.nextLine();
                                System.out.println("PAGINAS DEL LIBRO: "); paginas = in.nextInt(); in.nextLine();
                                libros.add(new Libro(ISBN, nombreL, paginas)); break;
                            case 2:
                                for (Libro e:libros
                                ) {
                                    System.out.println(e);
                                }break;
                            case 3:
                                System.out.println("INGRESE EL NOMBRE DEL LIBRO A ELIMINAR: "); nombreL = in.nextLine();
                                String finalNombreL = nombreL;

                                libros.removeIf(s -> s.getNombre().equalsIgnoreCase(finalNombreL));
                                System.out.println("Revise la lista para verificar...");
                                break;
                            default: if(n2!=0)System.out.println("Esa opcion no existe");break;
                        }
                    }while(n2!=0);
    }

    public static void menuLibros(){
        System.out.println("1. Agregar Libro");
        System.out.println("2. Mostrar Libros");
        System.out.println("3. Eliminar Libro");
        System.out.println("0  para salir");
    }
}
