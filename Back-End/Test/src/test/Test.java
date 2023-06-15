/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package test;

import java.util.ArrayList;
import pe.edu.pucp.cinemasoft.dao.GeneroDAO;
import pe.edu.pucp.cinemasoft.model.Genero;
import pe.edu.pucp.cinemasoft.mysql.GeneroMySQL;

/**
 *
 * @author joham
 */
public class Test {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        GeneroDAO daoGenero=new GeneroMySQL();
        ArrayList<Genero> arr=daoGenero.listarTodas();
        for(Genero g : arr){
            System.out.println(g.getNombre());
        }
    }
    
}
