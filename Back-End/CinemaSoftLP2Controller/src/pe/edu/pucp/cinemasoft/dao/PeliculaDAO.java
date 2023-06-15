/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package pe.edu.pucp.cinemasoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.cinemasoft.model.Pelicula;

/**
 *
 * @author joham
 */
public interface PeliculaDAO {
    int insertar(Pelicula pelicula);
    ArrayList<Pelicula> listarPorNombre(String nombre);
}
